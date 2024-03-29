﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestADB.UserControl
{
    class ADBCommands : Component
    {
        // ----------------------------------------- Adb.exe path, leave blank if in same directory as app or included in PATH
        private string adbPath;
        public string AdbPath
        {
            get { return adbPath; }
            set
            {
                if (File.Exists(value))
                    adbPath = value;
                else
                    adbPath = "\"" + adbPath + "\"";
            }
        }
        // ----------------------------------------- Adb command timeout - usable in push and pull to avoid hanging while executing
        private int adbTimeout;
        public int AdbTimeout
        {
            get { return adbTimeout > 0 ? adbTimeout : 5000; }
            set { adbTimeout = value; }
        }
        // ----------------------------------------- Create our emulated shell here and assign events

        // Create a background thread an assign work event to our emulated shell method
        BackgroundWorker CMD = new BackgroundWorker();

        private Process Shell;

        public string DeviceNumber { get; set; }

        // Needed data types for our emulated shell
        string Command = "";
        bool Complete = false;

        public ADBCommands(string path)
        {
            AdbPath = $"{path}\\adb.exe"; // Path Adb Server
            CMD.DoWork += new DoWorkEventHandler(CMD_Send);
        }


        // Create an emulated shell for executing commands
        private void CMD_Send(object sender, DoWorkEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                FileName = "cmd.exe",
                Arguments = "/C \"" + Command + "\""
            };


            using (Process process = Process.Start(startInfo))
            {
                if (Command.StartsWith("\"" + AdbPath + "\" logcat"))
                {
                    Complete = true;
                    process.WaitForExit();
                    return;
                }

                if (!process.WaitForExit(AdbTimeout))
                    process.Kill();

                Output = process.StandardOutput.ReadToEnd();
                Complete = true;
            };
        }



        // Send a command to emulated shell
        private void SendCommand(string command)
        {
            CMD.WorkerSupportsCancellation = true;
            Command = command;
            CMD.RunWorkerAsync();
            while (!Complete) Sleep(500);
            Complete = false;
        }

        // Sleep until output
        public void Sleep(int milliseconds)
        {
            DateTime delayTime = DateTime.Now.AddMilliseconds(milliseconds);
            while (DateTime.Now < delayTime)
            {
                Application.DoEvents();
            }
        }



        // Bootstate for rebooting
        public enum BootState
        {
            System,
            Bootloader,
            Recovery
        }
        // ----------------------------------------- Allow public modifiers to get output

        public string Output { get; private set; }

        // ----------------------------------------- Functions

        public void Connect(string ip)
        {
            SendCommand("\"" + AdbPath + "\" connect " + ip);
        }


        public void Disconnect(string ip)
        {
            SendCommand("\"" + AdbPath + "\" disconnect " + ip);
        }
        public void CreateTcp(int port)
        {
            SendCommand("\"" + AdbPath + "\" tcpip  " + port);
        }

        public void StartServer()
        {
            SendCommand("\"" + AdbPath + "\" start-server");
        }

        public void KillServer()
        {
            SendCommand("\"" + AdbPath + "\" kill-server");
        }

        public List<string> Devices()
        {
            SendCommand("\"" + AdbPath + "\" devices");
            string[] outLines = Output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return outLines.Skip(1).ToList();
        }

        public void Execute(string command, bool asroot)
        {
            if (asroot)
                SendCommand("\"" + AdbPath + $"\" -s {DeviceNumber} shell su -c \"" + command + "\"");
            else
                SendCommand("\"" + AdbPath + $"\" -s {DeviceNumber} shell " + command);
        }
        public void GetInfo()
        {
            SendCommand("\"" + AdbPath + $"\" -s {DeviceNumber} shell getprop");
        }
        public void ExecuteCommand(string command)
        {
            SendCommand(command);
        }

        public void Remount()
        {
            SendCommand("\"" + AdbPath + "\" shell su -c \"mount -o rw,remount /system\"");
        }
        public void Reboot(BootState boot)
        {
            switch (boot)
            {
                case BootState.System:
                    SendCommand("\"" + AdbPath + $"\" -s {DeviceNumber} reboot");
                    break;
                case BootState.Bootloader:
                    SendCommand("\"" + AdbPath + $"\" -s {DeviceNumber} reboot bootloader");
                    break;
                case BootState.Recovery:
                    SendCommand("\"" + AdbPath + $"\" -s {DeviceNumber} reboot recovery");
                    break;
            }
        }

        public void Push(string input, string output)
        {
            try
            {
                SendCommand("\"" + AdbPath + "\" push \"" + input + "\" \"" + output + "\"");
            }
            catch
            {
                try
                {
                    SendCommand("\"" + AdbPath + "\" push \"" + input.Replace("/", "\\") + "\" \"" + output + "\"");
                }
                catch
                {

                }
            }
        }

        public void Pull(string input, string output)
        {
            if (output != null && !string.IsNullOrWhiteSpace(output))
            {
                try
                {
                    SendCommand("\"" + AdbPath + "\" pull \"" + input + "\" \"" + output + "\"");
                }
                catch
                {
                    try
                    {
                        SendCommand("\"" + AdbPath + "\" pull \"" + input + "\" \"" + output.Replace("/", "\\") + "\"");
                    }
                    catch
                    {
                    }
                }
            }
            else
            {
                try
                {
                    SendCommand("\"" + AdbPath + "\" pull \"" + input + "\"");
                }
                catch
                {
                }
            }
        }

        public void Install(string application)
        {
            try
            {
                SendCommand("\"" + AdbPath + "\" install \"" + application + "\"");
            }
            catch
            {
                try
                {
                    SendCommand("\"" + AdbPath + "\" install \"" + application.Replace("/", "\\") + "\"");
                }
                catch
                {
                }
            }
        }


        public void Uninstall(string packageName)
        {
            SendCommand("\"" + AdbPath + "\" uninstall \"" + packageName + "\"");
        }

        public void Backup(string backupPath)
        {
            //if (backupArgs != null && !string.IsNullOrWhiteSpace(backupArgs))
                SendCommand("\"" + AdbPath + $"\" -s {DeviceNumber} backup -apk -shared -all -f \"" + backupPath + "\"");
            //else
            //    SendCommand("\"" + AdbPath + $"\" -s {DeviceNumber} backup -apk -shared -all -f \"" + backupPath + "\"");
        }

        public void Restore(string backupPath)
        {
            try
            {
                SendCommand("\"" + AdbPath + $"\" -s {DeviceNumber} restore \"" + backupPath + "\"");
            }
            catch
            {
                try
                {
                    SendCommand("\"" + AdbPath + $"\" -s {DeviceNumber} restore \"" + backupPath.Replace("/", "\\") + "\"");
                }
                catch
                {
                }
            }
        }

        public void Logcat(string logPath, bool overWrite)

        {

            if (overWrite == true)
                try
                {
                    SendCommand("\"" + AdbPath + "\" logcat > \"" + logPath + "\"");
                }
                catch
                {
                    try
                    {
                        SendCommand("\"" + AdbPath + "\" logcat > \"" + logPath.Replace("/", "\\") + "\"");
                    }
                    catch
                    {
                    }
                }
            else
            {
                try
                {
                    SendCommand("\"" + AdbPath + "\" logcat >> \"" + logPath + "\"");
                }
                catch
                {
                    try
                    {
                        SendCommand("\"" + AdbPath + "\" logcat >> \"" + logPath.Replace("/", "\\") + "\"");
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}

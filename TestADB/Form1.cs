using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestADB.UserControl;

namespace TestADB
{
    public partial class Form1 : Form
    {
        private ADBCommands adbCommands { get; set; }
        private string Logs { get; set; }

        public Form1()
        {
            InitializeComponent();
            adbCommands = new ADBCommands(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
            //var ss = "\"" + "montaser" + "\" -s 12332432 \"reboot bootloader\"";
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    adbCommands.Connect("192.168.3.15:5555");
        //}

        private void StartServerBtn_Click(object sender, EventArgs e)
        {
            adbCommands.StartServer();
            foreach (var item in adbCommands.Devices())
            {
                DevicesList.Items.Add(item);
            }
        }

        private void KillServerBtn_Click(object sender, EventArgs e)
        {
            adbCommands.KillServer();
            DevicesList.Items.Clear();
            LogsTxt.Text += "\n Killed server and clear devices list";
        }
        private ADBCommands.BootState? bootState;
        private void RebootBtn_Click(object sender, EventArgs e)
        {
            if (bootState != null)
                adbCommands.Reboot(bootState.Value);

        }

        private void RecoveryRadio_CheckedChanged(object sender, EventArgs e)
        {
            bootState = ADBCommands.BootState.Recovery;
        }

        private void BootloaderRadio_CheckedChanged(object sender, EventArgs e)
        {
            bootState = ADBCommands.BootState.Bootloader;
        }

        private void SystemRadio_CheckedChanged(object sender, EventArgs e)
        {
            bootState = ADBCommands.BootState.System;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(adbCommands.Output))
            {
                if (Logs != adbCommands.Output)
                {
                    LogsTxt.Text += adbCommands.Output;
                    Logs = adbCommands.Output;
                }
            }
        }

        //private void Button5_Click(object sender, EventArgs e)
        //{
        //    //adbCommands.Execute("netcfg", false);
        //    adbCommands.CreateTcp(5555);
        //}

        //private void Button7_Click(object sender, EventArgs e)
        //{

        //}

        //private void Button2_Click(object sender, EventArgs e)
        //{
        //    adbCommands.Disconnect("192.168.3.15:5555");
        //}

        private void DevicesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var split =((ListBox)sender).SelectedItem.ToString().Split('\t');
            adbCommands.DeviceNumber = split[0];
        }

        private void ExportBackupBtn_Click(object sender, EventArgs e)
        {

        }

        private void ImportBackupBtn_Click(object sender, EventArgs e)
        {

        }

        private void UnlockBtn_Click(object sender, EventArgs e)
        {
            //adbCommands.Execute("cd /data/data/com.android.providers.settings/databases" +
            //    "\nsqlite3 settings.db" +
            //    "\nupdate system set value=0 where name='lock_pattern_autolock';" +
            //    "\nupdate secure set value=0 where name='lock_pattern_autolock';" +
            //    "\nupdate system set value=0 where name='lockscreen.lockedoutpermanently';" +
            //    "\nupdate secure set value=0 where name='lockscreen.lockedoutpermanently';" +
            //    "\n.quit" +
            //    "\nexit", true);
            //adbCommands.Execute("rm /data/system/gesture.key", false);
            //adbCommands.Reboot(ADBCommands.BootState.System);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            adbCommands.GetInfo();
        }
    }
}

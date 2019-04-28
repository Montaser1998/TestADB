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
            var path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            adbCommands = new ADBCommands(path);
            //var ss = "\"" + "montaser" + "\" -s 12332432 \"reboot bootloader\"";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            adbCommands.Connect("192.168.3.15:5555");
        }

        private void StartServer_Click(object sender, EventArgs e)
        {
            adbCommands.StartServer();
            foreach (var item in adbCommands.Devices())
            {
                listBox1.Items.Add(item);
            }
        }

        private void KillServer_Click(object sender, EventArgs e)
        {
            adbCommands.KillServer();
            listBox1.Items.Clear();
            textBox1.Text += "\n Killed server and clear devices list";
        }
        private ADBCommands.BootState? bootState;
        private void Button6_Click(object sender, EventArgs e)
        {
            if (bootState != null)
                adbCommands.Reboot(bootState.Value);

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bootState = ADBCommands.BootState.Recovery;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bootState = ADBCommands.BootState.Bootloader;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            bootState = ADBCommands.BootState.System;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(adbCommands.Output))
            {
                if (Logs != adbCommands.Output)
                {
                    textBox1.Text += adbCommands.Output;
                    Logs = adbCommands.Output;
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //adbCommands.Execute("netcfg", false);
            adbCommands.CreateTcp(5555);
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            adbCommands.Disconnect("192.168.3.15:5555");
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var split =((ListBox)sender).SelectedItem.ToString().Split('\t');
            adbCommands.DeviceNumber = Convert.ToInt32(split[0]);
        }

        private void ExportBackup_Click(object sender, EventArgs e)
        {

        }

        private void ImportBackup_Click(object sender, EventArgs e)
        {

        }
    }
}

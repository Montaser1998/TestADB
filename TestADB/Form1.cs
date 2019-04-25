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
        public Form1()
        {
            InitializeComponent();
            adbCommands = new ADBCommands();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            adbCommands.Connect("");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            adbCommands.StartServer();
            foreach (var item in adbCommands.Devices())
            {
                listBox1.Items.Add(item);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            adbCommands.KillServer();
            listBox1.Items.Clear();
        }
    }
}

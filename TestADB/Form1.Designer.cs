namespace TestADB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartServerBtn = new System.Windows.Forms.Button();
            this.KillServerBtn = new System.Windows.Forms.Button();
            this.DevicesList = new System.Windows.Forms.ListBox();
            this.LogsTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExportBackupBtn = new System.Windows.Forms.Button();
            this.ImportBackupBtn = new System.Windows.Forms.Button();
            this.UnlockBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RebootBtn = new System.Windows.Forms.Button();
            this.SystemRadio = new System.Windows.Forms.RadioButton();
            this.BootloaderRadio = new System.Windows.Forms.RadioButton();
            this.RecaveryRadio = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartServerBtn
            // 
            this.StartServerBtn.Location = new System.Drawing.Point(3, 3);
            this.StartServerBtn.Name = "StartServerBtn";
            this.StartServerBtn.Size = new System.Drawing.Size(117, 34);
            this.StartServerBtn.TabIndex = 2;
            this.StartServerBtn.Text = "Start Server";
            this.StartServerBtn.UseVisualStyleBackColor = true;
            this.StartServerBtn.Click += new System.EventHandler(this.StartServerBtn_Click);
            // 
            // KillServerBtn
            // 
            this.KillServerBtn.Location = new System.Drawing.Point(126, 3);
            this.KillServerBtn.Name = "KillServerBtn";
            this.KillServerBtn.Size = new System.Drawing.Size(117, 34);
            this.KillServerBtn.TabIndex = 3;
            this.KillServerBtn.Text = "Kill Server";
            this.KillServerBtn.UseVisualStyleBackColor = true;
            this.KillServerBtn.Click += new System.EventHandler(this.KillServerBtn_Click);
            // 
            // DevicesList
            // 
            this.DevicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DevicesList.FormattingEnabled = true;
            this.DevicesList.ItemHeight = 20;
            this.DevicesList.Location = new System.Drawing.Point(3, 22);
            this.DevicesList.Name = "DevicesList";
            this.DevicesList.Size = new System.Drawing.Size(839, 175);
            this.DevicesList.TabIndex = 5;
            this.DevicesList.SelectedIndexChanged += new System.EventHandler(this.DevicesList_SelectedIndexChanged);
            // 
            // LogsTxt
            // 
            this.LogsTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogsTxt.Location = new System.Drawing.Point(3, 22);
            this.LogsTxt.Multiline = true;
            this.LogsTxt.Name = "LogsTxt";
            this.LogsTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogsTxt.Size = new System.Drawing.Size(620, 233);
            this.LogsTxt.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DevicesList);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 241);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devices";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.StartServerBtn);
            this.flowLayoutPanel1.Controls.Add(this.KillServerBtn);
            this.flowLayoutPanel1.Controls.Add(this.ExportBackupBtn);
            this.flowLayoutPanel1.Controls.Add(this.ImportBackupBtn);
            this.flowLayoutPanel1.Controls.Add(this.UnlockBtn);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 197);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(839, 41);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // ExportBackupBtn
            // 
            this.ExportBackupBtn.Location = new System.Drawing.Point(249, 3);
            this.ExportBackupBtn.Name = "ExportBackupBtn";
            this.ExportBackupBtn.Size = new System.Drawing.Size(124, 34);
            this.ExportBackupBtn.TabIndex = 4;
            this.ExportBackupBtn.Text = "Export Backup";
            this.ExportBackupBtn.UseVisualStyleBackColor = true;
            this.ExportBackupBtn.Click += new System.EventHandler(this.ExportBackupBtn_Click);
            // 
            // ImportBackupBtn
            // 
            this.ImportBackupBtn.Location = new System.Drawing.Point(379, 3);
            this.ImportBackupBtn.Name = "ImportBackupBtn";
            this.ImportBackupBtn.Size = new System.Drawing.Size(124, 34);
            this.ImportBackupBtn.TabIndex = 5;
            this.ImportBackupBtn.Text = "Import Backup";
            this.ImportBackupBtn.UseVisualStyleBackColor = true;
            this.ImportBackupBtn.Click += new System.EventHandler(this.ImportBackupBtn_Click);
            // 
            // UnlockBtn
            // 
            this.UnlockBtn.Location = new System.Drawing.Point(509, 3);
            this.UnlockBtn.Name = "UnlockBtn";
            this.UnlockBtn.Size = new System.Drawing.Size(111, 34);
            this.UnlockBtn.TabIndex = 11;
            this.UnlockBtn.Text = "Unlock";
            this.UnlockBtn.UseVisualStyleBackColor = true;
            this.UnlockBtn.Click += new System.EventHandler(this.UnlockBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LogsTxt);
            this.groupBox2.Location = new System.Drawing.Point(15, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 258);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logs";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RebootBtn);
            this.groupBox3.Controls.Add(this.SystemRadio);
            this.groupBox3.Controls.Add(this.BootloaderRadio);
            this.groupBox3.Controls.Add(this.RecaveryRadio);
            this.groupBox3.Location = new System.Drawing.Point(863, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 166);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reboot modes";
            // 
            // RebootBtn
            // 
            this.RebootBtn.Location = new System.Drawing.Point(74, 122);
            this.RebootBtn.Name = "RebootBtn";
            this.RebootBtn.Size = new System.Drawing.Size(88, 30);
            this.RebootBtn.TabIndex = 3;
            this.RebootBtn.Text = "Reboot";
            this.RebootBtn.UseVisualStyleBackColor = true;
            this.RebootBtn.Click += new System.EventHandler(this.RebootBtn_Click);
            // 
            // SystemRadio
            // 
            this.SystemRadio.AutoSize = true;
            this.SystemRadio.Location = new System.Drawing.Point(7, 92);
            this.SystemRadio.Name = "SystemRadio";
            this.SystemRadio.Size = new System.Drawing.Size(141, 24);
            this.SystemRadio.TabIndex = 2;
            this.SystemRadio.TabStop = true;
            this.SystemRadio.Text = "Reboot system";
            this.SystemRadio.UseVisualStyleBackColor = true;
            this.SystemRadio.CheckedChanged += new System.EventHandler(this.SystemRadio_CheckedChanged);
            // 
            // BootloaderRadio
            // 
            this.BootloaderRadio.AutoSize = true;
            this.BootloaderRadio.Location = new System.Drawing.Point(7, 61);
            this.BootloaderRadio.Name = "BootloaderRadio";
            this.BootloaderRadio.Size = new System.Drawing.Size(185, 24);
            this.BootloaderRadio.TabIndex = 1;
            this.BootloaderRadio.TabStop = true;
            this.BootloaderRadio.Text = "Reboot to bootloader";
            this.BootloaderRadio.UseVisualStyleBackColor = true;
            this.BootloaderRadio.CheckedChanged += new System.EventHandler(this.BootloaderRadio_CheckedChanged);
            // 
            // RecaveryRadio
            // 
            this.RecaveryRadio.AutoSize = true;
            this.RecaveryRadio.Location = new System.Drawing.Point(7, 30);
            this.RecaveryRadio.Name = "RecaveryRadio";
            this.RecaveryRadio.Size = new System.Drawing.Size(168, 24);
            this.RecaveryRadio.TabIndex = 0;
            this.RecaveryRadio.TabStop = true;
            this.RecaveryRadio.Text = "Reboot to recavery";
            this.RecaveryRadio.UseVisualStyleBackColor = true;
            this.RecaveryRadio.CheckedChanged += new System.EventHandler(this.RecoveryRadio_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Get Info for device";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test ADB";
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartServerBtn;
        private System.Windows.Forms.Button KillServerBtn;
        private System.Windows.Forms.ListBox DevicesList;
        private System.Windows.Forms.TextBox LogsTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RebootBtn;
        private System.Windows.Forms.RadioButton SystemRadio;
        private System.Windows.Forms.RadioButton BootloaderRadio;
        private System.Windows.Forms.RadioButton RecaveryRadio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ExportBackupBtn;
        private System.Windows.Forms.Button ImportBackupBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button UnlockBtn;
        private System.Windows.Forms.Button button1;
    }
}


namespace UARTTest
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.comboBoxComport = new System.Windows.Forms.ComboBox();
            this.ComportLabel = new System.Windows.Forms.Label();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.BaudrateLabel = new System.Windows.Forms.Label();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.DataTextBox = new System.Windows.Forms.RichTextBox();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDownSpam = new System.Windows.Forms.NumericUpDown();
            this.ClearDataTextBoxButton = new System.Windows.Forms.Button();
            this.groupBoxComport = new System.Windows.Forms.GroupBox();
            this.CONNECTEDSTATUS = new System.Windows.Forms.Label();
            this.DataSendBox = new System.Windows.Forms.TextBox();
            this.SendDataButton = new System.Windows.Forms.Button();
            this.PanicButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendSpam = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpam)).BeginInit();
            this.groupBoxComport.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxComport
            // 
            this.comboBoxComport.AllowDrop = true;
            this.comboBoxComport.FormattingEnabled = true;
            this.comboBoxComport.Location = new System.Drawing.Point(85, 20);
            this.comboBoxComport.Name = "comboBoxComport";
            this.comboBoxComport.Size = new System.Drawing.Size(172, 21);
            this.comboBoxComport.TabIndex = 0;
            this.comboBoxComport.Text = "COM4";
            this.comboBoxComport.SelectedIndexChanged += new System.EventHandler(this.ComboBoxComport_SelectedIndexChanged);
            // 
            // ComportLabel
            // 
            this.ComportLabel.AutoSize = true;
            this.ComportLabel.Location = new System.Drawing.Point(12, 24);
            this.ComportLabel.Name = "ComportLabel";
            this.ComportLabel.Size = new System.Drawing.Size(64, 13);
            this.ComportLabel.TabIndex = 1;
            this.ComportLabel.Text = "COM PORT";
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.AllowDrop = true;
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "115200"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(85, 47);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(172, 21);
            this.comboBoxBaudrate.TabIndex = 2;
            this.comboBoxBaudrate.Text = "9600";
            // 
            // BaudrateLabel
            // 
            this.BaudrateLabel.AutoSize = true;
            this.BaudrateLabel.Location = new System.Drawing.Point(12, 50);
            this.BaudrateLabel.Name = "BaudrateLabel";
            this.BaudrateLabel.Size = new System.Drawing.Size(69, 13);
            this.BaudrateLabel.TabIndex = 3;
            this.BaudrateLabel.Text = "BAUD RATE";
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(15, 74);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpen.TabIndex = 4;
            this.ButtonOpen.Text = "OPEN";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(96, 74);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 5;
            this.ButtonClose.Text = "CLOSE";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.Button2_Click);
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(260, 12);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.ReadOnly = true;
            this.DataTextBox.Size = new System.Drawing.Size(263, 231);
            this.DataTextBox.TabIndex = 6;
            this.DataTextBox.Text = "";
            // 
            // toolTips
            // 
            this.toolTips.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // numericUpDownSpam
            // 
            this.numericUpDownSpam.Location = new System.Drawing.Point(177, 252);
            this.numericUpDownSpam.Name = "numericUpDownSpam";
            this.numericUpDownSpam.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownSpam.TabIndex = 15;
            this.toolTips.SetToolTip(this.numericUpDownSpam, "Value dictates the amount of times the spam button sends the message");
            this.numericUpDownSpam.ValueChanged += new System.EventHandler(this.NumericUpDownSpam_ValueChanged);
            // 
            // ClearDataTextBoxButton
            // 
            this.ClearDataTextBoxButton.Location = new System.Drawing.Point(260, 249);
            this.ClearDataTextBoxButton.Name = "ClearDataTextBoxButton";
            this.ClearDataTextBoxButton.Size = new System.Drawing.Size(263, 23);
            this.ClearDataTextBoxButton.TabIndex = 8;
            this.ClearDataTextBoxButton.Text = "CLEAR";
            this.ClearDataTextBoxButton.UseVisualStyleBackColor = true;
            this.ClearDataTextBoxButton.Click += new System.EventHandler(this.ClearDataTextBoxButton_Click);
            // 
            // groupBoxComport
            // 
            this.groupBoxComport.Controls.Add(this.CONNECTEDSTATUS);
            this.groupBoxComport.Location = new System.Drawing.Point(15, 103);
            this.groupBoxComport.Name = "groupBoxComport";
            this.groupBoxComport.Size = new System.Drawing.Size(156, 48);
            this.groupBoxComport.TabIndex = 9;
            this.groupBoxComport.TabStop = false;
            this.groupBoxComport.Text = "COMPORT STATUS";
            // 
            // CONNECTEDSTATUS
            // 
            this.CONNECTEDSTATUS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CONNECTEDSTATUS.AutoSize = true;
            this.CONNECTEDSTATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONNECTEDSTATUS.Location = new System.Drawing.Point(6, 16);
            this.CONNECTEDSTATUS.Name = "CONNECTEDSTATUS";
            this.CONNECTEDSTATUS.Size = new System.Drawing.Size(148, 20);
            this.CONNECTEDSTATUS.TabIndex = 0;
            this.CONNECTEDSTATUS.Text = "DISCONNECTED";
            this.CONNECTEDSTATUS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataSendBox
            // 
            this.DataSendBox.Location = new System.Drawing.Point(15, 223);
            this.DataSendBox.Name = "DataSendBox";
            this.DataSendBox.Size = new System.Drawing.Size(156, 20);
            this.DataSendBox.TabIndex = 10;
            // 
            // SendDataButton
            // 
            this.SendDataButton.Location = new System.Drawing.Point(15, 249);
            this.SendDataButton.Name = "SendDataButton";
            this.SendDataButton.Size = new System.Drawing.Size(75, 23);
            this.SendDataButton.TabIndex = 11;
            this.SendDataButton.Text = "Send";
            this.SendDataButton.UseVisualStyleBackColor = true;
            this.SendDataButton.Click += new System.EventHandler(this.SendDataButton_Click);
            // 
            // PanicButton
            // 
            this.PanicButton.Location = new System.Drawing.Point(15, 157);
            this.PanicButton.Name = "PanicButton";
            this.PanicButton.Size = new System.Drawing.Size(154, 23);
            this.PanicButton.TabIndex = 12;
            this.PanicButton.Text = "what the fuck i\'m confused";
            this.PanicButton.UseVisualStyleBackColor = true;
            this.PanicButton.Click += new System.EventHandler(this.PanicButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.changeLogToolStripMenuItem,
            this.githubToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.helpToolStripMenuItem.Text = "File";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // changeLogToolStripMenuItem
            // 
            this.changeLogToolStripMenuItem.Name = "changeLogToolStripMenuItem";
            this.changeLogToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.changeLogToolStripMenuItem.Text = "ChangeLog";
            this.changeLogToolStripMenuItem.Click += new System.EventHandler(this.ChangeLogToolStripMenuItem_Click);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.GithubToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SendSpam
            // 
            this.SendSpam.Location = new System.Drawing.Point(96, 249);
            this.SendSpam.Name = "SendSpam";
            this.SendSpam.Size = new System.Drawing.Size(75, 23);
            this.SendSpam.TabIndex = 14;
            this.SendSpam.Text = "Send Spam";
            this.SendSpam.UseVisualStyleBackColor = true;
            this.SendSpam.Click += new System.EventHandler(this.SendSpam_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Location = new System.Drawing.Point(177, 74);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(75, 23);
            this.ButtonSettings.TabIndex = 16;
            this.ButtonSettings.Text = "SETTINGS";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(178, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "+CR";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(178, 119);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(44, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "+LF";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // AppForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(533, 281);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.numericUpDownSpam);
            this.Controls.Add(this.SendSpam);
            this.Controls.Add(this.PanicButton);
            this.Controls.Add(this.SendDataButton);
            this.Controls.Add(this.DataSendBox);
            this.Controls.Add(this.groupBoxComport);
            this.Controls.Add(this.ClearDataTextBoxButton);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.BaudrateLabel);
            this.Controls.Add(this.comboBoxBaudrate);
            this.Controls.Add(this.ComportLabel);
            this.Controls.Add(this.comboBoxComport);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AppForm";
            this.Load += new System.EventHandler(this.AppForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpam)).EndInit();
            this.groupBoxComport.ResumeLayout(false);
            this.groupBoxComport.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ComportLabel;
        private System.Windows.Forms.Label BaudrateLabel;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.RichTextBox DataTextBox;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button ClearDataTextBoxButton;
        private System.Windows.Forms.GroupBox groupBoxComport;
        private System.Windows.Forms.Label CONNECTEDSTATUS;
        private System.Windows.Forms.TextBox DataSendBox;
        private System.Windows.Forms.Button SendDataButton;
        private System.Windows.Forms.Button PanicButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLogToolStripMenuItem;
        private System.Windows.Forms.Button SendSpam;
        private System.Windows.Forms.NumericUpDown numericUpDownSpam;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        public System.Windows.Forms.ComboBox comboBoxComport;
        public System.Windows.Forms.ComboBox comboBoxBaudrate;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.IO.Ports.SerialPort serialPort;
    }
}


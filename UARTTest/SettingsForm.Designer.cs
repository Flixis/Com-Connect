namespace UARTTest
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.BaudrateLabel = new System.Windows.Forms.Label();
            this.comboBoxBaudrateS = new System.Windows.Forms.ComboBox();
            this.ComportLabel = new System.Windows.Forms.Label();
            this.comboBoxComportS = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.DataBitsLabel = new System.Windows.Forms.Label();
            this.ParityLabel = new System.Windows.Forms.Label();
            this.checkBox1bit = new System.Windows.Forms.CheckBox();
            this.checkBox2bits = new System.Windows.Forms.CheckBox();
            this.groupBoxBits = new System.Windows.Forms.GroupBox();
            this.groupBoxHFC = new System.Windows.Forms.GroupBox();
            this.HFC485 = new System.Windows.Forms.CheckBox();
            this.HFCDTR = new System.Windows.Forms.CheckBox();
            this.groupBoxHFCN = new System.Windows.Forms.CheckBox();
            this.HFCRTS = new System.Windows.Forms.CheckBox();
            this.buttonSaveS = new System.Windows.Forms.Button();
            this.groupBoxBits.SuspendLayout();
            this.groupBoxHFC.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaudrateLabel
            // 
            this.BaudrateLabel.AutoSize = true;
            this.BaudrateLabel.Location = new System.Drawing.Point(265, 9);
            this.BaudrateLabel.Name = "BaudrateLabel";
            this.BaudrateLabel.Size = new System.Drawing.Size(69, 13);
            this.BaudrateLabel.TabIndex = 7;
            this.BaudrateLabel.Text = "BAUD RATE";
            // 
            // comboBoxBaudrateS
            // 
            this.comboBoxBaudrateS.AllowDrop = true;
            this.comboBoxBaudrateS.FormattingEnabled = true;
            this.comboBoxBaudrateS.Location = new System.Drawing.Point(335, 6);
            this.comboBoxBaudrateS.Name = "comboBoxBaudrateS";
            this.comboBoxBaudrateS.Size = new System.Drawing.Size(172, 21);
            this.comboBoxBaudrateS.TabIndex = 6;
            // 
            // ComportLabel
            // 
            this.ComportLabel.AutoSize = true;
            this.ComportLabel.Location = new System.Drawing.Point(12, 9);
            this.ComportLabel.Name = "ComportLabel";
            this.ComportLabel.Size = new System.Drawing.Size(64, 13);
            this.ComportLabel.TabIndex = 5;
            this.ComportLabel.Text = "COM PORT";
            // 
            // comboBoxComportS
            // 
            this.comboBoxComportS.AllowDrop = true;
            this.comboBoxComportS.FormattingEnabled = true;
            this.comboBoxComportS.Location = new System.Drawing.Point(82, 6);
            this.comboBoxComportS.Name = "comboBoxComportS";
            this.comboBoxComportS.Size = new System.Drawing.Size(172, 21);
            this.comboBoxComportS.TabIndex = 4;
            this.comboBoxComportS.SelectedIndexChanged += new System.EventHandler(this.ComboBoxComportS_SelectedIndexChanged);
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.AllowDrop = true;
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(82, 33);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(172, 21);
            this.comboBoxDataBits.TabIndex = 8;
            this.comboBoxDataBits.Text = "8";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.AllowDrop = true;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN",
            "MARK",
            "SPACE"});
            this.comboBoxParity.Location = new System.Drawing.Point(335, 33);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(172, 21);
            this.comboBoxParity.TabIndex = 9;
            this.comboBoxParity.Text = "None";
            // 
            // DataBitsLabel
            // 
            this.DataBitsLabel.AutoSize = true;
            this.DataBitsLabel.Location = new System.Drawing.Point(12, 36);
            this.DataBitsLabel.Name = "DataBitsLabel";
            this.DataBitsLabel.Size = new System.Drawing.Size(63, 13);
            this.DataBitsLabel.TabIndex = 12;
            this.DataBitsLabel.Text = "DATA BITS";
            // 
            // ParityLabel
            // 
            this.ParityLabel.AutoSize = true;
            this.ParityLabel.Location = new System.Drawing.Point(265, 36);
            this.ParityLabel.Name = "ParityLabel";
            this.ParityLabel.Size = new System.Drawing.Size(46, 13);
            this.ParityLabel.TabIndex = 14;
            this.ParityLabel.Text = "PARITY";
            // 
            // checkBox1bit
            // 
            this.checkBox1bit.AutoSize = true;
            this.checkBox1bit.Location = new System.Drawing.Point(6, 22);
            this.checkBox1bit.Name = "checkBox1bit";
            this.checkBox1bit.Size = new System.Drawing.Size(43, 17);
            this.checkBox1bit.TabIndex = 16;
            this.checkBox1bit.Text = "1bit";
            this.checkBox1bit.UseVisualStyleBackColor = true;
            // 
            // checkBox2bits
            // 
            this.checkBox2bits.AutoSize = true;
            this.checkBox2bits.Location = new System.Drawing.Point(55, 22);
            this.checkBox2bits.Name = "checkBox2bits";
            this.checkBox2bits.Size = new System.Drawing.Size(48, 17);
            this.checkBox2bits.TabIndex = 17;
            this.checkBox2bits.Text = "2bits";
            this.checkBox2bits.UseVisualStyleBackColor = true;
            // 
            // groupBoxBits
            // 
            this.groupBoxBits.Controls.Add(this.checkBox1bit);
            this.groupBoxBits.Controls.Add(this.checkBox2bits);
            this.groupBoxBits.Location = new System.Drawing.Point(15, 60);
            this.groupBoxBits.Name = "groupBoxBits";
            this.groupBoxBits.Size = new System.Drawing.Size(107, 47);
            this.groupBoxBits.TabIndex = 18;
            this.groupBoxBits.TabStop = false;
            this.groupBoxBits.Text = "STOPBITS";
            // 
            // groupBoxHFC
            // 
            this.groupBoxHFC.Controls.Add(this.HFC485);
            this.groupBoxHFC.Controls.Add(this.HFCDTR);
            this.groupBoxHFC.Controls.Add(this.groupBoxHFCN);
            this.groupBoxHFC.Controls.Add(this.HFCRTS);
            this.groupBoxHFC.Location = new System.Drawing.Point(268, 60);
            this.groupBoxHFC.Name = "groupBoxHFC";
            this.groupBoxHFC.Size = new System.Drawing.Size(182, 73);
            this.groupBoxHFC.TabIndex = 19;
            this.groupBoxHFC.TabStop = false;
            this.groupBoxHFC.Text = "HARDWARE FLOW CONTROL";
            // 
            // HFC485
            // 
            this.HFC485.AutoSize = true;
            this.HFC485.Location = new System.Drawing.Point(102, 45);
            this.HFC485.Name = "HFC485";
            this.HFC485.Size = new System.Drawing.Size(73, 17);
            this.HFC485.TabIndex = 19;
            this.HFC485.Text = "RS485-rts";
            this.HFC485.UseVisualStyleBackColor = true;
            // 
            // HFCDTR
            // 
            this.HFCDTR.AutoSize = true;
            this.HFCDTR.Location = new System.Drawing.Point(6, 45);
            this.HFCDTR.Name = "HFCDTR";
            this.HFCDTR.Size = new System.Drawing.Size(77, 17);
            this.HFCDTR.TabIndex = 18;
            this.HFCDTR.Text = "DTR/DSR";
            this.HFCDTR.UseVisualStyleBackColor = true;
            // 
            // groupBoxHFCN
            // 
            this.groupBoxHFCN.AutoSize = true;
            this.groupBoxHFCN.Location = new System.Drawing.Point(6, 22);
            this.groupBoxHFCN.Name = "groupBoxHFCN";
            this.groupBoxHFCN.Size = new System.Drawing.Size(52, 17);
            this.groupBoxHFCN.TabIndex = 16;
            this.groupBoxHFCN.Text = "None";
            this.groupBoxHFCN.UseVisualStyleBackColor = true;
            // 
            // HFCRTS
            // 
            this.HFCRTS.AutoSize = true;
            this.HFCRTS.Location = new System.Drawing.Point(102, 22);
            this.HFCRTS.Name = "HFCRTS";
            this.HFCRTS.Size = new System.Drawing.Size(74, 17);
            this.HFCRTS.TabIndex = 17;
            this.HFCRTS.Text = "RTS/CTS";
            this.HFCRTS.UseVisualStyleBackColor = true;
            // 
            // buttonSaveS
            // 
            this.buttonSaveS.Location = new System.Drawing.Point(15, 124);
            this.buttonSaveS.Name = "buttonSaveS";
            this.buttonSaveS.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveS.TabIndex = 20;
            this.buttonSaveS.Text = "Save";
            this.buttonSaveS.UseVisualStyleBackColor = true;
            this.buttonSaveS.Click += new System.EventHandler(this.ButtonSaveS_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 159);
            this.Controls.Add(this.buttonSaveS);
            this.Controls.Add(this.groupBoxHFC);
            this.Controls.Add(this.groupBoxBits);
            this.Controls.Add(this.ParityLabel);
            this.Controls.Add(this.DataBitsLabel);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.BaudrateLabel);
            this.Controls.Add(this.comboBoxBaudrateS);
            this.Controls.Add(this.ComportLabel);
            this.Controls.Add(this.comboBoxComportS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBoxBits.ResumeLayout(false);
            this.groupBoxBits.PerformLayout();
            this.groupBoxHFC.ResumeLayout(false);
            this.groupBoxHFC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BaudrateLabel;
        private System.Windows.Forms.ComboBox comboBoxBaudrateS;
        private System.Windows.Forms.Label ComportLabel;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label DataBitsLabel;
        private System.Windows.Forms.Label ParityLabel;
        private System.Windows.Forms.CheckBox checkBox1bit;
        private System.Windows.Forms.CheckBox checkBox2bits;
        private System.Windows.Forms.GroupBox groupBoxBits;
        private System.Windows.Forms.GroupBox groupBoxHFC;
        private System.Windows.Forms.CheckBox HFC485;
        private System.Windows.Forms.CheckBox HFCDTR;
        private System.Windows.Forms.CheckBox groupBoxHFCN;
        private System.Windows.Forms.CheckBox HFCRTS;
        private System.Windows.Forms.Button buttonSaveS;
        public System.Windows.Forms.ComboBox comboBoxComportS;
    }
}
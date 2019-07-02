using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UARTTest
{
    public partial class SettingsForm : Form
    {
        AppForm Aform = new AppForm();
        public SettingsForm()
        {
            this.Load += SettingsForm_Load;
            InitializeComponent();
            comboBoxComportS.Items.Add(Aform.Unimplemented);
            comboBoxBaudrateS.Items.Add(Aform.Unimplemented);


            //hardcoded default serial settings
            Aform.serialPort.DataBits = int.Parse(comboBoxDataBits.Text);
            comboBoxDataBits.Text = Aform.serialPort.DataBits.ToString();
            Console.WriteLine(comboBoxDataBits.Text + "combodatabits");
            Console.WriteLine(Aform.serialPort.DataBits + "serialportdatabits");
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //Load AppForm.cs into this this.cs
            
        }

        private void ButtonSaveS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

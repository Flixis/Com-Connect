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
        Form _parentForm;

        public SettingsForm(Form frm)
        {
            this.Load += SettingsForm_Load;
            InitializeComponent();
            _parentForm = frm;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
           

        }

        private void ButtonSaveS_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();
        }

        private void ComboBoxComportS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

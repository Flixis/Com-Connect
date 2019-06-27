using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UARTTest
{
    public partial class ChangelogForm : Form
    {
        public ChangelogForm()
        {
            this.Load += ChangelogForm_Load;
            InitializeComponent();
        }

        private void ChangelogForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LinkLabelGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //on click open git issues page
            System.Diagnostics.Process.Start("https://github.com/Flixis/Com-Connect/issues");
        }
    }
}

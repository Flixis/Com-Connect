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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            this.Load += AboutForm_Load;
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}

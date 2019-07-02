using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using AutoUpdaterDotNET;

namespace UARTTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            AutoUpdater.Start("https://drive.google.com/uc?id=1d36D2-_15OmMQZse66M11r-T0FpikxbG");
            AutoUpdater.DownloadPath = Environment.CurrentDirectory;
            AutoUpdater.Mandatory = true;
            AutoUpdater.OpenDownloadPage = false;
            AutoUpdater.ReportErrors = true;

            //Try to load APP
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new AppForm());
            }
            catch (Exception err)//If failed to launch display error in message box
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}

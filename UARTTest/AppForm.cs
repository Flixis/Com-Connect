using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.Win32;
using System.Globalization;
using System.Reflection;
using System.Diagnostics;

namespace UARTTest
{

    public partial class AppForm : Form
    {
        string rxString; //String for data receive handeling

        //Usefull Strings?
        string Unimplemented = "Function is currently Unimplemented";

        //Get Windows Versions.
        Version vs = Environment.OSVersion.Version;

        /*Testing messagebox for whatever
        MessageBox.Show(VersionApp, "WTF is wrong with you?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        */


        public AppForm()
        {
            //Get version APP
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string VersionApp = fvi.FileVersion;

            //Display FormTextName + Versionnumber as AppName
            this.Text = "Send and Receive Project " + VersionApp;


            if (vs.Major <= 6.2)
            {
                //if not windows 10, warn user.
                this.Load += Form1_Load;
                InitializeComponent();
                MessageBox.Show("This version of windows is not tested, please update to Windows 10.", "Windows outdated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(vs.Major < 6)
            {
                //if not windows 7 or up refuse opening
                MessageBox.Show("This app requires windows 7 or higher.", "WTF is wrong with you?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                Environment.Exit(1);
            }
            else
            {
                //if windows 10 load the form and Initialize the app.
                this.Load += Form1_Load;
                InitializeComponent();
            }

            //Set default button and text status
            ButtonOpen.Enabled = true;
            ButtonClose.Enabled = false;
            CONNECTEDSTATUS.Text = "DISCONNECTED";
            
        }

        //get serialports and put in combobox1
        void Form1_Load(object sender, EventArgs e)
        {
            //Add Comports from PC to ComboBoxComport
            string[] ports = SerialPort.GetPortNames();
            comboBoxComport.Items.AddRange(ports);
        }

        //on button click open serialport with set settings
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //serial settings from app input
                serialPort.PortName = comboBoxComport.Text;
                serialPort.BaudRate = Convert.ToInt32(comboBoxBaudrate.Text);

                //hardcoded default serial settings
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.Handshake = Handshake.None;
                serialPort.RtsEnable = false;

                serialPort.Open();

                //change default button status to connect status.
                CONNECTEDSTATUS.Text = "CONNECTED";
                ButtonOpen.Enabled = false;
                ButtonClose.Enabled = true;
                //add incoming data to DataBox and add CR+LF 
                DataTextBox.AppendText(Environment.NewLine);
                DataTextBox.AppendText(String.Format("COMPORT OPEN",Environment.NewLine));
            }
            //if failed catch the error and display error
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //if button 2 is clicked close the serialport and change status back
        private void Button2_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                ButtonOpen.Enabled = true;
                ButtonClose.Enabled = false;
                CONNECTEDSTATUS.Text = "DISCONNECTED";

                DataTextBox.AppendText(Environment.NewLine);
                DataTextBox.AppendText(String.Format("COMPORT CLOSED" , Environment.NewLine));
            }
        }

        private void ClearDataTextBoxButton_Click(object sender, EventArgs e)
        {
            //clear text in datatextbox on button press
            DataTextBox.Clear();
        }

        //handle the data receiving from serialport
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            rxString = serialPort.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }
        //print handler for text got from serialPort1_DataReceived function
        private void DisplayText(object o, EventArgs e)
        {
            //print text to datatextbox
            DataTextBox.AppendText(rxString);
            DataTextBox.ScrollToCaret();

        }

        
        private void SendDataButton_Click(object sender, EventArgs e)
        {
            /*This one is a little difficult, but here it goes.
             
            The data that is being send has to be a byte because of the way we send and receive data over serial*1, because of this I couldn't just simply send a string.
            Instead we're converting a String to a Byte. This Byte can't just be read from the textbox so it has to be converted to a byte which can be seen at variable "bytes".
            after I convert whatever the text is in the textbox I write it to the serialport.
            serialport.write requires a few things, explained here: serialPort.Write(data, offset, Length);

            *1 You can send ASCII over serial I just couldn't be bothered to figure that out.
             
             */
            try
            {
                var bytes = DataSendBox.Text.Split(' ').Select(h => byte.Parse(h, NumberStyles.AllowHexSpecifier)).ToArray();
                serialPort.Write(bytes, 0, bytes.Length);
            }
            //If something happens that isn't supposed to happen I don't just want the program to crash, so instead I catch the error and display it to the user.
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //TODO Currently bugged, if err then display err x10 must fix before release!!!!!!
        private void SendSpam_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Unimplemented, Unimplemented, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
            /* 
            int n = 0;

            while (n < 10)
            {
                try
                {
                    SendDataButton_Click(sender, e);
                    n++;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //On click show AboutForm.cs
            new AboutForm().Show();
        }

        private void PanicButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The send functionally doesn't require the '0x' Prefix." + Environment.NewLine + Environment.NewLine +
                "Comports currently do not automatically update, this requires a program restart.", "What the fuck?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(1);
        }


        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
            //required for app properties
        }

        private void ChangeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //On click show AboutForm.cs
            new ChangelogForm().Show();
        }


    }
}

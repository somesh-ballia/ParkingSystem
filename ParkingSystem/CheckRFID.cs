using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class CheckRFID : Form
    {
        public CheckRFID()
        {
            InitializeComponent();
        }

        static string RFID = "";
        static string PORT = "";

        private void CheckRFID_Load(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            comport.BaudRate = 9600;
            comport.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
            comport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "1");

            foreach (string portName in port)
            {
                comport.PortName = portName;                
                if (comport.IsOpen) comport.Close();
                try
                {
                    comport.Open();
                    if (comport.IsOpen)
                    {
                        timer1.Start();
                        PORT = portName;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RFID = comport.ReadExisting();
            comport.DiscardInBuffer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RFID.Length > 10)
            {
                timer1.Stop();
                Program.PORT = PORT;               
                USER objU = new USER();                
                try
                {
                    comport.Close();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    objU.Show();
                    this.Close();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParkingSystem
{
    public partial class USER : Form
    {
        public USER()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(Program.ConnectionString);
        SqlCommand command;
        SqlCommand command1;
                
        static string RFID ="";

        string ConnString = Program.ConnectionString;

        private void USER_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.AccessControl = false;
        }

        private void USER_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    comport.PortName = Program.PORT;
                    if (comport.IsOpen) comport.Close();
                    try
                    {
                        comport.Open();
                        if (comport.IsOpen)
                        {
                            timerCheck.Start();                           
                        }
                    }
                    catch (Exception ex)
                    {
                        toolStripStatusLStatus.Text = "ERROR READING RFID READER";
                    }

                }
                catch (Exception ex)
                {
                    toolStripStatusLStatus.Text = "ERROR READING RFID READER";
                }

                //Fetching total number of Vehicles parked
                count();

                // Fetching the payment mode            
                SqlParameter PaymentMode = new SqlParameter("@PaymentMode", SqlDbType.VarChar, 10);
                SqlParameter Location = new SqlParameter("@Location", SqlDbType.VarChar, 20);
                PaymentMode.Direction = ParameterDirection.Output;
                Location.Direction = ParameterDirection.Input;
                Location.Value = Program.Location;
                command = new SqlCommand("select @PaymentMode = PaymentMode from configuration where Location = @Location", connection);
                command.Parameters.Add(PaymentMode);
                command.Parameters.Add(Location);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    Program.PaymentMode = PaymentMode.Value.ToString();
                }
                catch (Exception ex)
                {
                    toolStripStatusLStatus.Text = "DEFAULT PAYMENT MODE SET TO STATIC";
                    Program.PaymentMode = "STATIC";
                    //Program.PaymentMode = "DYNAMIC";
                }

            }
            catch (Exception ex)
            {
                toolStripStatusLStatus.Text = "RFID READ ERROR";
            }
        }

        private void buttonRecharge_Click(object sender, EventArgs e)
        {
            toolStripStatusLStatus.Text = "";
            if (Program.UserAccessControl == false)
            {
                Program.UserAccessControl = true;
                Recharge objR = new Recharge();
                objR.MdiParent = this;
                objR.Show();
            }
            else
            {
                toolStripStatusLStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonCheckBalance_Click(object sender, EventArgs e)
        {
            toolStripStatusLStatus.Text = "";
            if (Program.UserAccessControl == false)
            {
                Program.UserAccessControl = true;
                Balance objB = new Balance();
                objB.MdiParent = this;
                objB.Show();
            }
            else
            {
                toolStripStatusLStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            toolStripStatusLStatus.Text = "";
            if (Program.UserAccessControl == false)
            {                
                Program.UserAccessControl = true;
                Entry objE = new Entry();
                objE.MdiParent = this;
                objE.Show();                
            }
            else
            {
                toolStripStatusLStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            toolStripStatusLStatus.Text = "";
            if (Program.UserAccessControl == false)
            {
                Program.UserAccessControl = true;
                Exit objEx = new Exit();
                objEx.MdiParent = this;
                objEx.Show();                
            }
            else
            {
                toolStripStatusLStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonFlag_Click(object sender, EventArgs e)
        {
            toolStripStatusLStatus.Text = "";
            if (Program.UserAccessControl == false)
            {
                Program.UserAccessControl = true;
                AddVehicleList objAVL = new AddVehicleList();
                objAVL.MdiParent = this;
                objAVL.Show();
            }
            else
            {
                toolStripStatusLStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonRegisterCard_Click(object sender, EventArgs e)
        {
            toolStripStatusLStatus.Text = "";
            if (Program.UserAccessControl == false)
            {
                Program.UserAccessControl = true;
                Register objReg = new Register();
                objReg.MdiParent = this;
                objReg.Show();
            }
            else
            {
                toolStripStatusLStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonFine_Click(object sender, EventArgs e)
        {
            toolStripStatusLStatus.Text = "";            
            if (Program.UserAccessControl == false)
            {
                Program.UserAccessControl = true;
                textBoxRFID.Clear();
                Fine objF = new Fine();
                objF.MdiParent = this;
                objF.Show();
            }
            else
            {
                toolStripStatusLStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            toolStripStatusLStatus.Text = "";
            if (Program.UserAccessControl == false)
            {
                Program.UserAccessControl = true;
                SearchDatabase objSD = new SearchDatabase();
                objSD.MdiParent = this;
                objSD.Show();
            }
            else
            {
                toolStripStatusLStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            toolStripStatusLStatus.Text = "";
            count();
        }

        private void count()
        {           
            SqlParameter Count = new SqlParameter("@Count", SqlDbType.VarChar,10);
            Count.Direction = ParameterDirection.Output;
            command = new SqlCommand("select @Count = COUNT(*) FROM today", connection);
            command.Parameters.Add(Count);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                toolStripStatusLabelStatus.Text = Count.Value.ToString();
            }
            catch (Exception ex)
            {
                toolStripStatusLStatus.Text = "ERROR CONNECTING TO DATABASE";
            }
            finally
            {
                connection.Close();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs obj = new AboutUs();
            obj.MdiParent = this;
            obj.Show();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            toolStripStatusLStatus.Text = "";
            if (Program.UserAccessControl == false)
            {
                Program.UserAccessControl = true;
                ListParking objLP = new ListParking();
                objLP.MdiParent = this;
                objLP.Show();
            }
            else
            {
                toolStripStatusLStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }

        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            lock ("My_Lock")
            {
                if (RFID.Length > 10)
                {
                    Program.RFID = RFID;
                    textBoxRFID.Text = RFID;
                }
            }
        }

        private void comport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            lock ("My_Lock")
            {
                RFID = comport.ReadExisting();
                int len = RFID.Length;
                RFID = RFID.Substring(1, len - 1);
            }
        }     
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(Program.ConnectionString);
        SqlCommand command;

        private void Balance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.UserAccessControl = false;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            textBoxRFID.Text = Program.RFID;
            if (textBoxRFID.Text.Length > 0)
            {
                SqlParameter RFID = new SqlParameter("@RFID", SqlDbType.VarChar, 15);
                SqlParameter Balance = new SqlParameter("@Balance", SqlDbType.Money);
                SqlParameter LastUpdate = new SqlParameter("@LastUpdate", SqlDbType.DateTime);
                RFID.Direction = ParameterDirection.Input;
                Balance.Direction = ParameterDirection.Output;
                LastUpdate.Direction = ParameterDirection.Output;
                RFID.Value = textBoxRFID.Text.Trim();
                command = new SqlCommand("select @Balance = Balance, @LastUpdate = LastUpdate from account where RFID = @RFID", connection);
                command.Parameters.Add(RFID);
                command.Parameters.Add(Balance);
                command.Parameters.Add(LastUpdate);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    if (Balance.Value.ToString().Length > 0)
                    {
                        textBoxCurrentBalance.Text = Balance.Value.ToString();
                        textBoxLastRecharge.Text = LastUpdate.Value.ToString();
                        toolStripStatusLabelStatus.Text = "DONE";
                    }
                    else
                    {
                        toolStripStatusLabelStatus.Text = "INVALID RFID";
                        clean();
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabelStatus.Text = "ERROR CONNECTING TO DATABASE";
                    clean();
                }
                finally
                {
                    try
                    {
                        connection.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            else
            {
                toolStripStatusLabelStatus.Text = "RFID NOT FOUND";
                clean();
            }
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            textBoxRFID.Text = Program.RFID;
            buttonCheck_Click(this, new EventArgs());
        }

        private void clean()
        {
            textBoxRFID.Clear();
            textBoxCurrentBalance.Clear();
            textBoxLastRecharge.Clear();
        }
       
    }
}

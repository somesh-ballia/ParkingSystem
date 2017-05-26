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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        SqlCommand command1;
        
        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.UserAccessControl = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            textBoxRFID.Text = Program.RFID;            
            if (textBoxRFID.Text.Length > 0)
            {
                connection = new SqlConnection(Program.ConnectionString);
                SqlParameter RFID = new SqlParameter("@RFID", SqlDbType.VarChar, 15);
                SqlParameter Balance = new SqlParameter("@Balance", SqlDbType.Money);
                SqlParameter TimeStamp = new SqlParameter("@TimeStamp", SqlDbType.DateTime);
                RFID.Direction = ParameterDirection.Input;
                Balance.Direction = ParameterDirection.Output;
                TimeStamp.Direction = ParameterDirection.Output;
                RFID.Value = textBoxRFID.Text.Trim();
                command = new SqlCommand("select @Balance = Balance from account where RFID = @RFID", connection);
                command1 = new SqlCommand("select @TimeStamp = CONVERT(VARCHAR(20), GETDATE(), 100)", connection);
                command.Parameters.Add(RFID);
                command.Parameters.Add(Balance);
                command1.Parameters.Add(TimeStamp);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    command1.ExecuteNonQuery();
                    connection.Close();
                    if (Balance.Value.ToString().Length == 0)
                    {

                        command = new SqlCommand("insert into account values ('"+textBoxRFID.Text.Trim()+"',0.00 , '"+TimeStamp.Value+"')",connection);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            toolStripStatusLabelStatus.Text = "REGISTERED";                            
                        }
                        catch (Exception ex)
                        {
                           
                            toolStripStatusLabelStatus.Text = "SOMETHING WENT WRONG";
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
                        toolStripStatusLabelStatus.Text = "RFID ALREADY REGISTERED";
                        textBoxRFID.Clear();
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabelStatus.Text = "ERROR CONNECTING TO DATABASE";
                    textBoxRFID.Clear();
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
                toolStripStatusLabelStatus.Text = "NO RFID FOUND";
            }
        }
               
        private void Register_Load(object sender, EventArgs e)
        {
            textBoxRFID.Text = Program.RFID;
        }                       
    }
}

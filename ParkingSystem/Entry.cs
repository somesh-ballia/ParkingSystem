using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        SqlCommand command1;
        SqlCommand command2;
        SqlCommand command3;

        private void Entry_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.UserAccessControl = false;
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            textBoxRFID.Text = Program.RFID;
            toolStripStatusLabelStatus.Text = "";
            if (textBoxRFID.Text.Trim().Length > 0)
            {
                if (textBoxVNO.Text.Trim().Length > 0)
                {
                    connection = new SqlConnection(Program.ConnectionString);
                    SqlParameter RFID = new SqlParameter("@RFID", SqlDbType.VarChar, 15);
                    SqlParameter RFIDcheck = new SqlParameter("@RFIDcheck", SqlDbType.VarChar, 15);
                    SqlParameter Balance = new SqlParameter("@Balance", SqlDbType.Money);
                    SqlParameter TimeStamp = new SqlParameter("@TimeStamp", SqlDbType.DateTime);
                    SqlParameter InTime = new SqlParameter("@InTime",SqlDbType.DateTime);
                    SqlParameter CheckVehicle = new SqlParameter("@CheckVehicle", SqlDbType.VarChar, 20);
                    SqlParameter Notify = new SqlParameter("@Notify", SqlDbType.VarChar, 50);

                    TimeStamp.Direction = ParameterDirection.Output;
                    RFID.Direction = ParameterDirection.Input;
                    Balance.Direction = ParameterDirection.Output;
                    InTime.Direction = ParameterDirection.Output;
                    RFIDcheck.Direction = ParameterDirection.Input;
                    CheckVehicle.Direction = ParameterDirection.Input;
                    Notify.Direction = ParameterDirection.Output;

                    command = new SqlCommand("select @TimeStamp = CONVERT(VARCHAR(20), GETDATE(), 100)", connection);
                    command1 = new SqlCommand("select @Balance = Balance from account where RFID = @RFID", connection);
                    command2 = new SqlCommand("select @InTime = InTIme from today where RFID = @RFIDcheck", connection);
                    command3 = new SqlCommand("select @Notify = Notify from police where VNo = @CheckVehicle", connection);

                    RFID.Value = textBoxRFID.Text.Trim();
                    RFIDcheck.Value = textBoxRFID.Text.Trim();
                    CheckVehicle.Value = textBoxVNO.Text.Trim();
                    command.Parameters.Add(TimeStamp);
                    command1.Parameters.Add(RFID);
                    command1.Parameters.Add(Balance);
                    command2.Parameters.Add(InTime);
                    command2.Parameters.Add(RFIDcheck);
                    command3.Parameters.Add(CheckVehicle);
                    command3.Parameters.Add(Notify);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        command1.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        command3.ExecuteNonQuery();
                        connection.Close();

                        // Check Police missing list
                        if (Notify.Value.ToString().Length > 0)
                        {
                            MessageBox.Show("NOTIFY :" + Notify.Value.ToString(), "MISSING VEHICLE FOUND");
                        }
                        if (Balance.Value.ToString().Length > 0)
                        {
                            if (InTime.Value.ToString().Length == 0)
                            {
                                try
                                {
                                    command = new SqlCommand("insert into today values('" + textBoxRFID.Text.Trim() + "','" + Program.Location + "' ,'" + TimeStamp.Value + "', '" + comboBoxType.Text + "','" + textBoxVNO.Text.Trim() + "')", connection);
                                    connection.Open();
                                    command.ExecuteNonQuery();
                                    connection.Close();
                                    toolStripStatusLabelStatus.Text = "DONE";
                                    clean();
                                }
                                catch (Exception ex)
                                {
                                    toolStripStatusLabelStatus.Text = ex.Message;
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
                                toolStripStatusLabelStatus.Text = "RFID ALREADY IN USE";
                                clean();
                            }
                        }
                        else
                        {
                            toolStripStatusLabelStatus.Text = "INVALID RFID";
                            clean();
                        }

                    }
                    catch (Exception ex)
                    {
                        toolStripStatusLabelStatus.Text = ex.Message;
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
                    toolStripStatusLabelStatus.Text = "VEHICLE NUMBER NOT FOUND";
                    clean();
                }
            }
            else
            {
                toolStripStatusLabelStatus.Text = "RFID NOT FOUND";
                clean();
            }
        }

        private void Entry_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            textBoxRFID.Text = Program.RFID;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (comboBoxType.SelectedIndex == 2)
            {
                Random rnd = new Random();
                int num = rnd.Next(23090, 999999);
                textBoxVNO.Text = num.ToString();
            }
            else
            {
                textBoxVNO.Clear();
            }
        }

        private void clean()
        {
            textBoxRFID.Clear();
            textBoxVNO.Clear();
        }

        private void buttonFetch_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            textBoxRFID.Text = Program.RFID;
        }
    }
}

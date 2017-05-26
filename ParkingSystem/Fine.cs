using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class Fine : Form
    {
        public Fine()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(Program.ConnectionString);
        SqlCommand command;
        SqlCommand command1;
        bool Flag = false;

        private void Fine_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.UserAccessControl = false;
        }

        private void Fine_Load(object sender, EventArgs e)
        {

        }

        private void buttonPay_Click(object sender, EventArgs e)
        {            
            if (textBoxVNo.Text.Trim().Length > 0)
            {
                if (textBoxAmount.Text.Trim().Length > 0)
                {
                    try
                    {
                        double pay = Convert.ToDouble(textBoxAmount.Text.Trim());
                        SqlParameter RFID = new SqlParameter("@RFID", SqlDbType.VarChar, 20);
                        SqlParameter VNo = new SqlParameter("@VNo", SqlDbType.VarChar,20);
                        SqlParameter TimeStamp = new SqlParameter("@TimeStamp", SqlDbType.DateTime);
                        RFID.Direction = ParameterDirection.Output;
                        VNo.Direction = ParameterDirection.Input;
                        TimeStamp.Direction = ParameterDirection.Output;
                        VNo.Value = textBoxVNo.Text.Trim();
                        command = new SqlCommand("select @RFID = RFID from today where VNo = @VNo", connection);
                        command1 = new SqlCommand("select @TimeStamp = CONVERT(VARCHAR(20), GETDATE(), 100)", connection);
                        command.Parameters.Add(RFID);
                        command.Parameters.Add(VNo);
                        command1.Parameters.Add(TimeStamp);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            command1.ExecuteNonQuery();
                            connection.Close();
                            if (RFID.Value.ToString().Length > 0)
                            {
                                textBoxRFID.Text = RFID.Value.ToString();
                                command = new SqlCommand("insert into fine values('"+pay+"','"+RFID.Value.ToString()+"','"+textBoxVNo.Text.Trim()+"','"+TimeStamp.Value.ToString()+"','"+Program.Location+"') ", connection);
                                try
                                {
                                    connection.Open();
                                    command.ExecuteNonQuery();
                                    connection.Close();
                                    Exit.fine = true;
                                    Exit.RFID = textBoxRFID.Text;
                                    Exit obj = new Exit();
                                    obj.Show();
                                    Flag = true;
                                    toolStripStatusLabelStatus.Text = "DONE";
                                    textBoxVNo.Clear();
                                }
                                catch (Exception ex)
                                {
                                    toolStripStatusLabelStatus.Text = "SOMETHING WENT WRONG";
                                    clear();
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
                                clear();                        
                            }
                        }
                        catch (Exception ex)
                        {
                            toolStripStatusLabelStatus.Text = "ERROR CONNECTING TO DATABASE";
                            clear();
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
                    catch (Exception ex)
                    {
                        toolStripStatusLabelStatus.Text = "INVALID AMOUNT";
                        textBoxAmount.Clear();
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
                    toolStripStatusLabelStatus.Text = "AMOUNT NOT FOUND";                    
                }
            }
            else
            {
                toolStripStatusLabelStatus.Text = "VEHICLE NUMBER NOT FOUND";
                clear();
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxVNo_Enter(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            textBoxVNo.Clear();
            textBoxRFID.Clear();
            textBoxAmount.Clear();
        }

        private void textBoxAmount_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        
       
    }
}

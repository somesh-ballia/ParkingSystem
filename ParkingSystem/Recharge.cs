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
    public partial class Recharge : Form
    {
        public Recharge()
        {
            InitializeComponent();
        }

        bool Flag = false;
        SqlConnection connection = new SqlConnection(Program.ConnectionString);
        SqlCommand command;
        SqlCommand command1;
                       
        private void Recharge_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.UserAccessControl = false;
        }

        private void buttonFetch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxRFID.Text.Trim().Length == 0 && Program.RFID.Length > 0)
                {
                    textBoxRFID.Text = Program.RFID;
                }                

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
                            Flag = true;
                        }
                        else
                        {
                            toolStripStatusLabelStatus.Text = "INVALID RFID";
                            clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        toolStripStatusLabelStatus.Text = ex.Message;
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
                    toolStripStatusLabelStatus.Text = "RFID NOT FOUND";
                    clear();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabelStatus.Text = "OOPS! SOMETHING WENT WRONG";
            }

        }

        private void buttonRecharge_Click(object sender, EventArgs e)
        {
                if (textBoxRFID.Text.Length > 0)
                {
                    if (Flag)
                    {
                        connection = new SqlConnection(Program.ConnectionString);
                        SqlParameter TimeStamp = new SqlParameter("@TimeStamp", SqlDbType.DateTime);
                        SqlParameter Discount = new SqlParameter("@Discount", SqlDbType.Float);
                        SqlParameter Location = new SqlParameter("@Location", SqlDbType.VarChar, 20);
                        Location.Direction = ParameterDirection.Input;
                        Discount.Direction = ParameterDirection.Output;
                        TimeStamp.Direction = ParameterDirection.Output;
                        Location.Value = Program.Location;
                        command = new SqlCommand("select @TimeStamp = CONVERT(VARCHAR(20), GETDATE(), 100)", connection);
                        command1 = new SqlCommand("select @Discount = Discount from configuration where Location = @Location", connection);
                        command1.Parameters.Add(Location);
                        command1.Parameters.Add(Discount);
                        command.Parameters.Add(TimeStamp);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            command1.ExecuteNonQuery();
                            connection.Close();
                            if (Discount.Value.ToString().Length > 0)
                            {
                                try
                                {
                                    double discountPercent = Convert.ToDouble(Discount.Value.ToString());
                                    double currentBalance = Convert.ToDouble(textBoxCurrentBalance.Text.Trim());
                                    double rechargeAmount = Convert.ToDouble(textBoxRechargeAmmount.Text.Trim());
                                    double updateBalance = rechargeAmount + ((rechargeAmount) * (discountPercent / 100));
                                    double newBalance = currentBalance + updateBalance;

                                    // Creating transaction 
                                    try
                                    {
                                        SqlConnection conn = new SqlConnection(Program.ConnectionString);
                                        conn.Open();
                                        SqlCommand cmd = conn.CreateCommand();
                                        SqlTransaction transaction;
                                        transaction = conn.BeginTransaction("Recharge");
                                        cmd.Connection = conn;
                                        cmd.Transaction = transaction;
                                        try
                                        {
                                            cmd.CommandText = "update account SET Balance = '" + newBalance + "' , LastUpdate = '" + TimeStamp.Value + "'  where RFID = '" + textBoxRFID.Text.Trim() + "'";
                                            cmd.ExecuteNonQuery();
                                            if (rechargeAmount > 0)
                                            {
                                                cmd.CommandText = "insert into recharge values('" + rechargeAmount + "','" + textBoxRFID.Text.Trim() + "' ,'" + Program.Location + "' ,'" + TimeStamp.Value + "')";
                                                cmd.ExecuteNonQuery();
                                            }
                                            transaction.Commit();
                                            toolStripStatusLabelStatus.Text = "Done";
                                            buttonFetch_Click(this, new EventArgs());
                                            Flag = false;
                                        }
                                        catch (Exception ex)
                                        {
                                            toolStripStatusLabelStatus.Text = ex.Message;
                                            try
                                            {
                                                transaction.Rollback();
                                                clear();
                                            }
                                            catch (Exception ex1)
                                            {
                                                toolStripStatusLabelStatus.Text = ex1.Message;
                                            }
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
                                catch
                                {
                                    toolStripStatusLabelStatus.Text = "UNKNOWN AMOUNT";
                                    textBoxRechargeAmmount.Clear();
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
                                toolStripStatusLabelStatus.Text = "ERROR CONNECTING TO DATABASE";
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

                        textBoxRechargeAmmount.Clear();
                    }
                    else
                    {
                        buttonFetch_Click(this, new EventArgs());

                    }
                }
                else
                {
                    toolStripStatusLabelStatus.Text = "RFID NOT FOUND";
                    clear();
                }            
        }

        private void textBoxRFID_TextChanged(object sender, EventArgs e)
        {
           toolStripStatusLabelStatus.Text = "";
           
        }

        private void clear()
        {
            textBoxCurrentBalance.Clear();
            textBoxLastRecharge.Clear();
            textBoxRechargeAmmount.Clear();
        }

        private void Recharge_Load(object sender, EventArgs e)
        {
            textBoxRFID.Text = Program.RFID;
        }
               
    }
}

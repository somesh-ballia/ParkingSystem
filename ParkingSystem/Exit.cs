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
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
        }

        bool Flag = false;
        public static bool fine = false;
        public  static string RFID = "";

        private void Exit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fine == false)
            {
                Program.UserAccessControl = false;
            }
            else
            {
                fine = false;
            }
        }

        private void Exit_Load(object sender, EventArgs e)
        {
            comboBoxMode.SelectedIndex = 0;
            if (fine)
            {
                textBoxRFID.Text = RFID;
            }
            else
            {
                textBoxRFID.Text = Program.RFID;
            }
        }

        private void buttonFetch_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (fine)
            {
                textBoxRFID.Text = RFID;
            }
            else
            {
                textBoxRFID.Text = Program.RFID;
            }

            SqlConnection connection = new SqlConnection(Program.ConnectionString);
            SqlCommand command;
            SqlCommand command1;
            SqlCommand command2;
            subClean();

           if (textBoxRFID.Text.Length > 0)
            {
                SqlParameter RFID = new SqlParameter("@RFID", SqlDbType.VarChar, 20);
                SqlParameter RFIDnew = new SqlParameter("@RFIDnew", SqlDbType.VarChar, 20);
                SqlParameter Balance = new SqlParameter("@Balance", SqlDbType.Money);
                SqlParameter OutTime = new SqlParameter("@OutTime", SqlDbType.DateTime);
                SqlParameter InTime = new SqlParameter("@InTIme",SqlDbType.DateTime);
                SqlParameter Location = new SqlParameter("@Location", SqlDbType.VarChar, 20);
                SqlParameter VType = new SqlParameter("@VType", SqlDbType.VarChar, 10);
                SqlParameter VNo = new SqlParameter("@VNo", SqlDbType.VarChar, 20);
                SqlParameter RateLocation = new SqlParameter("@RateLocation", SqlDbType.VarChar, 20);
                SqlParameter RateType = new SqlParameter("@RateType", SqlDbType.VarChar, 10);
                SqlParameter Fixed = new SqlParameter("@Fixed", SqlDbType.Money);
                SqlParameter Variable = new SqlParameter("@Variable", SqlDbType.Money);
                SqlParameter Constant = new SqlParameter("@Constant", SqlDbType.Money);

                RFID.Direction = ParameterDirection.Input;
                RFIDnew.Direction = ParameterDirection.Input;
                Balance.Direction = ParameterDirection.Output;
                OutTime.Direction = ParameterDirection.Output;
                InTime.Direction = ParameterDirection.Output;
                Location.Direction = ParameterDirection.Output;
                VType.Direction = ParameterDirection.Output;
                VNo.Direction = ParameterDirection.Output;
                RateLocation.Direction = ParameterDirection.Input;
                RateType.Direction = ParameterDirection.Input;
                Fixed.Direction = ParameterDirection.Output;
                Variable.Direction = ParameterDirection.Output;
                Constant.Direction = ParameterDirection.Output;

                RFID.Value = textBoxRFID.Text.Trim();
                RFIDnew.Value = textBoxRFID.Text.Trim();
                command = new SqlCommand("select @Balance = Balance from account where RFID = @RFID", connection);
                command1 = new SqlCommand("select @OutTime = CONVERT(VARCHAR(20), GETDATE(), 100)", connection);
                command2 = new SqlCommand("select @Location = Location , @InTime = InTIme, @VType = VType , @VNo = VNo from today where RFID = @RFIDnew", connection);
                command.Parameters.Add(RFID);
                command.Parameters.Add(Balance);
                command1.Parameters.Add(OutTime);
                command2.Parameters.Add(InTime);
                command2.Parameters.Add(Location);
                command2.Parameters.Add(VType);
                command2.Parameters.Add(VNo);
                command2.Parameters.Add(RFIDnew);    
                            
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    connection.Close();
                    if (Balance.Value.ToString().Length > 0 && OutTime.Value.ToString().Length >0 )
                    {
                        if (Location.Value.ToString().Length > 0)
                        {
                            textBoxVNO.Text = VNo.Value.ToString();
                            textBoxType.Text = VType.Value.ToString();
                            textBoxEntry.Text = InTime.Value.ToString();
                            textBoxExit.Text = OutTime.Value.ToString();
                            textBoxCurrentBalance.Text = Balance.Value.ToString();

                            // Findling duration
                            SqlParameter Duration = new SqlParameter("@Duration", SqlDbType.Int);
                            Duration.Direction = ParameterDirection.Output;
                            command = new SqlCommand("select @Duration = DATEDIFF(hour,'" + InTime.Value + "', '" + OutTime.Value + "')", connection);
                            command.Parameters.Add(Duration);
                            command1 = new SqlCommand("select @Fixed = Fixed , @Variable = Variable, @Constant = Constant from rate where Location = @RateLocation and Type = @RateType", connection);
                            RateLocation.Value = Location.Value;
                            RateType.Value = VType.Value;
                            command1.Parameters.Add(Fixed);
                            command1.Parameters.Add(Variable);
                            command1.Parameters.Add(RateLocation);
                            command1.Parameters.Add(RateType);
                            command1.Parameters.Add(Constant);

                            try
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                command1.ExecuteNonQuery();
                                connection.Close();
                                if (Duration.Value.ToString().Length > 0 && Fixed.Value.ToString().Length > 0)
                                {
                                    // Compute Charge
                                    textBoxDuration.Text = (Convert.ToDouble(Duration.Value) + 1).ToString();
                                    switch (Program.PaymentMode)
                                    {
                                        case "STATIC":
                                            double pay = Convert.ToDouble(Fixed.Value.ToString()) + (Convert.ToDouble(Variable.Value.ToString()) * (Convert.ToDouble(Duration.Value.ToString())));
                                            double rest = Convert.ToDouble(textBoxCurrentBalance.Text.Trim()) - pay;
                                            textBoxPay.Text = pay.ToString();
                                            if (comboBoxMode.Text == "CARD" && rest > 0)
                                            {
                                                textBoxLeft.Text = rest.ToString();
                                            }
                                            Flag = true;
                                            break;
                                        case "DYNAMIC":
                                            double payConstant = (Convert.ToDouble(Constant.Value.ToString()) * ((int)(Convert.ToInt32(Duration.Value.ToString()) / 24) + 1));
                                            textBoxPay.Text = payConstant.ToString();
                                            double rest1 = Convert.ToDouble(textBoxCurrentBalance.Text.Trim()) - payConstant;
                                            if (comboBoxMode.Text == "CARD" && rest1 > 0)
                                            {
                                                textBoxLeft.Text = rest1.ToString();
                                            }
                                            Flag = true;
                                            break;
                                    }
                                }
                                else
                                {
                                    toolStripStatusLabelStatus.Text = "ERROR CONNECTING TO DATABASE";
                                    clean();
                                }
                            }
                            catch (Exception ex)
                            {
                                toolStripStatusLabelStatus.Text = ex.Message;
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
                            toolStripStatusLabelStatus.Text = "VEHICLE NOT PARKED";
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
                toolStripStatusLabelStatus.Text ="RFID NOT FOUND";
                clean();
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (Flag)
            {
                SqlConnection connection = new SqlConnection(Program.ConnectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("Card_Payment");
                command.Connection = connection;
                command.Transaction = transaction;
                
                switch (comboBoxMode.Text)
                {
                    case "CARD":
                        try
                        {
                            double pay = Convert.ToDouble(textBoxPay.Text);
                            double balance = Convert.ToDouble(textBoxCurrentBalance.Text);
                            double rest = balance-pay;
                            if (rest > 0)
                            {
                                command.CommandText = "insert into old values('" + textBoxRFID.Text.Trim() + "','" + Program.Location + "','" + textBoxEntry.Text.Trim() + "','" + textBoxExit.Text.Trim() + "','" + textBoxType.Text.Trim() + "','" + textBoxVNO.Text.Trim() + "')";
                                command.ExecuteNonQuery();
                                command.CommandText = "delete from today where RFID = '"+textBoxRFID.Text.Trim()+"' ";  
                                command.ExecuteNonQuery();
                                command.CommandText = "update account set Balance = '"+rest+"' where RFID = '" + textBoxRFID.Text.Trim() + "' ";
                                command.ExecuteNonQuery();
                                transaction.Commit();
                                Flag = false;
                                toolStripStatusLabelStatus.Text = "DONE";
                                if (fine)
                                {
                                    fine = false;
                                    this.Close();
                                }
                                textBoxRFID.Clear();
                            }
                            else
                            {
                                toolStripStatusLabelStatus.Text ="LOW ACCOUNT BALANCE";
                            }
                        }
                        catch (Exception ex)
                        {
                            try
                            {
                                transaction.Rollback();
                                toolStripStatusLabelStatus.Text = "SOMETHING WENT WRONG";
                                clean();

                            }
                            catch (Exception ex1)
                            {
                                toolStripStatusLabelStatus.Text = ex1.Message;
                                clean();
                            }
                            
                        }
                        break;

                    case "CASH":
                        try
                        {
                            double pay = Convert.ToDouble(textBoxPay.Text);
                            command.CommandText = "insert into old values('" + textBoxRFID.Text.Trim() + "','" + Program.Location + "','" + textBoxEntry.Text.Trim() + "','" + textBoxExit.Text.Trim() + "','" + textBoxType.Text.Trim() + "','" + textBoxVNO.Text.Trim() + "')";
                            command.ExecuteNonQuery();
                            command.CommandText = "delete from today where RFID = '" + textBoxRFID.Text.Trim() + "' ";
                            command.ExecuteNonQuery();
                            command.CommandText = "insert into cash values('" + pay + "','" + textBoxRFID.Text.Trim() + "','" + Program.Location + "','" + textBoxExit.Text.Trim() + "','" + textBoxType.Text.Trim() + "')";
                            command.ExecuteNonQuery();
                            transaction.Commit();
                            Flag = false;
                            toolStripStatusLabelStatus.Text = "DONE";
                            textBoxRFID.Clear();
                        }
                        catch(Exception ex)
                        {                           
                            try
                            {
                                transaction.Rollback();
                                toolStripStatusLabelStatus.Text = "SOMETHING WENT WRONG";
                                clean();

                            }
                            catch (Exception ex1)
                            {
                                toolStripStatusLabelStatus.Text = ex1.Message;
                                clean();
                            }                            
                        }
                        break;
                }
            }
            else
            {
                buttonFetch_Click(this, new EventArgs());
                if (textBoxExit.Text.Trim().Length > 0)
                {
                    buttonPay_Click(this,new EventArgs());
                }                    
            }
        }

        private void textBoxType_TextChanged(object sender, EventArgs e)
        {

        }

        private void clean()
        {
            textBoxRFID.Clear();
            textBoxEntry.Clear();
            textBoxExit.Clear();
            textBoxCurrentBalance.Clear();
            textBoxDuration.Clear();
            textBoxVNO.Clear();
            textBoxType.Clear();
            textBoxPay.Clear();
            textBoxLeft.Clear();
        }

        private void subClean()
        {            
            textBoxEntry.Clear();
            textBoxExit.Clear();
            textBoxCurrentBalance.Clear();
            textBoxDuration.Clear();
            textBoxVNO.Clear();
            textBoxType.Clear();
            textBoxPay.Clear();
            textBoxLeft.Clear();
        }

        private void textBoxRFID_Enter(object sender, EventArgs e)
        {
            
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";            
        }

               
    }
}

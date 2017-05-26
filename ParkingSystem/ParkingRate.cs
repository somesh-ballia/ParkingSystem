using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class ParkingRate : Form
    {
        public ParkingRate()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(Program.ConnectionString);
        SqlCommand command;

        private void ParkingRate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.AdminAccessControl = false;
        }

        private void ParkingRate_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
           
            SqlParameter Location = new SqlParameter("@Location", SqlDbType.VarChar, 20);
            SqlParameter Type = new SqlParameter("@Type", SqlDbType.VarChar, 10);            
            SqlParameter Fixed = new SqlParameter("@Fixed", SqlDbType.Money);
            SqlParameter Variable = new SqlParameter("@Variable", SqlDbType.Money);
            SqlParameter Constant = new SqlParameter("@Constant", SqlDbType.Money);

            Location.Direction = ParameterDirection.Input;
            Type.Direction = ParameterDirection.Input;
            Fixed.Direction = ParameterDirection.Output;
            Variable.Direction = ParameterDirection.Output;
            Constant.Direction = ParameterDirection.Output;

            Location.Value = Program.Location;
            Type.Value = comboBoxVType.Text;

            command = new SqlCommand("select @Fixed = Fixed, @Variable = Variable , @Constant = Constant from rate where Location = @Location and Type = @Type ", connection);
            command.Parameters.Add(Location);
            command.Parameters.Add(Type);
            command.Parameters.Add(Fixed);
            command.Parameters.Add(Variable);
            command.Parameters.Add(Constant);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                if (Fixed.Value.ToString().Length > 0)
                {
                    textBoxLocation.Text = Program.Location;
                    textBoxFixed.Text = Fixed.Value.ToString();
                    textBoxVariable.Text = Variable.Value.ToString();
                    textBoxConstant.Text = Constant.Value.ToString();
                    toolStripStatusLabelStatus.Text = "DONE";
                }
                else
                {
                    toolStripStatusLabelStatus.Text = "SOMETHING WENT WRONG";
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

        private void clear()
        {
            textBoxFixed.Clear();
            textBoxVariable.Clear();
            textBoxConstant.Clear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxFixed.Text.Trim().Length > 0)
            {
                if (textBoxVariable.Text.Trim().Length > 0)
                {
                    if (textBoxConstant.Text.Trim().Length > 0)
                    {
                        try
                        {
                            double Fixed = Convert.ToDouble(textBoxFixed.Text.Trim());
                            double Variable = Convert.ToDouble(textBoxVariable.Text.Trim());
                            double Constant = Convert.ToDouble(textBoxConstant.Text.Trim());
                            try
                            {
                                command = new SqlCommand("UPDATE rate set Fixed = '" + Fixed + "', Variable = '" + Variable + "' , Constant = '" + Constant + "'  where Location = '" + Program.Location + "' and Type = '"+comboBoxVType.Text+"' ", connection);
                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                                toolStripStatusLabelStatus.Text = "DONE";
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
                        catch (Exception ex)
                        {
                            toolStripStatusLabelStatus.Text = "INVALID DATA";
                        }
                    }
                    else
                    {
                        toolStripStatusLabelStatus.Text = "PAY PER EXIT RATE NOT FOUND";
                    }
                }
                else
                {
                    toolStripStatusLabelStatus.Text = "PAY PER HOUR RATE NOT FOUND";
                }
            }
            else
            {
                toolStripStatusLabelStatus.Text = "FIRST HOUR RATE NOT FOUND";
            }
        }

        private void comboBoxVType_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
        }
    }
}

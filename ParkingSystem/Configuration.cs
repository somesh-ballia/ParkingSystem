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
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(Program.ConnectionString);
        SqlCommand command;

        private void Configuration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.AdminAccessControl = false;
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            SqlParameter ProductID = new SqlParameter("@ProductID", SqlDbType.VarChar, 10);
            SqlParameter Location = new SqlParameter("@Location", SqlDbType.VarChar, 20);
            SqlParameter PaymentMode = new SqlParameter("@PaymentMode", SqlDbType.VarChar, 10);
            SqlParameter Discount = new SqlParameter("@Discount", SqlDbType.Float);

            ProductID.Direction = ParameterDirection.Input;
            Location.Direction = ParameterDirection.Output;
            PaymentMode.Direction = ParameterDirection.Output;
            Discount.Direction = ParameterDirection.Output;

            ProductID.Value = Program.ProductID;
            command = new SqlCommand("select @Location = Location, @PaymentMode = PaymentMode , @Discount = Discount from configuration where ProductID = @ProductID", connection);
            command.Parameters.Add(ProductID);
            command.Parameters.Add(Location);
            command.Parameters.Add(PaymentMode);
            command.Parameters.Add(Discount);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                if (Location.Value.ToString().Length > 0)
                {
                    textBoxProductID.Text = Program.ProductID;
                    textBoxLocation.Text = Location.Value.ToString();
                    comboBoxMode.Text = PaymentMode.Value.ToString();
                    textBoxDiscount.Text = Discount.Value.ToString();
                    toolStripStatusLabelStatus.Text = "DONE";
                }
                else
                {
                    toolStripStatusLabelStatus.Text = "SOMETHING WENT WRONG";                    
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabelStatus.Text = "ERROR CONNECTING TO DATABASE";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxDiscount.Text.Trim().Length > 0)
            {
                try
                {
                    double discount = Convert.ToDouble(textBoxDiscount.Text.Trim());
                    try
                    {
                        command = new SqlCommand("UPDATE configuration set PaymentMode = '" + comboBoxMode.Text + "', Discount= '" + textBoxDiscount.Text.Trim() + "' where ProductID = '" + Program.ProductID + "'", connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        toolStripStatusLabelStatus.Text = "DONE";
                    }
                    catch (Exception ex)
                    {
                        toolStripStatusLabelStatus.Text = "SOMETHING WENT WRONG";
                        textBoxLocation.Clear();
                        textBoxDiscount.Clear();
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
                    toolStripStatusLabelStatus.Text = "INVALID DISCOUNT";
                    textBoxDiscount.Clear();
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
                toolStripStatusLabelStatus.Text = "DISCOUNT NOT FOUND";
            }
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
        }

        private void textBoxDiscount_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
        }
    }
}

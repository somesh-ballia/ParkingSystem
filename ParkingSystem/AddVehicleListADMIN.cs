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
    public partial class AddVehicleListADMIN : Form
    {
        public AddVehicleListADMIN()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;  

        private void AddVehicleListADMIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.AdminAccessControl = false;
        }

        private void clean()
        {
            textBoxVNo.Clear();
            textBoxContact.Clear();
        }

        private void buttonSumit_Click(object sender, EventArgs e)
        {
            if (textBoxVNo.Text.Trim().Length > 0)
            {
                if (textBoxContact.Text.Trim().Length > 0)
                {
                    connection = new SqlConnection(Program.ConnectionString);
                    SqlParameter VNo = new SqlParameter("@Vno", SqlDbType.VarChar, 20);
                    SqlParameter Notify = new SqlParameter("@Notify", SqlDbType.VarChar, 50);
                    VNo.Direction = ParameterDirection.Input;
                    Notify.Direction = ParameterDirection.Output;
                    VNo.Value = textBoxVNo.Text.Trim();
                    command = new SqlCommand("select @Notify = Notify from police where VNo = @VNo", connection);
                    command.Parameters.Add(VNo);
                    command.Parameters.Add(Notify);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        if (Notify.Value.ToString().Length == 0)
                        {

                            command = new SqlCommand("insert into police values ('" + textBoxVNo.Text.Trim() + "','" + textBoxContact.Text.Trim() + "')", connection);
                            try
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                                toolStripStatusLabelStatus.Text = "DONE";
                                clean();
                            }
                            catch (Exception ex)
                            {
                                toolStripStatusLabelStatus.Text = "SOMETHING WENT WRONG";
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
                            toolStripStatusLabelStatus.Text = "REDUNDANT ENTRY";
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
                    toolStripStatusLabelStatus.Text = "CONTACT DETAILS NOT FOUND";
                }
            }
            else
            {
                toolStripStatusLabelStatus.Text = "VEHICLE NUMBER NOT FOUND";
                textBoxContact.Clear();
            }
        }

        private void AddVehicleListADMIN_Load(object sender, EventArgs e)
        {

        }

        private void textBoxContact_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            textBoxVNo.Clear();
        }

    }
}

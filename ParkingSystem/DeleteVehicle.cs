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
    public partial class DeleteVehicle : Form
    {
        public DeleteVehicle()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command; 

        private void DeleteVehicle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.AdminAccessControl = false;
        }

        private void DeleteVehicle_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxVNo.Text.Trim().Length > 0)
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
                        if (Notify.Value.ToString().Length > 0)
                        {
                            command = new SqlCommand("delete from police where VNo = '"+textBoxVNo.Text.Trim()+"' ", connection);
                            try
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                                toolStripStatusLabelStatus.Text = "DONE";
                                textBoxVNo.Clear();                               
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
                            toolStripStatusLabelStatus.Text = "RECORD NOT FOUND";
                            textBoxVNo.Clear();                            
                        }
                    }
                    catch (Exception ex)
                    {
                        toolStripStatusLabelStatus.Text = "ERROR CONNECTING TO DATABASE";
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
            }
        }

        private void textBoxVNo_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
        }
    }
}

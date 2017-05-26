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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;      

        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.AdminAccessControl = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Trim().Length > 0)
            {
                if (textBoxPassword.Text.Trim().Length > 0 && textBoxConfirm.Text.Trim().Length > 0)
                {
                    if (textBoxPassword.Text.Trim() == textBoxConfirm.Text.Trim())
                    {
                        string Type = comboBoxType.Text;
                        connection = new SqlConnection(Program.ConnectionString);
                        SqlParameter user = new SqlParameter("@user", SqlDbType.VarChar, 50);
                        SqlParameter type = new SqlParameter("@type", SqlDbType.VarChar, 50);
                        user.Direction = ParameterDirection.Input;
                        type.Direction = ParameterDirection.Output;
                        user.Value = textBoxUserName.Text.Trim();
                        command = new SqlCommand("select @type = Type from login where UserName=@user", connection);
                        command.Parameters.Add(user);
                        command.Parameters.Add(type);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            if (type.Value.ToString().Length == 0)
                            {
                                try
                                {
                                    command = new SqlCommand("insert into login values ('" + textBoxUserName.Text.Trim() + "','" + textBoxPassword.Text.Trim() + "','" + comboBoxType.Text+ "')", connection);
                                    connection.Open();
                                    command.ExecuteNonQuery();
                                    connection.Close();
                                    toolStripStatusLabelStatus.Text = "DONE";
                                    clear();
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
                                toolStripStatusLabelStatus.Text = "USER NAME NOT AVAILABLE";
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
                    else
                    {
                        toolStripStatusLabelStatus.Text = "PASSWORD MISMATCH";
                        textBoxPassword.Clear();
                        textBoxConfirm.Clear();
                    }
                }
                else
                {
                    toolStripStatusLabelStatus.Text = "NO PASSWORD FOUND";
                    textBoxConfirm.Clear();
                    textBoxPassword.Clear();
                }
            }
            else
            {
                toolStripStatusLabelStatus.Text = "NO USER NAME FOUND";
            }

        }

        private void clear()
        {
            textBoxUserName.Clear();
            textBoxPassword.Clear();
            textBoxConfirm.Clear();            
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
        }
               
    }
}

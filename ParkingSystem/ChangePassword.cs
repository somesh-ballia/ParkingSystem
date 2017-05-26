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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;

        private void ChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.AdminAccessControl = false;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Trim().Length > 0)
            {
                if (textBoxOldPassword.Text.Trim().Length > 0 && textBoxPassword.Text.Trim().Length > 0 && textBoxConfirm.Text.Trim().Length > 0)
                {
                    if (textBoxPassword.Text.Trim() == textBoxConfirm.Text.Trim())
                    {
                        connection = new SqlConnection(Program.ConnectionString);
                        SqlParameter user = new SqlParameter("@user", SqlDbType.VarChar, 50);
                        SqlParameter password = new SqlParameter("@password", SqlDbType.VarChar, 50);
                        user.Direction = ParameterDirection.Input;
                        password.Direction = ParameterDirection.Output;
                        user.Value = textBoxUserName.Text.Trim();
                        command = new SqlCommand("select @password = password from login where UserName = @user", connection);
                        command.Parameters.Add(user);
                        command.Parameters.Add(password);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            if (password.Value.ToString().Length > 0)
                            {
                                if (password.Value.ToString() == textBoxOldPassword.Text.Trim())
                                {
                                    try
                                    {
                                        command = new SqlCommand("update login set Password = '" + textBoxConfirm.Text.Trim() + "' where UserName = '" + textBoxUserName.Text.Trim() + "' ", connection);
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
                                     toolStripStatusLabelStatus.Text = "WRONG PASSWORD";
                                     textBoxPassword.Clear();
                                     textBoxOldPassword.Clear();
                                     textBoxConfirm.Clear();
                                }
                            }
                            else
                            {
                                toolStripStatusLabelStatus.Text = "INVALID USER NAME"; 
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
                        textBoxOldPassword.Clear();
                        textBoxPassword.Clear();
                        textBoxConfirm.Clear();
                    }
                }
                else
                {
                    toolStripStatusLabelStatus.Text = "PASSWORD NOT FOUND";
                    textBoxPassword.Clear();
                    textBoxOldPassword.Clear();
                    textBoxConfirm.Clear();
                }
            }
            else
            {
                toolStripStatusLabelStatus.Text = "USER NAME NOT FOUND";
                clear();
            }
        }

        private void clear()
        {
            textBoxUserName.Clear();
            textBoxOldPassword.Clear();
            textBoxPassword.Clear();
            textBoxConfirm.Clear();
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
        }
    }
}

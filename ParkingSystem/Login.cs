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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string Type = "ERROR!!!";
        SqlConnection connection;
        SqlCommand command;
        SqlCommand command1;
        string ConnString = Program.ConnectionString;

        private void clean()
        {
            textBoxPassword.Clear();
            textBoxUserName.Clear();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Program.AccessControl == false)
            {
                if (textBoxUserName.Text.Trim().Length > 0)
                    {
                        if (textBoxPassword.Text.Trim().Length > 0)
                        {
                            Type = authenticateUser(ConnString, textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim());
                            Program.UserName = textBoxUserName.Text.Trim();
                            switch (Type.ToLower())
                            {
                                case "user": CheckRFID objCheck = new CheckRFID();                                   
                                    Program.AccessControl = true;
                                    clean();                                    
                                    objCheck.Show();
                                    break;
                                case "admin": ADMIN objA = new ADMIN();
                                    Program.AccessControl = true;
                                    clean();
                                    objA.Show();
                                    break;
                                case "super": SUPER objS = new SUPER();
                                    Program.AccessControl = true;
                                    clean();
                                    objS.Show();
                                    break;
                                default: toolStripStatusLabelStatus.Text = "INVALID USER NAME OR PASSWORD";
                                    clean();
                                    break;
                            }
                        }
                        else
                        {
                            toolStripStatusLabelStatus.Text = "NO PASSWORD FOUND";
                            textBoxUserName.Clear();                            
                        }
                    }
                    else
                    {
                        toolStripStatusLabelStatus.Text = "NO USER NAME FOUND";
                        textBoxPassword.Clear();
                    }                                  
            }
            else
            {
                toolStripStatusLabelStatus.Text = "ALREADY LOGGED IN";
                clean();
            }
        }

        private string authenticateUser(string connectionString, string UserName, String Password)
        {
            connection = new SqlConnection(connectionString);
            SqlParameter user = new SqlParameter("@user", SqlDbType.VarChar, 50);
            SqlParameter pass = new SqlParameter("@pass", SqlDbType.VarChar, 50);
            SqlParameter type = new SqlParameter("@type", SqlDbType.VarChar, 50);
            SqlParameter Location = new SqlParameter("@Location", SqlDbType.VarChar, 20);
            SqlParameter ProductID = new SqlParameter("@ProductID", SqlDbType.VarChar, 10);
            user.Direction = ParameterDirection.Input;
            pass.Direction = ParameterDirection.Input;
            type.Direction = ParameterDirection.Output;
            ProductID.Direction = ParameterDirection.Input;
            Location.Direction = ParameterDirection.Output;
            ProductID.Value = Program.ProductID;
            user.Value = UserName;
            pass.Value = Password;
            command = new SqlCommand("select @type = Type from login where UserName=@user and Password=@pass", connection);
            command1 = new SqlCommand("select @Location = Location from configuration where ProductID = @ProductID", connection);
            command.Parameters.Add(user);
            command.Parameters.Add(pass);
            command.Parameters.Add(type);
            command1.Parameters.Add(Location);
            command1.Parameters.Add(ProductID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                connection.Close();
                if (type.Value.ToString().Length > 0)
                {
                    Type = type.Value.ToString();
                    Program.Location = Location.Value.ToString();
                }
                else
                {
                    Type = "ERROR!!!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connecting to Database");
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

            return Type;
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            textBoxUserName.Clear();
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            textBoxPassword.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

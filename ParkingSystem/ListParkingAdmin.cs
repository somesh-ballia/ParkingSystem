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
    public partial class ListParkingAdmin : Form
    {
        public ListParkingAdmin()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        private void ListParkingAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.AdminAccessControl = false;
        }

        private void ListParkingAdmin_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Program.ConnectionString);
            try
            {
                da = new SqlDataAdapter("select * from today where Location = '" + Program.Location + "' ", connection);
                da.Fill(ds, "police");
                dataGridView1.DataSource = ds.Tables["police"];
                toolStripStatusLabelStatus.Text = "DONE";
            }
            catch (Exception ex)
            {
                toolStripStatusLabelStatus.Text = "ERROR CONNECTING TO DATABASE";
            }
        }
    }
}

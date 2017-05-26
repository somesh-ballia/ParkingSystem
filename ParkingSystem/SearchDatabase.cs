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
    public partial class SearchDatabase : Form
    {
        public SearchDatabase()
        {
            InitializeComponent();
        }
        DateTime startDate;
        DateTime endDate;

        SqlConnection connection;
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        private void SearchDatabase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.UserAccessControl = false;
        }

        private void SearchDatabase_Load(object sender, EventArgs e)
        {

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            connection = new SqlConnection(Program.ConnectionString);
            string StringStartDate = dateTimePickerStart.Text + " 12:00:00 AM";
            string StringEndDate = dateTimePickerEnd.Text + " 11:59:59 PM";
            startDate = Convert.ToDateTime(StringStartDate);
            endDate = Convert.ToDateTime(StringEndDate);

            if (startDate < endDate)
            {
                if (textBoxVNo.Text.Trim().Length > 0)
                {
                    try
                    {
                        da = new SqlDataAdapter("select * from old where InTime > '"+startDate+"' and InTime < '"+endDate+"' and Location = '"+Program.Location+"' and VNo = '"+textBoxVNo.Text.Trim()+"' ", connection);
                        da.Fill(ds, "old");
                        dataGridView1.DataSource = ds.Tables["police"];
                        toolStripStatusLabelStatus.Text = "DONE";
                    }
                    catch (Exception ex)
                    {
                        toolStripStatusLabelStatus.Text = "ERROR CONNECTING TO DATABASE";
                    }
                }
                else
                {
                    toolStripStatusLabelStatus.Text = "VEHICLE NUMBER NOT FOUND";
                }
            }
            else
            {
                toolStripStatusLabelStatus.Text = "INVALID DATE";
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
        }

        private void textBoxVNo_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
        }
    }
}

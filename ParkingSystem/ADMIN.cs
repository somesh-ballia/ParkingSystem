using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }

        private void ADMIN_Load(object sender, EventArgs e)
        {

        }

        private void ADMIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.AccessControl = false;
        }

        private void buttonParkingRates_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (Program.AdminAccessControl == false)
            {
                Program.AdminAccessControl = true;
                ParkingRate objPR = new ParkingRate();
                objPR.MdiParent = this;
                objPR.Show();
            }
            else
            {
                toolStripStatusLabelStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }
         

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (Program.AdminAccessControl == false)
            {
                Program.AdminAccessControl = true;
                AddUser objAdd = new AddUser();
                objAdd.MdiParent = this;
                objAdd.Show();
            }
            else
            {
                toolStripStatusLabelStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (Program.AdminAccessControl == false)
            {
                Program.AdminAccessControl = true;
                DeleteUser objDEL = new DeleteUser();
                objDEL.MdiParent = this;
                objDEL.Show();
            }
            else
            {
                toolStripStatusLabelStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (Program.AdminAccessControl == false)
            {
                Program.AdminAccessControl = true;
                ChangePassword objCh = new ChangePassword();
                objCh.MdiParent = this;
                objCh.Show();
            }
            else
            {
                toolStripStatusLabelStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

       

        private void buttonReport_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (Program.AdminAccessControl == false)
            {
                Program.AdminAccessControl = true;
                GenerateReport objG = new GenerateReport();
                objG.MdiParent = this;
                objG.Show();
            }
            else
            {
                toolStripStatusLabelStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (Program.AdminAccessControl == false)
            {
                Program.AdminAccessControl = true;
                AddVehicleListADMIN objAVL = new AddVehicleListADMIN();
                objAVL.MdiParent = this;
                objAVL.Show();
            }
            else
            {
                toolStripStatusLabelStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }       

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (Program.AdminAccessControl == false)
            {
                Program.AdminAccessControl = true;
                SearchADMIN objSearch = new SearchADMIN();
                objSearch.MdiParent = this;
                objSearch.Show();
            }
            else
            {
                toolStripStatusLabelStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonCheckStatus_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (Program.AdminAccessControl == false)
            {
                Program.AdminAccessControl = true;
                Status objS = new Status();
                objS.MdiParent = this;
                objS.Show();
            }
            else
            {
                toolStripStatusLabelStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonNodeName_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (Program.AdminAccessControl == false)
            {
                Program.AdminAccessControl = true;
                Configuration objC = new Configuration();
                objC.MdiParent = this;
                objC.Show();
            }
            else
            {
                toolStripStatusLabelStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (Program.AdminAccessControl == false)
            {
                Program.AdminAccessControl = true;
                DeleteVehicle objDV = new DeleteVehicle();
                objDV.MdiParent = this;
                objDV.Show();
            }
            else
            {
                toolStripStatusLabelStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void buttonShowList_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (Program.AdminAccessControl == false)
            {
                Program.AdminAccessControl = true;
                ShowList objSh = new ShowList();
                objSh.MdiParent = this;
                objSh.Show();
            }
            else
            {
                toolStripStatusLabelStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }

        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs obj = new AboutUs();
            obj.MdiParent = this;
            obj.Show();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelStatus.Text = "";
            if (Program.AdminAccessControl == false)
            {
                Program.AdminAccessControl = true;
                ListParkingAdmin objLPA = new ListParkingAdmin();
                objLPA.MdiParent = this;
                objLPA.Show();
            }
            else
            {
                toolStripStatusLabelStatus.Text = "WARNING! CLOSE THE CURRENT VIEW FIRST";
            }
        }
    }
}

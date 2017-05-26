namespace ParkingSystem
{
    partial class ADMIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonList = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCheckStatus = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShowList = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonParkingRates = new System.Windows.Forms.Button();
            this.buttonNodeName = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonReport = new System.Windows.Forms.Button();
            this.groupBoxManagement = new System.Windows.Forms.GroupBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cHECKSTATUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEARCHToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sEARCHToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDVEHICLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGELISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkingRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxManagement.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBoxManagement);
            this.groupBox1.Location = new System.Drawing.Point(694, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 650);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonList);
            this.groupBox6.Location = new System.Drawing.Point(6, 120);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(178, 56);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Parking";
            // 
            // buttonList
            // 
            this.buttonList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonList.Location = new System.Drawing.Point(13, 17);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(153, 33);
            this.buttonList.TabIndex = 0;
            this.buttonList.Text = "VEHICLE LIST";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonSearch);
            this.groupBox5.Controls.Add(this.buttonCheckStatus);
            this.groupBox5.Location = new System.Drawing.Point(6, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(178, 99);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Status";
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(13, 58);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(153, 33);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCheckStatus
            // 
            this.buttonCheckStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckStatus.Location = new System.Drawing.Point(13, 19);
            this.buttonCheckStatus.Name = "buttonCheckStatus";
            this.buttonCheckStatus.Size = new System.Drawing.Size(153, 33);
            this.buttonCheckStatus.TabIndex = 0;
            this.buttonCheckStatus.Text = "CHECK STATUS";
            this.buttonCheckStatus.UseVisualStyleBackColor = true;
            this.buttonCheckStatus.Click += new System.EventHandler(this.buttonCheckStatus_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddVehicle);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonShowList);
            this.groupBox2.Location = new System.Drawing.Point(6, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 138);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Police Notification";
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddVehicle.Location = new System.Drawing.Point(13, 19);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(153, 33);
            this.buttonAddVehicle.TabIndex = 0;
            this.buttonAddVehicle.Text = "ADD VEHICLE";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(13, 58);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(153, 33);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "DELETE VEHICLE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonShowList
            // 
            this.buttonShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowList.Location = new System.Drawing.Point(13, 97);
            this.buttonShowList.Name = "buttonShowList";
            this.buttonShowList.Size = new System.Drawing.Size(153, 33);
            this.buttonShowList.TabIndex = 2;
            this.buttonShowList.Text = "SHOW LIST";
            this.buttonShowList.UseVisualStyleBackColor = true;
            this.buttonShowList.Click += new System.EventHandler(this.buttonShowList_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonParkingRates);
            this.groupBox4.Controls.Add(this.buttonNodeName);
            this.groupBox4.Location = new System.Drawing.Point(6, 549);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 95);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settings";
            // 
            // buttonParkingRates
            // 
            this.buttonParkingRates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParkingRates.Location = new System.Drawing.Point(13, 54);
            this.buttonParkingRates.Name = "buttonParkingRates";
            this.buttonParkingRates.Size = new System.Drawing.Size(153, 33);
            this.buttonParkingRates.TabIndex = 1;
            this.buttonParkingRates.Text = "PARKING RATES";
            this.buttonParkingRates.UseVisualStyleBackColor = true;
            this.buttonParkingRates.Click += new System.EventHandler(this.buttonParkingRates_Click);
            // 
            // buttonNodeName
            // 
            this.buttonNodeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNodeName.Location = new System.Drawing.Point(13, 15);
            this.buttonNodeName.Name = "buttonNodeName";
            this.buttonNodeName.Size = new System.Drawing.Size(153, 33);
            this.buttonNodeName.TabIndex = 0;
            this.buttonNodeName.Text = "CONFIGURATION";
            this.buttonNodeName.UseVisualStyleBackColor = true;
            this.buttonNodeName.Click += new System.EventHandler(this.buttonNodeName_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonReport);
            this.groupBox3.Location = new System.Drawing.Point(6, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reporting";
            // 
            // buttonReport
            // 
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Location = new System.Drawing.Point(13, 17);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(153, 33);
            this.buttonReport.TabIndex = 0;
            this.buttonReport.Text = "GENERATE REPORT";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // groupBoxManagement
            // 
            this.groupBoxManagement.Controls.Add(this.buttonAddUser);
            this.groupBoxManagement.Controls.Add(this.buttonDeleteUser);
            this.groupBoxManagement.Controls.Add(this.buttonChangePassword);
            this.groupBoxManagement.Location = new System.Drawing.Point(6, 404);
            this.groupBoxManagement.Name = "groupBoxManagement";
            this.groupBoxManagement.Size = new System.Drawing.Size(178, 140);
            this.groupBoxManagement.TabIndex = 4;
            this.groupBoxManagement.TabStop = false;
            this.groupBoxManagement.Text = "Account Management";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Location = new System.Drawing.Point(13, 19);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(153, 33);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "ADD USER";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Location = new System.Drawing.Point(13, 59);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(153, 33);
            this.buttonDeleteUser.TabIndex = 1;
            this.buttonDeleteUser.Text = "DELETE USER";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePassword.Location = new System.Drawing.Point(13, 97);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(153, 33);
            this.buttonChangePassword.TabIndex = 2;
            this.buttonChangePassword.Text = "CHANGE PASSWORD";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHECKSTATUSToolStripMenuItem,
            this.toolStripMenuItem2,
            this.rEPORTToolStripMenuItem,
            this.aDDVEHICLEToolStripMenuItem,
            this.mANAGELISTToolStripMenuItem,
            this.toolStripMenuItem1,
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cHECKSTATUSToolStripMenuItem
            // 
            this.cHECKSTATUSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sEARCHToolStripMenuItem1,
            this.sEARCHToolStripMenuItem2});
            this.cHECKSTATUSToolStripMenuItem.Name = "cHECKSTATUSToolStripMenuItem";
            this.cHECKSTATUSToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cHECKSTATUSToolStripMenuItem.Text = "Status";
            // 
            // sEARCHToolStripMenuItem1
            // 
            this.sEARCHToolStripMenuItem1.Name = "sEARCHToolStripMenuItem1";
            this.sEARCHToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.sEARCHToolStripMenuItem1.Text = "Check Status";
            this.sEARCHToolStripMenuItem1.Click += new System.EventHandler(this.buttonCheckStatus_Click);
            // 
            // sEARCHToolStripMenuItem2
            // 
            this.sEARCHToolStripMenuItem2.Name = "sEARCHToolStripMenuItem2";
            this.sEARCHToolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.sEARCHToolStripMenuItem2.Text = "Search";
            this.sEARCHToolStripMenuItem2.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 20);
            this.toolStripMenuItem2.Text = "Parking List";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // rEPORTToolStripMenuItem
            // 
            this.rEPORTToolStripMenuItem.Name = "rEPORTToolStripMenuItem";
            this.rEPORTToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.rEPORTToolStripMenuItem.Text = "Report";
            this.rEPORTToolStripMenuItem.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // aDDVEHICLEToolStripMenuItem
            // 
            this.aDDVEHICLEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem1,
            this.deleteVehicleToolStripMenuItem,
            this.showListToolStripMenuItem});
            this.aDDVEHICLEToolStripMenuItem.Name = "aDDVEHICLEToolStripMenuItem";
            this.aDDVEHICLEToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.aDDVEHICLEToolStripMenuItem.Text = "Police Notification";
            // 
            // addVehicleToolStripMenuItem1
            // 
            this.addVehicleToolStripMenuItem1.Name = "addVehicleToolStripMenuItem1";
            this.addVehicleToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.addVehicleToolStripMenuItem1.Text = "Add Vehicle";
            this.addVehicleToolStripMenuItem1.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // deleteVehicleToolStripMenuItem
            // 
            this.deleteVehicleToolStripMenuItem.Name = "deleteVehicleToolStripMenuItem";
            this.deleteVehicleToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deleteVehicleToolStripMenuItem.Text = "Delete Vehicle";
            this.deleteVehicleToolStripMenuItem.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // showListToolStripMenuItem
            // 
            this.showListToolStripMenuItem.Name = "showListToolStripMenuItem";
            this.showListToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.showListToolStripMenuItem.Text = "Show List";
            this.showListToolStripMenuItem.Click += new System.EventHandler(this.buttonShowList_Click);
            // 
            // mANAGELISTToolStripMenuItem
            // 
            this.mANAGELISTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem1,
            this.deleteUserToolStripMenuItem1,
            this.changePasswordToolStripMenuItem1});
            this.mANAGELISTToolStripMenuItem.Name = "mANAGELISTToolStripMenuItem";
            this.mANAGELISTToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.mANAGELISTToolStripMenuItem.Text = "Account";
            // 
            // addUserToolStripMenuItem1
            // 
            this.addUserToolStripMenuItem1.Name = "addUserToolStripMenuItem1";
            this.addUserToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.addUserToolStripMenuItem1.Text = "Add User";
            this.addUserToolStripMenuItem1.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // deleteUserToolStripMenuItem1
            // 
            this.deleteUserToolStripMenuItem1.Name = "deleteUserToolStripMenuItem1";
            this.deleteUserToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.deleteUserToolStripMenuItem1.Text = "Delete User";
            this.deleteUserToolStripMenuItem1.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // changePasswordToolStripMenuItem1
            // 
            this.changePasswordToolStripMenuItem1.Name = "changePasswordToolStripMenuItem1";
            this.changePasswordToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem1.Text = "Change Password";
            this.changePasswordToolStripMenuItem1.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.parkingRatesToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Settings";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.buttonNodeName_Click);
            // 
            // parkingRatesToolStripMenuItem
            // 
            this.parkingRatesToolStripMenuItem.Name = "parkingRatesToolStripMenuItem";
            this.parkingRatesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.parkingRatesToolStripMenuItem.Text = "Parking Rates";
            this.parkingRatesToolStripMenuItem.Click += new System.EventHandler(this.buttonParkingRates_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hELPToolStripMenuItem.Text = "Help";
            this.hELPToolStripMenuItem.Click += new System.EventHandler(this.hELPToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "STATUS :";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 702);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(900, 740);
            this.MinimumSize = new System.Drawing.Size(900, 740);
            this.Name = "ADMIN";
            this.Text = "ADMIN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ADMIN_FormClosed);
            this.Load += new System.EventHandler(this.ADMIN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxManagement.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonParkingRates;
        private System.Windows.Forms.Button buttonNodeName;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBoxManagement;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.Button buttonShowList;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCheckStatus;
        private System.Windows.Forms.ToolStripMenuItem cHECKSTATUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDVEHICLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGELISTToolStripMenuItem;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripMenuItem sEARCHToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sEARCHToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parkingRatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}
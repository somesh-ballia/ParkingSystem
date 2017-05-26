namespace ParkingSystem
{
    partial class USER
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxRFID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.groupBoxNew = new System.Windows.Forms.GroupBox();
            this.buttonRegisterCard = new System.Windows.Forms.Button();
            this.groupBoxEmergency = new System.Windows.Forms.GroupBox();
            this.buttonFlag = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxRegular = new System.Windows.Forms.GroupBox();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEntry = new System.Windows.Forms.Button();
            this.groupBoxFinancial = new System.Windows.Forms.GroupBox();
            this.buttonRecharge = new System.Windows.Forms.Button();
            this.buttonFine = new System.Windows.Forms.Button();
            this.buttonCheckBalance = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vehicleEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBalanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechargeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusParkingStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.comport = new System.IO.Ports.SerialPort(this.components);
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxNew.SuspendLayout();
            this.groupBoxEmergency.SuspendLayout();
            this.groupBoxRegular.SuspendLayout();
            this.groupBoxFinancial.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBoxNew);
            this.groupBox1.Controls.Add(this.groupBoxEmergency);
            this.groupBox1.Controls.Add(this.groupBoxRegular);
            this.groupBox1.Controls.Add(this.groupBoxFinancial);
            this.groupBox1.Location = new System.Drawing.Point(694, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 650);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxRFID);
            this.groupBox3.Location = new System.Drawing.Point(6, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RFID";
            // 
            // textBoxRFID
            // 
            this.textBoxRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRFID.ForeColor = System.Drawing.Color.Red;
            this.textBoxRFID.Location = new System.Drawing.Point(17, 16);
            this.textBoxRFID.Name = "textBoxRFID";
            this.textBoxRFID.ReadOnly = true;
            this.textBoxRFID.Size = new System.Drawing.Size(144, 22);
            this.textBoxRFID.TabIndex = 0;
            this.textBoxRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonStatus);
            this.groupBox2.Location = new System.Drawing.Point(6, 573);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // buttonStatus
            // 
            this.buttonStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatus.Location = new System.Drawing.Point(13, 14);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(153, 33);
            this.buttonStatus.TabIndex = 0;
            this.buttonStatus.Text = "CHECK PARKING STATUS";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // groupBoxNew
            // 
            this.groupBoxNew.Controls.Add(this.buttonRegisterCard);
            this.groupBoxNew.Location = new System.Drawing.Point(6, 502);
            this.groupBoxNew.Name = "groupBoxNew";
            this.groupBoxNew.Size = new System.Drawing.Size(178, 61);
            this.groupBoxNew.TabIndex = 3;
            this.groupBoxNew.TabStop = false;
            this.groupBoxNew.Text = "New Card";
            // 
            // buttonRegisterCard
            // 
            this.buttonRegisterCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterCard.Location = new System.Drawing.Point(13, 19);
            this.buttonRegisterCard.Name = "buttonRegisterCard";
            this.buttonRegisterCard.Size = new System.Drawing.Size(153, 33);
            this.buttonRegisterCard.TabIndex = 0;
            this.buttonRegisterCard.Text = "REGISTER NEW CARD";
            this.buttonRegisterCard.UseVisualStyleBackColor = true;
            this.buttonRegisterCard.Click += new System.EventHandler(this.buttonRegisterCard_Click);
            // 
            // groupBoxEmergency
            // 
            this.groupBoxEmergency.Controls.Add(this.buttonFlag);
            this.groupBoxEmergency.Controls.Add(this.buttonSearch);
            this.groupBoxEmergency.Location = new System.Drawing.Point(6, 382);
            this.groupBoxEmergency.Name = "groupBoxEmergency";
            this.groupBoxEmergency.Size = new System.Drawing.Size(178, 110);
            this.groupBoxEmergency.TabIndex = 2;
            this.groupBoxEmergency.TabStop = false;
            this.groupBoxEmergency.Text = "Emergency";
            // 
            // buttonFlag
            // 
            this.buttonFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlag.Location = new System.Drawing.Point(13, 25);
            this.buttonFlag.Name = "buttonFlag";
            this.buttonFlag.Size = new System.Drawing.Size(153, 33);
            this.buttonFlag.TabIndex = 0;
            this.buttonFlag.Text = "ADD VEHICLE";
            this.buttonFlag.UseVisualStyleBackColor = true;
            this.buttonFlag.Click += new System.EventHandler(this.buttonFlag_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(13, 64);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(153, 33);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxRegular
            // 
            this.groupBoxRegular.Controls.Add(this.buttonList);
            this.groupBoxRegular.Controls.Add(this.buttonExit);
            this.groupBoxRegular.Controls.Add(this.buttonEntry);
            this.groupBoxRegular.Location = new System.Drawing.Point(6, 77);
            this.groupBoxRegular.Name = "groupBoxRegular";
            this.groupBoxRegular.Size = new System.Drawing.Size(178, 141);
            this.groupBoxRegular.TabIndex = 0;
            this.groupBoxRegular.TabStop = false;
            this.groupBoxRegular.Text = "Parking";
            // 
            // buttonList
            // 
            this.buttonList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonList.Location = new System.Drawing.Point(13, 97);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(153, 33);
            this.buttonList.TabIndex = 2;
            this.buttonList.Text = "VEHICLE LIST";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(13, 58);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(153, 33);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "VEHICLE EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonEntry
            // 
            this.buttonEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntry.Location = new System.Drawing.Point(13, 19);
            this.buttonEntry.Name = "buttonEntry";
            this.buttonEntry.Size = new System.Drawing.Size(153, 33);
            this.buttonEntry.TabIndex = 0;
            this.buttonEntry.Text = "VEHICLE ENTRY";
            this.buttonEntry.UseVisualStyleBackColor = true;
            this.buttonEntry.Click += new System.EventHandler(this.buttonEntry_Click);
            // 
            // groupBoxFinancial
            // 
            this.groupBoxFinancial.Controls.Add(this.buttonRecharge);
            this.groupBoxFinancial.Controls.Add(this.buttonFine);
            this.groupBoxFinancial.Controls.Add(this.buttonCheckBalance);
            this.groupBoxFinancial.Location = new System.Drawing.Point(6, 228);
            this.groupBoxFinancial.Name = "groupBoxFinancial";
            this.groupBoxFinancial.Size = new System.Drawing.Size(178, 144);
            this.groupBoxFinancial.TabIndex = 1;
            this.groupBoxFinancial.TabStop = false;
            this.groupBoxFinancial.Text = "Financial";
            // 
            // buttonRecharge
            // 
            this.buttonRecharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecharge.Location = new System.Drawing.Point(13, 19);
            this.buttonRecharge.Name = "buttonRecharge";
            this.buttonRecharge.Size = new System.Drawing.Size(153, 33);
            this.buttonRecharge.TabIndex = 0;
            this.buttonRecharge.Text = "RECHARGE";
            this.buttonRecharge.UseVisualStyleBackColor = true;
            this.buttonRecharge.Click += new System.EventHandler(this.buttonRecharge_Click);
            // 
            // buttonFine
            // 
            this.buttonFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFine.Location = new System.Drawing.Point(13, 97);
            this.buttonFine.Name = "buttonFine";
            this.buttonFine.Size = new System.Drawing.Size(153, 33);
            this.buttonFine.TabIndex = 2;
            this.buttonFine.Text = "FINE PAYMENT";
            this.buttonFine.UseVisualStyleBackColor = true;
            this.buttonFine.Click += new System.EventHandler(this.buttonFine_Click);
            // 
            // buttonCheckBalance
            // 
            this.buttonCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckBalance.Location = new System.Drawing.Point(13, 58);
            this.buttonCheckBalance.Name = "buttonCheckBalance";
            this.buttonCheckBalance.Size = new System.Drawing.Size(153, 33);
            this.buttonCheckBalance.TabIndex = 1;
            this.buttonCheckBalance.Text = "CHECK BALANCE";
            this.buttonCheckBalance.UseVisualStyleBackColor = true;
            this.buttonCheckBalance.Click += new System.EventHandler(this.buttonCheckBalance_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleEntryToolStripMenuItem,
            this.vehicleExitToolStripMenuItem,
            this.rechargeAccountToolStripMenuItem,
            this.checkBalanceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vehicleEntryToolStripMenuItem
            // 
            this.vehicleEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.listToolStripMenuItem});
            this.vehicleEntryToolStripMenuItem.Name = "vehicleEntryToolStripMenuItem";
            this.vehicleEntryToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.vehicleEntryToolStripMenuItem.Text = "Parking";
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.entryToolStripMenuItem.Text = "Entry";
            this.entryToolStripMenuItem.Click += new System.EventHandler(this.buttonEntry_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // vehicleExitToolStripMenuItem
            // 
            this.vehicleExitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechargeToolStripMenuItem,
            this.checkBalanceToolStripMenuItem1,
            this.fineToolStripMenuItem});
            this.vehicleExitToolStripMenuItem.Name = "vehicleExitToolStripMenuItem";
            this.vehicleExitToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.vehicleExitToolStripMenuItem.Text = "Financial";
            // 
            // rechargeToolStripMenuItem
            // 
            this.rechargeToolStripMenuItem.Name = "rechargeToolStripMenuItem";
            this.rechargeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.rechargeToolStripMenuItem.Text = "Recharge";
            this.rechargeToolStripMenuItem.Click += new System.EventHandler(this.buttonRecharge_Click);
            // 
            // checkBalanceToolStripMenuItem1
            // 
            this.checkBalanceToolStripMenuItem1.Name = "checkBalanceToolStripMenuItem1";
            this.checkBalanceToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.checkBalanceToolStripMenuItem1.Text = "Balance";
            this.checkBalanceToolStripMenuItem1.Click += new System.EventHandler(this.buttonCheckBalance_Click);
            // 
            // fineToolStripMenuItem
            // 
            this.fineToolStripMenuItem.Name = "fineToolStripMenuItem";
            this.fineToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.fineToolStripMenuItem.Text = "Fine";
            this.fineToolStripMenuItem.Click += new System.EventHandler(this.buttonFine_Click);
            // 
            // rechargeAccountToolStripMenuItem
            // 
            this.rechargeAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.searchToolStripMenuItem1});
            this.rechargeAccountToolStripMenuItem.Name = "rechargeAccountToolStripMenuItem";
            this.rechargeAccountToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.rechargeAccountToolStripMenuItem.Text = "Emergency";
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.addVehicleToolStripMenuItem.Text = "Add Vehicle";
            this.addVehicleToolStripMenuItem.Click += new System.EventHandler(this.buttonFlag_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBalanceToolStripMenuItem
            // 
            this.checkBalanceToolStripMenuItem.Name = "checkBalanceToolStripMenuItem";
            this.checkBalanceToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.checkBalanceToolStripMenuItem.Text = "New Card";
            this.checkBalanceToolStripMenuItem.Click += new System.EventHandler(this.buttonRegisterCard_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(180, 17);
            this.toolStripStatusLabel1.Text = "| TOTAL VEHICLES IN PARKING : ";
            // 
            // toolStripStatusParkingStatus
            // 
            this.toolStripStatusParkingStatus.Name = "toolStripStatusParkingStatus";
            this.toolStripStatusParkingStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLStatus,
            this.toolStripStatusLabel1,
            this.toolStripStatusParkingStatus,
            this.toolStripStatusLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel3.Text = "STATUS";
            // 
            // toolStripStatusLStatus
            // 
            this.toolStripStatusLStatus.Name = "toolStripStatusLStatus";
            this.toolStripStatusLStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelStatus.Text = "0";
            // 
            // comport
            // 
            this.comport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.comport_DataReceived);
            // 
            // timerCheck
            // 
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // USER
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
            this.Name = "USER";
            this.Text = "USER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.USER_FormClosed);
            this.Load += new System.EventHandler(this.USER_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxNew.ResumeLayout(false);
            this.groupBoxEmergency.ResumeLayout(false);
            this.groupBoxRegular.ResumeLayout(false);
            this.groupBoxFinancial.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rechargeAccountToolStripMenuItem;
        private System.Windows.Forms.Button buttonEntry;
        private System.Windows.Forms.Button buttonRegisterCard;
        private System.Windows.Forms.Button buttonFlag;
        private System.Windows.Forms.Button buttonRecharge;
        private System.Windows.Forms.Button buttonCheckBalance;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolStripMenuItem checkBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleExitToolStripMenuItem;
        private System.Windows.Forms.Button buttonFine;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxNew;
        private System.Windows.Forms.GroupBox groupBoxEmergency;
        private System.Windows.Forms.GroupBox groupBoxRegular;
        private System.Windows.Forms.GroupBox groupBoxFinancial;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusParkingStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLStatus;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBalanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxRFID;
        private System.IO.Ports.SerialPort comport;
        private System.Windows.Forms.Timer timerCheck;
    }
}
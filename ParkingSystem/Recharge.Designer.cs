namespace ParkingSystem
{
    partial class Recharge
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRFID = new System.Windows.Forms.TextBox();
            this.textBoxRechargeAmmount = new System.Windows.Forms.TextBox();
            this.textBoxCurrentBalance = new System.Windows.Forms.TextBox();
            this.textBoxLastRecharge = new System.Windows.Forms.TextBox();
            this.buttonRecharge = new System.Windows.Forms.Button();
            this.buttonFetch = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECHARGE ACCOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RFID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "BALANCE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AMOUNT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TIME STAMP";
            // 
            // textBoxRFID
            // 
            this.textBoxRFID.Location = new System.Drawing.Point(77, 18);
            this.textBoxRFID.Name = "textBoxRFID";
            this.textBoxRFID.ReadOnly = true;
            this.textBoxRFID.Size = new System.Drawing.Size(159, 20);
            this.textBoxRFID.TabIndex = 0;
            this.textBoxRFID.TabStop = false;
            // 
            // textBoxRechargeAmmount
            // 
            this.textBoxRechargeAmmount.Location = new System.Drawing.Point(77, 51);
            this.textBoxRechargeAmmount.Name = "textBoxRechargeAmmount";
            this.textBoxRechargeAmmount.Size = new System.Drawing.Size(159, 20);
            this.textBoxRechargeAmmount.TabIndex = 0;
            // 
            // textBoxCurrentBalance
            // 
            this.textBoxCurrentBalance.Location = new System.Drawing.Point(77, 19);
            this.textBoxCurrentBalance.Name = "textBoxCurrentBalance";
            this.textBoxCurrentBalance.ReadOnly = true;
            this.textBoxCurrentBalance.Size = new System.Drawing.Size(159, 20);
            this.textBoxCurrentBalance.TabIndex = 2;
            this.textBoxCurrentBalance.TabStop = false;
            // 
            // textBoxLastRecharge
            // 
            this.textBoxLastRecharge.Location = new System.Drawing.Point(77, 60);
            this.textBoxLastRecharge.Name = "textBoxLastRecharge";
            this.textBoxLastRecharge.ReadOnly = true;
            this.textBoxLastRecharge.Size = new System.Drawing.Size(159, 20);
            this.textBoxLastRecharge.TabIndex = 3;
            this.textBoxLastRecharge.TabStop = false;
            // 
            // buttonRecharge
            // 
            this.buttonRecharge.Location = new System.Drawing.Point(242, 54);
            this.buttonRecharge.Name = "buttonRecharge";
            this.buttonRecharge.Size = new System.Drawing.Size(75, 23);
            this.buttonRecharge.TabIndex = 2;
            this.buttonRecharge.Text = "RECHARGE";
            this.buttonRecharge.UseVisualStyleBackColor = true;
            this.buttonRecharge.Click += new System.EventHandler(this.buttonRecharge_Click);
            // 
            // buttonFetch
            // 
            this.buttonFetch.Location = new System.Drawing.Point(242, 17);
            this.buttonFetch.Name = "buttonFetch";
            this.buttonFetch.Size = new System.Drawing.Size(75, 23);
            this.buttonFetch.TabIndex = 1;
            this.buttonFetch.Text = "Fetch";
            this.buttonFetch.UseVisualStyleBackColor = true;
            this.buttonFetch.Click += new System.EventHandler(this.buttonFetch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 270);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(378, 22);
            this.statusStrip1.TabIndex = 18;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxRFID);
            this.groupBox1.Controls.Add(this.buttonFetch);
            this.groupBox1.Controls.Add(this.buttonRecharge);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxRechargeAmmount);
            this.groupBox1.Location = new System.Drawing.Point(25, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 88);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entry";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCurrentBalance);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxLastRecharge);
            this.groupBox2.Location = new System.Drawing.Point(25, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // Recharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 330);
            this.Name = "Recharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RECHARGE - ACCOUNT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Recharge_FormClosed);
            this.Load += new System.EventHandler(this.Recharge_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRFID;
        private System.Windows.Forms.TextBox textBoxRechargeAmmount;
        private System.Windows.Forms.TextBox textBoxCurrentBalance;
        private System.Windows.Forms.TextBox textBoxLastRecharge;
        private System.Windows.Forms.Button buttonRecharge;
        private System.Windows.Forms.Button buttonFetch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
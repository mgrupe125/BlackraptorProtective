namespace Client
{
    partial class frmReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewer));
            this.txtUserEidNo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtViewFinalReports = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdMinimizeProgram = new System.Windows.Forms.Button();
            this.cmdmnuViewAllUsers = new System.Windows.Forms.Button();
            this.lblBRPClient = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserEidNo
            // 
            this.txtUserEidNo.Location = new System.Drawing.Point(11, 5);
            this.txtUserEidNo.Name = "txtUserEidNo";
            this.txtUserEidNo.Size = new System.Drawing.Size(100, 20);
            this.txtUserEidNo.TabIndex = 334;
            this.txtUserEidNo.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtViewFinalReports);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtUserEidNo);
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 659);
            this.panel2.TabIndex = 334;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(416, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 326;
            this.button1.Text = "Locate Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtViewFinalReports
            // 
            this.txtViewFinalReports.Location = new System.Drawing.Point(300, 25);
            this.txtViewFinalReports.Name = "txtViewFinalReports";
            this.txtViewFinalReports.Size = new System.Drawing.Size(110, 20);
            this.txtViewFinalReports.TabIndex = 336;
            this.txtViewFinalReports.TextChanged += new System.EventHandler(this.txtViewFinalReports_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 335;
            this.label1.Text = "View Finalized reports by entering the Report No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdMinimizeProgram
            // 
            this.cmdMinimizeProgram.BackColor = System.Drawing.Color.Black;
            this.cmdMinimizeProgram.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmdMinimizeProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdMinimizeProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimizeProgram.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMinimizeProgram.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmdMinimizeProgram.Location = new System.Drawing.Point(1018, 3);
            this.cmdMinimizeProgram.Name = "cmdMinimizeProgram";
            this.cmdMinimizeProgram.Size = new System.Drawing.Size(21, 24);
            this.cmdMinimizeProgram.TabIndex = 338;
            this.cmdMinimizeProgram.Text = "_";
            this.cmdMinimizeProgram.UseVisualStyleBackColor = false;
            this.cmdMinimizeProgram.Click += new System.EventHandler(this.cmdMinimizeProgram_Click_1);
            // 
            // cmdmnuViewAllUsers
            // 
            this.cmdmnuViewAllUsers.BackColor = System.Drawing.Color.Black;
            this.cmdmnuViewAllUsers.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmdmnuViewAllUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdmnuViewAllUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdmnuViewAllUsers.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdmnuViewAllUsers.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmdmnuViewAllUsers.Location = new System.Drawing.Point(1040, 3);
            this.cmdmnuViewAllUsers.Name = "cmdmnuViewAllUsers";
            this.cmdmnuViewAllUsers.Size = new System.Drawing.Size(21, 24);
            this.cmdmnuViewAllUsers.TabIndex = 337;
            this.cmdmnuViewAllUsers.Text = "X";
            this.cmdmnuViewAllUsers.UseVisualStyleBackColor = false;
            this.cmdmnuViewAllUsers.Click += new System.EventHandler(this.cmdmnuViewAllUsers_Click_1);
            // 
            // lblBRPClient
            // 
            this.lblBRPClient.AutoSize = true;
            this.lblBRPClient.BackColor = System.Drawing.Color.Black;
            this.lblBRPClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBRPClient.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblBRPClient.Location = new System.Drawing.Point(429, 5);
            this.lblBRPClient.Name = "lblBRPClient";
            this.lblBRPClient.Size = new System.Drawing.Size(160, 21);
            this.lblBRPClient.TabIndex = 336;
            this.lblBRPClient.Text = "REPORT VIEWER";
            this.lblBRPClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBRPClient_MouseDown);
            this.lblBRPClient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBRPClient_MouseMove);
            this.lblBRPClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblBRPClient_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(1, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 339;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1061, 28);
            this.pictureBox1.TabIndex = 335;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1061, 687);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmdMinimizeProgram);
            this.Controls.Add(this.lblBRPClient);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmdmnuViewAllUsers);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportViewer";
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserEidNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdMinimizeProgram;
        private System.Windows.Forms.Button cmdmnuViewAllUsers;
        private System.Windows.Forms.Label lblBRPClient;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtViewFinalReports;
        private System.Windows.Forms.Button button1;
        
        //private DataSet4 dataSet4;
    }
}
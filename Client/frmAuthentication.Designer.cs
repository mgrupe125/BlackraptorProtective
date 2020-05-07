namespace Client
{
    partial class frmAuthentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuthentication));
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblwaitAuthentication = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoginBRP = new System.Windows.Forms.Button();
            this.txtclientRole = new System.Windows.Forms.TextBox();
            this.txtreadUsername = new System.Windows.Forms.TextBox();
            this.txtreadPassword = new System.Windows.Forms.TextBox();
            this.pictureBRP = new System.Windows.Forms.PictureBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.timerClient = new System.Windows.Forms.Timer(this.components);
            this.timerSupervisor = new System.Windows.Forms.Timer(this.components);
            this.timerAdministrator = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdMinimizeProgram = new System.Windows.Forms.Button();
            this.cmdmnuViewAllUsers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBRP = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBRP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(31, 36);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "UserName:";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.SteelBlue;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(112, 33);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(157, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassWord.ForeColor = System.Drawing.Color.White;
            this.txtPassWord.Location = new System.Drawing.Point(112, 57);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(157, 20);
            this.txtPassWord.TabIndex = 4;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWord.Location = new System.Drawing.Point(34, 60);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(75, 13);
            this.lblPassWord.TabIndex = 3;
            this.lblPassWord.Text = "PassWord:";
            // 
            // lblwaitAuthentication
            // 
            this.lblwaitAuthentication.AutoSize = true;
            this.lblwaitAuthentication.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwaitAuthentication.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblwaitAuthentication.Location = new System.Drawing.Point(159, 200);
            this.lblwaitAuthentication.Name = "lblwaitAuthentication";
            this.lblwaitAuthentication.Size = new System.Drawing.Size(63, 12);
            this.lblwaitAuthentication.TabIndex = 6;
            this.lblwaitAuthentication.Text = "Waiting...";
            this.lblwaitAuthentication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoginBRP
            // 
            this.btnLoginBRP.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnLoginBRP.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLoginBRP.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnLoginBRP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnLoginBRP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoginBRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginBRP.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLoginBRP.Location = new System.Drawing.Point(111, 56);
            this.btnLoginBRP.Name = "btnLoginBRP";
            this.btnLoginBRP.Size = new System.Drawing.Size(157, 27);
            this.btnLoginBRP.TabIndex = 144;
            this.btnLoginBRP.Text = "Login";
            this.btnLoginBRP.UseVisualStyleBackColor = false;
            this.btnLoginBRP.Click += new System.EventHandler(this.btnLoginBRP_Click);
            // 
            // txtclientRole
            // 
            this.txtclientRole.Location = new System.Drawing.Point(301, 186);
            this.txtclientRole.Name = "txtclientRole";
            this.txtclientRole.Size = new System.Drawing.Size(40, 20);
            this.txtclientRole.TabIndex = 148;
            this.txtclientRole.Visible = false;
            // 
            // txtreadUsername
            // 
            this.txtreadUsername.Location = new System.Drawing.Point(301, 128);
            this.txtreadUsername.Name = "txtreadUsername";
            this.txtreadUsername.Size = new System.Drawing.Size(40, 20);
            this.txtreadUsername.TabIndex = 149;
            this.txtreadUsername.Visible = false;
            // 
            // txtreadPassword
            // 
            this.txtreadPassword.Location = new System.Drawing.Point(301, 154);
            this.txtreadPassword.Name = "txtreadPassword";
            this.txtreadPassword.Size = new System.Drawing.Size(40, 20);
            this.txtreadPassword.TabIndex = 150;
            this.txtreadPassword.Visible = false;
            // 
            // pictureBRP
            // 
            this.pictureBRP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBRP.Image")));
            this.pictureBRP.Location = new System.Drawing.Point(124, 89);
            this.pictureBRP.Name = "pictureBRP";
            this.pictureBRP.Size = new System.Drawing.Size(120, 100);
            this.pictureBRP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBRP.TabIndex = 152;
            this.pictureBRP.TabStop = false;
            // 
            // picLoading
            // 
            this.picLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLoading.Image = global::Client.Properties.Resources.preloader;
            this.picLoading.Location = new System.Drawing.Point(111, 89);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(157, 100);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoading.TabIndex = 153;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // timerClient
            // 
            this.timerClient.Interval = 8000;
            this.timerClient.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // timerSupervisor
            // 
            this.timerSupervisor.Interval = 8000;
            this.timerSupervisor.Tick += new System.EventHandler(this.timerSupervisor_Tick);
            // 
            // timerAdministrator
            // 
            this.timerAdministrator.Interval = 8000;
            this.timerAdministrator.Tick += new System.EventHandler(this.timerAdministrator_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picLoading);
            this.panel1.Controls.Add(this.btnLoginBRP);
            this.panel1.Controls.Add(this.lblwaitAuthentication);
            this.panel1.Controls.Add(this.pictureBRP);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 220);
            this.panel1.TabIndex = 154;
            // 
            // cmdMinimizeProgram
            // 
            this.cmdMinimizeProgram.BackColor = System.Drawing.Color.Black;
            this.cmdMinimizeProgram.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmdMinimizeProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdMinimizeProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimizeProgram.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMinimizeProgram.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmdMinimizeProgram.Location = new System.Drawing.Point(324, 1);
            this.cmdMinimizeProgram.Name = "cmdMinimizeProgram";
            this.cmdMinimizeProgram.Size = new System.Drawing.Size(16, 24);
            this.cmdMinimizeProgram.TabIndex = 331;
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
            this.cmdmnuViewAllUsers.Location = new System.Drawing.Point(341, 1);
            this.cmdmnuViewAllUsers.Name = "cmdmnuViewAllUsers";
            this.cmdmnuViewAllUsers.Size = new System.Drawing.Size(16, 24);
            this.cmdmnuViewAllUsers.TabIndex = 325;
            this.cmdmnuViewAllUsers.Text = "X";
            this.cmdmnuViewAllUsers.UseVisualStyleBackColor = false;
            this.cmdmnuViewAllUsers.Click += new System.EventHandler(this.cmdmnuViewAllUsers_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 26);
            this.pictureBox1.TabIndex = 156;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // lblBRP
            // 
            this.lblBRP.AutoSize = true;
            this.lblBRP.BackColor = System.Drawing.Color.Black;
            this.lblBRP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBRP.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblBRP.Location = new System.Drawing.Point(50, 5);
            this.lblBRP.Name = "lblBRP";
            this.lblBRP.Size = new System.Drawing.Size(241, 19);
            this.lblBRP.TabIndex = 157;
            this.lblBRP.Text = "- BLACKRAPTOR PROTECTIVE -";
            this.lblBRP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBRP_MouseDown);
            this.lblBRP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBRP_MouseMove);
            this.lblBRP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblBRP_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::Client.Properties.Resources.badge1;
            this.pictureBox2.Location = new System.Drawing.Point(1, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 336;
            this.pictureBox2.TabStop = false;
            // 
            // frmAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 246);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmdMinimizeProgram);
            this.Controls.Add(this.lblBRP);
            this.Controls.Add(this.cmdmnuViewAllUsers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtreadPassword);
            this.Controls.Add(this.txtreadUsername);
            this.Controls.Add(this.txtclientRole);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAuthentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.frmAuthentication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBRP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Label lblwaitAuthentication;
        //private sql29409DataSet sql29409DataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        //private sql29409DataSetTableAdapters.ClientLoginTableAdapter clientLoginTableAdapter;
        private System.Windows.Forms.Button btnLoginBRP;
        private System.Windows.Forms.TextBox txtclientRole;
        private System.Windows.Forms.TextBox txtreadUsername;
        private System.Windows.Forms.TextBox txtreadPassword;
        private System.Windows.Forms.PictureBox pictureBRP;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Timer timerClient;
        private System.Windows.Forms.Timer timerSupervisor;
        private System.Windows.Forms.Timer timerAdministrator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdMinimizeProgram;
        private System.Windows.Forms.Button cmdmnuViewAllUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBRP;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


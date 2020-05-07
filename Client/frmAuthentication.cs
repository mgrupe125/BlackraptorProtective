using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace Client
{
    public partial class frmAuthentication : Form
    {
        //Global variables;
        
        private PictureBox box = new PictureBox();
        private Panel closeButton = new Panel();
        private bool moveable;
        private Point currentPosition;
        private Image img;
        int TogMove;
        int MValX;
        int MValY;


        public frmAuthentication()
        {
            InitializeComponent();
            
            
        }

        public bool tryLoginClient(string username, string password)
        {


            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ClientLogin WHERE clientusername = '" + username + "' AND clientpassword = '" + password + "';");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {
                txtclientRole.Text = "" + reader["clientRole"];
                

                if (reader.IsDBNull(0) == true)
                {
                    cmd.Connection.Close();
                    reader.Dispose();
                    cmd.Dispose();
                    return false;
                }
                else
                {
                    cmd.Connection.Close();
                    reader.Dispose();
                    cmd.Dispose();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        
     
        private void client()
        {
            throw new NotImplementedException();
        }

        private void frmAuthentication_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sql29409DataSet.ClientLogin' table. You can move, or remove it, as needed.
            this.AcceptButton = btnLoginBRP;








        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void btnLoginBRP_Click(object sender, EventArgs e)
        {
            
            String username = txtUserName.Text;
            //Lowercase the incoming clientRole
            txtUserName.Text = username.ToLower();
            String password = txtPassWord.Text;
            //Lowercase the incoming clientRole
            txtPassWord.Text = password.ToLower();

            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ClientLogin WHERE clientusername = '" + username + "' AND clientpassword = '" + password + "';");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {
                txtclientRole.Text = "" + reader["clientRole"];
                //Lowercase the incoming clientRole
                string lwrClientRole = txtclientRole.Text;
                txtclientRole.Text = lwrClientRole.ToLower(); 

                txtreadUsername.Text = "" + reader["clientusername"];
                //Lowercase the incoming clientRole
                string lwrReadUsername = txtreadUsername.Text;
                txtreadUsername.Text = lwrReadUsername.ToLower(); 

                txtreadPassword.Text = "" + reader["clientpassword"];
                //Lowercase the incoming clientRole
                string lwrReadPassword = txtreadPassword.Text;
                txtreadPassword.Text = lwrReadPassword.ToLower(); 

                if (reader.IsDBNull(0) == true)
                {
                    cmd.Connection.Close();
                    reader.Dispose();
                    cmd.Dispose();
                    //return false;
                }
                else
                {
                    cmd.Connection.Close();
                    reader.Dispose();
                    cmd.Dispose();
                    //return true;
                }
            }
            else
            {
                //return false;
            }

            String readUsername = txtreadUsername.Text;

            String readPassword = txtreadPassword.Text;
            

            clientRoleLogin(txtUserName.Text, txtPassWord.Text);      


                    

                

                
     
            }

        public void clientRoleLogin(string username, string password)
        {
                    String clientRole = txtclientRole.Text;
                    //Check username/password combination
                    if ( ( username == txtreadUsername.Text) & (password == txtreadPassword.Text) & ( clientRole == "client" ) )
                    {
                        
                            //Load the Main Client Version
                            lblwaitAuthentication.Text = "Validating...";
                            //MessageBox.Show(" Loading Client... ", "Authorized");
                            timerClient.Enabled = true;
                            picLoading.Visible = true;
                            
                            //this.Hide();
                            //frmClient mainClient = new frmClient(txtUserName.Text);

                            //mainClient.Show();
                        }
                    //Check username/password combination
                    else if ((username == txtreadUsername.Text) & (password == txtreadPassword.Text) & ( clientRole == "supervisor" ) )
                        {
                            //Load the Main Supervisor Version
                            lblwaitAuthentication.Text = "Validating...";
                            timerSupervisor.Enabled = true;
                            picLoading.Visible = true;
                            
                            //MessageBox.Show(" Loading Supervisor... ", "Authorized");
                            //this.Hide();
                            //frmSupervisor mainSupervisor = new frmSupervisor(txtUserName.Text);

                            //mainSupervisor.Show();

                        }
                    else if ((username == txtreadUsername.Text) & (password == txtreadPassword.Text) & (clientRole == "administrator"))
                    {
                        lblwaitAuthentication.Text = "Validating...";
                        timerAdministrator.Enabled = true;
                        picLoading.Visible = true;

                    }

                    else
                    {
                        picLoading.Visible = true;
                        MessageBox.Show(" - Invalid Username/Password - ", "Authentication");
                        txtUserName.Text = "";
                        txtPassWord.Text = "";
                        txtUserName.Focus();
                        picLoading.Visible = false;
                    }
        }

   
        private void btnTest_Click(object sender, EventArgs e)
        {
            frmSupervisor mainSupervisor = new frmSupervisor();
            mainSupervisor.Show();
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {

            this.Hide();
            frmClient mainClient = new frmClient(txtUserName.Text);

            mainClient.Show();
            timerClient.Enabled = false;



        }

        private void timerSupervisor_Tick(object sender, EventArgs e)
        {
            this.Hide();
            frmSupervisor mainSupervisor = new frmSupervisor(txtUserName.Text);

            mainSupervisor.Show();
            timerSupervisor.Enabled = false;
        }

        private void timerAdministrator_Tick(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin mainAdministrator = new frmAdmin(txtUserName.Text);

            mainAdministrator.Show();
            timerAdministrator.Enabled = false;
        }

        private void cmdmnuViewAllUsers_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdMinimizeProgram_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void lblClientLogin_MouseDown(object sender, MouseEventArgs e)
        {
            //TogMove = 1;
           // MValX = e.X;
           // MValY = e.Y;
        }

        private void lblClientLogin_MouseUp(object sender, MouseEventArgs e)
        {
            //TogMove = 0;
        }

        private void lblClientLogin_MouseMove(object sender, MouseEventArgs e)
        {
            //TogMove = 1;
           // MValX = e.X;
            //MValY = e.Y;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void lblBRP_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void lblBRP_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void lblBRP_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void cmdMinimizeProgram_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmdmnuViewAllUsers_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        
        

        
    }
}

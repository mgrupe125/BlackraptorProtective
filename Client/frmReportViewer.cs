using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;


namespace Client
{
    public partial class frmReportViewer :  Form
    {
        MySqlCommand myCmdQuery = new MySqlCommand();
        MySqlDataAdapter myDA = new MySqlDataAdapter();
        BindingSource bS = new BindingSource();
        MySqlCommandBuilder myCB = new MySqlCommandBuilder();
        DataSet ds = new DataSet();
        int TogMove;
        int MValX;
        int MValY;

        
        public frmReportViewer(string userEIDNo)
        {
            InitializeComponent();
            txtUserEidNo.Text = userEIDNo;
        }


        

        private void cmdMinimizeProgram_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmdmnuViewAllUsers_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void lblBRPClient_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void lblBRPClient_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void lblBRPClient_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void cmdmnuViewAllUsers_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void frmReportViewer_Load(object sender, EventArgs e)
        {

















            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        

        private void cmdMinimizeProgram_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtViewFinalReports_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        }

    }


    


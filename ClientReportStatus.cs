using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Client
{
    public partial class clientReportStatus : Form
    {
        MySqlCommand myCmdQuery = new MySqlCommand();
        MySqlDataAdapter myDA = new MySqlDataAdapter();
        BindingSource bS = new BindingSource();
        MySqlCommandBuilder myCB = new MySqlCommandBuilder();
        DataSet ds = new DataSet();
        int TogMove;
        int MValX;
        int MValY;

        public clientReportStatus(string userEIDNo)
        {
            InitializeComponent();
            txtUserEidNo.Text = userEIDNo;
        }

        private void btnSubmittedReports_Click(object sender, EventArgs e)
        {
            // string connection
            string myStringCon = "SERVER=sql29409.db.10825756.hostedresource.com;" +
            "DATABASE=sql29409;" +
            "UID=sql29409;" +
            "PASSWORD=Aa3969889!;";

            //create an instance of MySqlConnection class
            MySqlConnection myconnection = new MySqlConnection(myStringCon);

            try
            {

                myconnection.Open();
                //test the connection
                //MessageBox.Show(myconnection.State.ToString());
            }
            catch (MySqlException ex)
            {// catch mysql related error
                MessageBox.Show(ex.Message);
            }

            MySqlCommand myQuery = new MySqlCommand();
            MySqlDataAdapter myDA = new MySqlDataAdapter();
            //create an instance of a class
            MySqlCommandBuilder myCB = new MySqlCommandBuilder();
            //set DaraAdapter  value to MySqlDataAdapter
            myCB.DataAdapter = myDA;
            DataSet ds = new DataSet();
            //create an instance of a class
            BindingSource bS = new BindingSource();


            myCmdQuery.CommandText = "SELECT ReportNumber, FinalReportVersion FROM Incident WHERE ClientEID = '" + txtUserEidNo.Text + "' ";
            myCmdQuery.CommandType = CommandType.Text;
            myCmdQuery.Connection = myconnection;


            myDA.SelectCommand = myCmdQuery;


            myCB.DataAdapter = myDA;

            //fill the dataset
            myDA.Fill(ds, "member");
            bS.DataSource = ds;
            bS.DataMember = "member";

            grdViewReports.DataSource = bS;
            //bNMember.BindingSource = bS;
        }

        private void cmdmnuViewAllUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdMinimizeProgram_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void lblClientLogin_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void lblClientLogin_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void lblClientLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
    }
}

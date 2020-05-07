using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dispatch
{
    public partial class frmDispatchClient : Form
    {
        MySqlCommand myCmdQuery = new MySqlCommand();
        MySqlDataAdapter myDA = new MySqlDataAdapter();
        BindingSource bS = new BindingSource();
        MySqlCommandBuilder myCB = new MySqlCommandBuilder();
        DataSet ds = new DataSet();
        public frmDispatchClient()
        {
            InitializeComponent();
        }

        private void cmdActive_Click(object sender, EventArgs e)
        {
            activePanel.Visible = true;
            callsPendingPanel.Visible = false;
            unitsPanel.Visible = false;
            dispositionPanel.Visible = false;
            queriesPanel.Visible = false;
            checkPanel.Visible = false;
        }

        private void cmdCallsPending_Click(object sender, EventArgs e)
        {
            callsPendingPanel.Visible = true;
            activePanel.Visible = false;
            unitsPanel.Visible = false;
            dispositionPanel.Visible = false;
            queriesPanel.Visible = false;
            checkPanel.Visible = false;
        }

        private void cmdUnits_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            callsPendingPanel.Visible = false;
            unitsPanel.Visible = true;
            dispositionPanel.Visible = false;
            queriesPanel.Visible = false;
            checkPanel.Visible = false;
        }

        private void cmdDisposition_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            callsPendingPanel.Visible = false;
            unitsPanel.Visible = false;
            dispositionPanel.Visible = true;
            queriesPanel.Visible = false;
            checkPanel.Visible = false;
        }

        private void cmdQueries_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            callsPendingPanel.Visible = false;
            unitsPanel.Visible = false;
            dispositionPanel.Visible = false;
            queriesPanel.Visible = true;
            checkPanel.Visible = false;
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            callsPendingPanel.Visible = false;
            unitsPanel.Visible = false;
            dispositionPanel.Visible = false;
            queriesPanel.Visible = false;
            checkPanel.Visible = true;
        }

        private void lblbrpMainInfo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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


            myCmdQuery.CommandText = "SELECT clientusername, clientEIDNo, clientRole FROM ClientLogin";
            myCmdQuery.CommandType = CommandType.Text;
            myCmdQuery.Connection = myconnection;


            myDA.SelectCommand = myCmdQuery;


            myCB.DataAdapter = myDA;

            //fill the dataset
            myDA.Fill(ds, "member");
            bS.DataSource = ds;
            bS.DataMember = "member";

            grdCallsPending.DataSource = bS;
            //bNMember.BindingSource = bS;
        }

        private void timer1_Tick(object sender, EventArgs e)
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


            myCmdQuery.CommandText = "SELECT clientusername, clientEIDNo, clientRole FROM ClientLogin";
            myCmdQuery.CommandType = CommandType.Text;
            myCmdQuery.Connection = myconnection;


            myDA.SelectCommand = myCmdQuery;


            myCB.DataAdapter = myDA;

            //fill the dataset
            myDA.Fill(ds, "member");
            bS.DataSource = ds;
            bS.DataMember = "member";

            grdCallsPending.DataSource = bS;
            //bNMember.BindingSource = bS;
        }
    }
}

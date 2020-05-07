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
    public partial class frmSupervisor : Form
    {
        MySqlCommand myCmdQuery = new MySqlCommand();
        MySqlDataAdapter myDA = new MySqlDataAdapter();
        BindingSource bS = new BindingSource();
        MySqlCommandBuilder myCB = new MySqlCommandBuilder();
        DataSet ds = new DataSet();
        int TogMove;
        int MValX;
        int MValY;

        public frmSupervisor(string user_EIDPass)
        {
            InitializeComponent();
            txtuserEID.Text = user_EIDPass;

        }

        public frmSupervisor()
        {
            // TODO: Complete member initialization
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp mainAbout = new frmHelp();
            mainAbout.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelpContents mainHelpContents = new frmHelpContents();
            mainHelpContents.Show();
        }

        private void searchForApprovedReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void frmSupervisor_Load(object sender, EventArgs e)
        {
            
         
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("SELECT ClientEIDNo FROM ClientLogin WHERE clientusername = '" + txtuserEID.Text + "' ");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {
                lblClientEIDNoLoggedIn.Text = "" + reader["ClientEIDNo"];
                txtuserEID.Text = "" + reader["ClientEIDNo"];
                if (reader.IsDBNull(0) == true)
                {
                    cmd.Connection.Close();
                    reader.Dispose();
                    cmd.Dispose();

                }
                else
                {
                    cmd.Connection.Close();
                    reader.Dispose();
                    cmd.Dispose();

                }
            }
            else
            {

            }




        }

        

        private void mnuEIDLoggedIn_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAllUsers_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViewAllUsers_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnViewReports_Click(object sender, EventArgs e)
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


            myCmdQuery.CommandText = "SELECT ReportNumber, ClientEID, Agency FROM Incident WHERE FinalReportVersion = 'AwaitingApproval'";
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

        private void cmdmnuIncident_Click(object sender, EventArgs e)
        {
            
            SupervisorTabControl.SelectTab("Incident");
            cmdmnuIncident.BackColor = Color.SteelBlue;
            cmdmnuPersons.BackColor = Color.LightSteelBlue;
            cmdmnuReportExtra.BackColor = Color.LightSteelBlue;
            cmdmnuNarrative.BackColor = Color.LightSteelBlue;
            cmdmnuApproveDecline.BackColor = Color.LightSteelBlue;
        }

        private void cmdmnuPersons_Click(object sender, EventArgs e)
        {
            SupervisorTabControl.SelectTab("Persons");
            cmdmnuIncident.BackColor = Color.LightSteelBlue;
            cmdmnuPersons.BackColor = Color.SteelBlue;
            cmdmnuReportExtra.BackColor = Color.LightSteelBlue;
            cmdmnuNarrative.BackColor = Color.LightSteelBlue;
            cmdmnuApproveDecline.BackColor = Color.LightSteelBlue;
        }

        private void cmdmnuReportExtra_Click(object sender, EventArgs e)
        {
            SupervisorTabControl.SelectTab("ReportExtra");
            cmdmnuIncident.BackColor = Color.LightSteelBlue;
            cmdmnuPersons.BackColor = Color.LightSteelBlue;
            cmdmnuReportExtra.BackColor = Color.SteelBlue;
            cmdmnuNarrative.BackColor = Color.LightSteelBlue;
            cmdmnuApproveDecline.BackColor = Color.LightSteelBlue;
        }

        private void cmdmnuNarrative_Click(object sender, EventArgs e)
        {
            SupervisorTabControl.SelectTab("Narrative");
            cmdmnuIncident.BackColor = Color.LightSteelBlue;
            cmdmnuPersons.BackColor = Color.LightSteelBlue;
            cmdmnuReportExtra.BackColor = Color.LightSteelBlue;
            cmdmnuNarrative.BackColor = Color.SteelBlue;
            cmdmnuApproveDecline.BackColor = Color.LightSteelBlue;
        }

        private void cmdLocateReport_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Incident WHERE ReportNumber = '" + txtApproveReport.Text + "' ");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {
                //Enable TabControl
                SupervisorTabControl.Enabled = true;
                cmdmnuIncident.Enabled = true;
                cmdmnuPersons.Enabled = true;
                cmdmnuReportExtra.Enabled = true;
                cmdmnuNarrative.Enabled = true;
                cmdmnuApproveDecline.Enabled = true;
                

                //Load Fields from Database Search
                lblSAgency.Text = "" + reader["Agency"];
                lblSReportNo.Text = "" + reader["ReportNumber"];
                lblSsupplementNo.Text = "" + reader["SupplementNumber"];
                lblSReportedDate.Text = "" + reader["ReportedDate"];
                lblSReportedTime.Text = "" + reader["ReportedTime"];
                lblSConfidential.Text = "" + reader["Confidential"];
                lblSCmdrRpt.Text = "" + reader["CmdrRpt"];
                lblSIncidentEIDNo.Text = "" + reader["ClientEID"];
                lblSCADCallNo.Text = "" + reader["CADCallNumber"];
                lblSstatus.Text = "" + reader["Status"];
                lblSNatureOfCall.Text = "" + reader["NatureOfCall"];
                lblSPropertyId.Text = "" + reader["PropertyId"];
                lblSUnitNo.Text = "" + reader["UnitNumber"];
                lblSCity.Text = "" + reader["City"];
                lblSZipCode.Text = "" + reader["ZIPCode"];
                lblSRepDist.Text = "" + reader["RepDist"];
                lblSBeat.Text = "" + reader["Beat"];
                lblSArea.Text = "" + reader["Area"];
                lblSFromDate.Text = "" + reader["FromDate"];
                lblSFromTime.Text = "" + reader["FromTime"];
                lblSToDate.Text = "" + reader["ToDate"];
                lblSToTime.Text = "" + reader["ToTime"];
                lblSOfficer.Text = "" + reader["Officer"];
                lblSAssignment.Text = "" + reader["Assignment"];
                lblS2ndOfficer.Text = "" + reader["2ndOfficer"];
                lblS2ndAssignment.Text = "" + reader["2ndAssignment"];
                //chkbxConfidential.CheckState =  reader["Confidential"];
                lblSEnteredby.Text = "" + reader["EnteredBy"];
                lblSAssignmentCopy.Text = "" + reader["EnteredBy2"];
                lblSReviewOfficer.Text = "" + reader["ReviewOfficer"];
                lblSRCStatus.Text = "" + reader["RCStatus"];
                lblSRCStatusDate.Text = "" + reader["RCStatusDate"];
                lblSRCStatusTime.Text = "" + reader["RCStatusTime"];
                rtxtExtratoReport.Text = "" + reader["ExtraToReport"];
                lblSPInvolvement.Text = "" + reader["PInvolvement"];
                lblSPInvlNo.Text = "" + reader["PInvolvementNumber"];
                lblSPType.Text = "" + reader["PType"];
                lblSPName.Text = "" + reader["PName"];
                lblSPMNI.Text = "" + reader["PMini"];
                lblSPRace.Text = "" + reader["PRace"];
                lblSPSex.Text = "" + reader["PSex"];
                lblSPDOB.Text = "" + reader["PDOB"];
                lblSPAge.Text = "" + reader["PAge"];
                lblSPToAge.Text = "" + reader["PToAge"];
                lblSPJuvenile.Text = "" + reader["PJuvenile"];
                lblSPHeight.Text = "" + reader["PHeight"];
                lblSPToHeight.Text = "" + reader["PToHeight"];
                lblSPWeight.Text = "" + reader["PWeight"];
                lblSPToWeight.Text = "" + reader["PToWeight"];
                lblSPHairColor.Text = "" + reader["PHairColor"];
                lblSPEyeColor.Text = "" + reader["PEyeColor"];
                lblSPSkin.Text = "" + reader["PSkin"];
                lblSPEthnicity.Text = "" + reader["PEthnicity"];
                //chkbxConfidential
                lblSPMeansOfAttack.Text = "" + reader["PMeansOfAttack"];
                lblSPExtentOfInjury.Text = "" + reader["PExtentOfInjury"];
                lblSPDomViolence.Text = "" + reader["PDomViolence"];
                lblSPRelationshiptoOffender.Text = "" + reader["PRelationToOffender"];
                lblSPPOB.Text = "" + reader["PPlaceOfBirth"];
                rtxtNarrative.Text = "" + reader["NNarative"];



                MessageBox.Show("Report Found - Loading Data...", "Supervisor Reports");
                
                
               


                if (reader.IsDBNull(0) == true)
                {
                    cmd.Connection.Close();
                    reader.Dispose();
                    cmd.Dispose();

                }
                else
                {
                    cmd.Connection.Close();
                    reader.Dispose();
                    cmd.Dispose();

                }
            }
            else
            {

                MessageBox.Show("Report Not Found", "Supervisor Reports");
                
            }
            txtApproveReport.Text = "";
        }

        private void cmdmnuApproveDecline_Click(object sender, EventArgs e)
        {
            SupervisorTabControl.SelectTab("approveDecline");
            cmdmnuIncident.BackColor = Color.LightSteelBlue;
            cmdmnuPersons.BackColor = Color.LightSteelBlue;
            cmdmnuReportExtra.BackColor = Color.LightSteelBlue;
            cmdmnuNarrative.BackColor = Color.LightSteelBlue;
            cmdmnuApproveDecline.BackColor = Color.SteelBlue;
        }

        private void cmdDeclineReport_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("UPDATE Incident Set FinalReportVersion = 'Declined' WHERE ReportNumber = '" + lblSReportNo.Text + "' ");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {
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
            MessageBox.Show(" - Final Report was Officially Declined. - ", " Supervisor Reports");
            //Clear Fields from Database Search
            lblSAgency.Text = "";
            lblSReportNo.Text = "";
            lblSsupplementNo.Text = "";
            lblSReportedDate.Text = "";
            lblSReportedTime.Text = "";
            lblSConfidential.Text = "";
            lblSCmdrRpt.Text = "";
            lblSIncidentEIDNo.Text = "";
            lblSCADCallNo.Text = "";
            lblSstatus.Text = "";
            lblSNatureOfCall.Text = "";
            lblSPropertyId.Text = "";
            lblSUnitNo.Text = "";
            lblSCity.Text = "";
            lblSZipCode.Text = "";
            lblSRepDist.Text = "";
            lblSBeat.Text = "";
            lblSArea.Text = "";
            lblSFromDate.Text = "";
            lblSFromTime.Text = "";
            lblSToDate.Text = "";
            lblSToTime.Text = "";
            lblSOfficer.Text = "";
            lblSAssignment.Text = "";
            lblS2ndOfficer.Text = "";
            lblS2ndAssignment.Text = "";
            
            lblSEnteredby.Text = "";
            lblSAssignmentCopy.Text = "";
            lblSReviewOfficer.Text = "";
            lblSRCStatus.Text = "";
            lblSRCStatusDate.Text = "";
            lblSRCStatusTime.Text = "";
            rtxtExtratoReport.Text = "";
            lblSPInvolvement.Text = "";
            lblSPInvlNo.Text = "";
            lblSPType.Text = "";
            lblSPName.Text = "";
            lblSPMNI.Text = "";
            lblSPRace.Text = "";
            lblSPSex.Text = "";
            lblSPDOB.Text = "";
            lblSPAge.Text = "";
            lblSPToAge.Text = "";
            lblSPJuvenile.Text = "";
            lblSPHeight.Text = "";
            lblSPToHeight.Text = "";
            lblSPWeight.Text = "";
            lblSPToWeight.Text = "";
            lblSPHairColor.Text = "";
            lblSPEyeColor.Text = "";
            lblSPSkin.Text = "";
            lblSPEthnicity.Text = "";
            //chkbxConfidential
            lblSPMeansOfAttack.Text = "";
            lblSPExtentOfInjury.Text = "";
            lblSPDomViolence.Text = "";
            lblSPRelationshiptoOffender.Text = "";
            lblSPPOB.Text = "";
            rtxtNarrative.Text = "";
            //Select Incident Tab
            SupervisorTabControl.SelectTab("Incident");
            cmdmnuIncident.BackColor = Color.SteelBlue;
            cmdmnuPersons.BackColor = Color.LightSteelBlue;
            cmdmnuReportExtra.BackColor = Color.LightSteelBlue;
            cmdmnuNarrative.BackColor = Color.LightSteelBlue;
            cmdmnuApproveDecline.BackColor = Color.LightSteelBlue;
            //Disable TabControl
            SupervisorTabControl.Enabled = false;
            cmdmnuIncident.Enabled = false;
            cmdmnuPersons.Enabled = false;
            cmdmnuReportExtra.Enabled = false;
            cmdmnuNarrative.Enabled = false;
            cmdmnuApproveDecline.Enabled = false;
            
        }

        private void cmdApproveReport_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("UPDATE Incident Set FinalReportVersion = 'Approved' WHERE ReportNumber = '" + lblSReportNo.Text + "' ");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {
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
            MessageBox.Show(" - Final Report was Officially Approved! The Report will be saved into Archives. - ", " Supervisor Reports");
            //Clear Fields from Database Search
            lblSAgency.Text = "";
            lblSReportNo.Text = "";
            lblSsupplementNo.Text = "";
            lblSReportedDate.Text = "";
            lblSReportedTime.Text = "";
            lblSConfidential.Text = "";
            lblSCmdrRpt.Text = "";
            lblSIncidentEIDNo.Text = "";
            lblSCADCallNo.Text = "";
            lblSstatus.Text = "";
            lblSNatureOfCall.Text = "";
            lblSPropertyId.Text = "";
            lblSUnitNo.Text = "";
            lblSCity.Text = "";
            lblSZipCode.Text = "";
            lblSRepDist.Text = "";
            lblSBeat.Text = "";
            lblSArea.Text = "";
            lblSFromDate.Text = "";
            lblSFromTime.Text = "";
            lblSToDate.Text = "";
            lblSToTime.Text = "";
            lblSOfficer.Text = "";
            lblSAssignment.Text = "";
            lblS2ndOfficer.Text = "";
            lblS2ndAssignment.Text = "";

            lblSEnteredby.Text = "";
            lblSAssignmentCopy.Text = "";
            lblSReviewOfficer.Text = "";
            lblSRCStatus.Text = "";
            lblSRCStatusDate.Text = "";
            lblSRCStatusTime.Text = "";
            rtxtExtratoReport.Text = "";
            lblSPInvolvement.Text = "";
            lblSPInvlNo.Text = "";
            lblSPType.Text = "";
            lblSPName.Text = "";
            lblSPMNI.Text = "";
            lblSPRace.Text = "";
            lblSPSex.Text = "";
            lblSPDOB.Text = "";
            lblSPAge.Text = "";
            lblSPToAge.Text = "";
            lblSPJuvenile.Text = "";
            lblSPHeight.Text = "";
            lblSPToHeight.Text = "";
            lblSPWeight.Text = "";
            lblSPToWeight.Text = "";
            lblSPHairColor.Text = "";
            lblSPEyeColor.Text = "";
            lblSPSkin.Text = "";
            lblSPEthnicity.Text = "";
            //chkbxConfidential
            lblSPMeansOfAttack.Text = "";
            lblSPExtentOfInjury.Text = "";
            lblSPDomViolence.Text = "";
            lblSPRelationshiptoOffender.Text = "";
            lblSPPOB.Text = "";
            rtxtNarrative.Text = "";
            //Select Incident Tab
            SupervisorTabControl.SelectTab("Incident");
            cmdmnuIncident.BackColor = Color.SteelBlue;
            cmdmnuPersons.BackColor = Color.LightSteelBlue;
            cmdmnuReportExtra.BackColor = Color.LightSteelBlue;
            cmdmnuNarrative.BackColor = Color.LightSteelBlue;
            cmdmnuApproveDecline.BackColor = Color.LightSteelBlue;
            //Disable TabControl
            SupervisorTabControl.Enabled = false;
            cmdmnuIncident.Enabled = false;
            cmdmnuPersons.Enabled = false;
            cmdmnuReportExtra.Enabled = false;
            cmdmnuNarrative.Enabled = false;
            cmdmnuApproveDecline.Enabled = false;
        }

        private void refreshStatusToolStripMenuItem_Click(object sender, EventArgs e)
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


            myCmdQuery.CommandText = "SELECT ReportNumber, ClientEID, Agency FROM Incident WHERE FinalReportVersion = 'AwaitingApproval'";
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

        private void cmdMinimizeProgram_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmdmnuViewAllUsers_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void label13_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void label13_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void label13_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        

        

        

        

        

        

        

        

        

        

        
    }
}

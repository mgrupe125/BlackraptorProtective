using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.IO;

namespace Client
{
    public partial class frmClient : Form
    {
        MySqlCommand myCmdQuery = new MySqlCommand();
        MySqlDataAdapter myDA = new MySqlDataAdapter();
        BindingSource bS = new BindingSource();
        MySqlCommandBuilder myCB = new MySqlCommandBuilder();
        DataSet ds = new DataSet();
        int TogMove;
        int MValX;
        int MValY;

        public frmClient(string user_Pass)
        {
            InitializeComponent();
            txtUsernamePass.Text = user_Pass;
        }



        private void frmClient_Load(object sender, EventArgs e)
        {
            

            

            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("SELECT ClientEIDNo FROM ClientLogin WHERE clientusername = '" + txtUsernamePass.Text + "' ");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {
                lblClientEIDNoLoggedIn.Text = "" + reader["ClientEIDNo"];
                
                txtUsernamePass.Text = "" + reader["ClientEIDNo"];
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

        private static void Upload(string ftpServer, string userName, string password, string filename)
        {
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                client.Credentials = new System.Net.NetworkCredential(userName, password);
                client.UploadFile(ftpServer + "/" + new FileInfo(filename).Name, "STOR", filename);
            }
        }


        private void mainTabControl_SelectedIndexChanged(object sender, TabControlEventArgs e)
        {
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelpContents mainHelpContents = new frmHelpContents();
            mainHelpContents.Show();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp mainAbout = new frmHelp();
            mainAbout.Show();
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void item2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveNarrative_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Persons(NNarative ) VALUES('" + rtxtNarrative.Text + "' )");
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
            
        }

        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            
            btnSubmitReport.Visible = false;
            lblCertainReport.Visible = true;
            lblNoteFinalChanges.Visible = true;
            btnNoCancel.Visible = true;
            btnYesSumbit.Visible = true;
           
        }

        private void btnNoCancel_Click(object sender, EventArgs e)
        {
            btnSubmitReport.Visible = true;
            lblCertainReport.Visible = false;
            lblNoteFinalChanges.Visible = false;
            btnNoCancel.Visible = false;
            btnYesSumbit.Visible = false;
        }

        private void btnYesSumbit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("UPDATE Incident Set Agency = '" + txtAgency.Text + "', SupplementNumber = '" + txtSupplementNo.Text
                                              + "', ReportedDate = '" + txtReportedDate.Text + "', ReportedTime = '" + txtReportedTime.Text
                                              + "', CADCallNumber = '" + txtCADCallNo.Text + "', Status = '" + txtStatus.Text
                                              + "', NatureOfCall = '" + txtNatureofCall.Text + "', PropertyId = '" + cmboPropertyId.Text
                                              + "', UnitNumber = '" + txtUnitNumber.Text + "', City = '" + txtCity.Text
                                              + "', ZipCode = '" + txtZipCode.Text + "', RepDist = '" + txtRepDist.Text
                                              + "', Beat = '" + txtBeat.Text + "', Area = '" + txtArea.Text
                                              + "', FromDate = '" + txtFromDate.Text + "', FromTime = '" + txtFromTime.Text
                                              + "', ToDate = '" + txtToDate.Text + "', Officer = '" + txtOfficer.Text
                                              + "', Assignment = '" + txtAssignment.Text + "', Confidential = '" + chkbxConfidential.Checked
                                              + "', CmdrRpt = '" + chkbxCmdrRpt.Checked + "', EnteredBy = '" + txtEnteredby.Text
                                              + "', EnteredBy2 = '" + txtAssignmentCopy.Text + "', ReviewOfficer = '" + txtReviewOfficer.Text
                                              + "', RCStatus = '" + txtRCStatus.Text + "', RCStatusDate = '" + txtRCStatusDate.Text
                                              + "', RCStatusTime = '" + txtRCStatusTime.Text + "', ExtraToReport = '" + rtxtExtratoReport.Text
                                              + "', PInvolvement = '" + txtPInvolvement.Text + "', PInvolvementNumber = '" + txtPInvlNo.Text
                                              + "', PType = '" + txtPType.Text + "', PName = '" + txtPName.Text + "', PMini = '" + txtPMNI.Text
                                              + "', PRace = '" + txtPRace.Text + "', PSex = '" + txtPSex.Text + "', PDOB = '" + txtPDOB.Text
                                              + "', PAge = '" + txtPAge.Text + "', PToAge = '" + txtPToAge.Text + "', PJuvenile = '" + txtPJuvenile.Text
                                              + "', PHeight = '" + txtPHeight.Text + "', PToHeight = '" + txtPToHeight.Text + "', PWeight = '" + txtPWeight.Text
                                              + "', PToWeight = '" + txtPToWeight.Text + "', PHairColor = '" + txtPHairColor.Text + "', PEyeColor = '" + txtPEyeColor.Text
                                              + "', PSkin = '" + txtPSkin.Text + "', PEthnicity = '" + txtPEthnicity.Text + "', PConfidential = '" + chkbxPConfidential.Checked
                                              + "', PMeansOfAttack = '" + txtPMeansofAttack.Text + "', PExtentOfInjury = '" + txtPExtentOfInjury.Text + "', PDomViolence = '" + txtPDomViolence.Text
                                              + "', PRelationToOffender = '" + txtPRelationtoOffender.Text + "', PPlaceOfBirth = '" + txtPDOB.Text + "', FinalReportVersion = 'AwaitingApproval',  NNarative = '" + rtxtNarrative.Text + "' WHERE ReportNumber = '" + txtReportNo.Text + "' ");
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
            MessageBox.Show(" - Final Report Submission Completed Successfully! - ", "Report");
            btnSubmitReport.Visible = true;
            lblCertainReport.Visible = false;
            lblNoteFinalChanges.Visible = false;
            btnNoCancel.Visible = false;
            btnYesSumbit.Visible = false;
            btnUpdateReport.Visible = false;
            btnUpdateReport.Enabled = false;
            lblUpdateReport.Visible = false;
            btnCloseReport.Visible = false;
            lblCloseReport.Visible = false;
            

            mainTabControl.SelectTab("Incident");
            IncidentTabControl.SelectTab("Offense");
            cmdmnuIncident.BackColor = Color.SteelBlue;
            cmdmnuSendToSupervisor.BackColor = Color.LightSteelBlue;
            mainTabControl.Enabled = false;
            mnuSendtoSupervisor.Enabled = false;
            btnUpdateReport.Enabled = false;
            lblUpdateReport.Enabled = false;
            cmdmnuIncident.Enabled = false;
            cmdmnuPersons.Enabled = false;
            cmdmnuNarrative.Enabled = false;
            cmdmnuSendToSupervisor.Enabled = false;

            txtAgency.Text = "";
            cmboPPropertyId.Text = "";
            txtReportNo.Text = "";
            txtSupplementNo.Text = "";
            txtReportedDate.Text = "";
            txtReportedTime.Text = "";
            txtCADCallNo.Text = "";
            txtStatus.Text = "";
            txtNatureofCall.Text = "";
            cmboPropertyId.Text = "";
            txtUnitNumber.Text = "";
            txtIEIDNo.Text = "";
            txtCity.Text = "";
            txtZipCode.Text = "";
            txtRepDist.Text = "";
            txtBeat.Text = "";
            txtArea.Text = "";
            txtFromDate.Text = "";
            txtFromTime.Text = "";
            txtToDate.Text = "";
            txtOfficer.Text = "";
            txtAssignment.Text = "";
            chkbxConfidential.Checked = false;
            chkbxCmdrRpt.Checked = false;
            txtEnteredby.Text = "";
            txtAssignmentCopy.Text = "";
            txtReviewOfficer.Text = "";
            txtRCStatus.Text = "";
            txtRCStatusDate.Text = "";
            txtRCStatusTime.Text = "";
            rtxtExtratoReport.Text = "";
            txtPInvolvement.Text = "";
            txtPInvlNo.Text = "";
            txtPType.Text = "";
            txtPName.Text = "";
            txtPMNI.Text = "";
            txtPRace.Text = "";
            txtPSex.Text = "";
            txtPDOB.Text = "";
            txtPAge.Text = "";
            txtPToAge.Text = "";
            txtPJuvenile.Text = "";
            txtPHeight.Text = "";
            txtPToHeight.Text = "";
            txtPWeight.Text = "";
            txtPToWeight.Text = "";
            txtPHairColor.Text = "";
            txtPEyeColor.Text = "";
            txtPSkin.Text = "";
            txtPEthnicity.Text = "";
            chkbxPConfidential.Checked = false;
            txtPMeansofAttack.Text = "";
            txtPExtentOfInjury.Text = "";
            txtPDomViolence.Text = "";
            txtPRelationtoOffender.Text = "";
            txtPDOB.Text = "";
            rtxtNarrative.Text = "";
            MessageBox.Show("   ** Awaiting SuperVisor Approval **   ", "Report");

        }

        private void btnISave_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Incident(Agency, ReportNumber, SupplementNumber, ReportedDate, ReportedTime, CADCallNumber, Status, NatureOfCall, PropertyId, UnitNumber, City, ZipCode, RepDist, Beat, Area, FromDate, FromTime, ToDate, Officer, Assignment, Confidential, CmdrRpt, EnteredBy, EnteredBy2, ReviewOfficer, RCStatus, RCStatusDate, RCStatusTime, ExtraToReport) VALUES('" + txtAgency.Text + "', '" + txtReportNo.Text + "', '" + txtSupplementNo.Text + "', '" + txtReportedDate.Text + "', '" + txtReportedTime.Text + "', '" + txtCADCallNo.Text + "', '" + txtStatus.Text + "', '" + txtNatureofCall.Text + "', '" + cmboPropertyId.Text + "', '" + txtUnitNumber.Text + "', '" + txtCity.Text + "', '" + txtZipCode.Text + "', '" + txtRepDist.Text + "', '" + txtBeat.Text + "', '" + txtArea.Text + "', '" + txtFromDate.Text + "', '" + txtFromTime.Text + "', '" + txtToDate.Text + "', '" + txtOfficer.Text + "', '" + txtAssignment.Text + "', '" + chkbxConfidential.Checked + "', '" + chkbxCmdrRpt.Checked + "', '" + txtEnteredby.Text + "', '" + txtAssignmentCopy.Text + "', '" + txtReviewOfficer.Text + "', '" + txtRCStatus.Text + "', '" + txtRCStatusDate.Text + "', '" + txtRCStatusTime.Text + "', '" + rtxtExtratoReport.Text + "' )");
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
           
            
            
           
}

        private void btnPSave_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Persons(PInvolvement, PInvolvementNumber, PType, PName, PMini, PRace, PSex, PDOB, PAge, PToAge, PJuvenile, PHeight, PToHeight, PWeight, PToWeight, PHairColor, PEyeColor, PSkin, PEthnicity, PConfidential, PMeansOfAttack, PExtentOfInjury, PDomViolence, PRelationToOffender, PPlaceOfBirth ) VALUES('" + txtPInvolvement.Text + "', '" + txtPInvlNo.Text + "', '" + txtPType.Text + "', '" + txtPName.Text + "', '" + txtPMNI.Text + "', '" + txtPRace.Text + "', '" + txtPSex.Text + "', '" + txtPDOB.Text + "', '" + txtPAge.Text + "', '" + txtPToAge.Text + "', '" + txtPJuvenile.Text + "', '" + txtPHeight.Text + "', '" + txtPToHeight.Text + "', '" + txtPWeight.Text + "', '" + txtPToWeight.Text + "', '" + txtPHairColor.Text + "', '" + txtPEyeColor.Text + "', '" + txtPSkin.Text + "', '" + txtPEthnicity.Text + "', '" + chkbxPConfidential.Checked + "', '" + txtPMeansofAttack.Text + "', '" + txtPExtentOfInjury.Text + "', '" + txtPDomViolence.Text + "', '" + txtPRelationtoOffender.Text + "', '" + txtPDOB.Text + "' )");
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
            
            
        }

        private void item1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = SendToSuperVisor;
        }

        private void txtAgency_TextChanged(object sender, EventArgs e)
        {
            String agencyField = txtAgency.Text;
            txtPAgency.Text = agencyField;
        }

        private void txtReportNo_TextChanged(object sender, EventArgs e)
        {
            String ReportNoField = txtReportNo.Text;
            txtPReportNo.Text = ReportNoField;
        }

        private void txtSupplementNo_TextChanged(object sender, EventArgs e)
        {
            String SupplementNoField = txtSupplementNo.Text;
            txtPSupplementNo.Text = SupplementNoField;
        }

        private void txtReportedDate_ValueChanged(object sender, EventArgs e)
        {
            String ReportedDateField = txtReportedDate.Text;
            txtPReportedDate.Text = ReportedDateField;
        }


        private void startNewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //int ranNumber = random.Next(0, 100000);
            txtReportedDate.Text = DateTime.Now.ToShortDateString();
            txtPReportedDate.Text = txtReportedDate.Text;
            txtReportedTime.Text =  DateTime.Now.ToShortTimeString();
            txtRCStatusTime.Text = DateTime.Now.ToShortTimeString();
            
            
            
            //txtReportNo.Text = autoReportNumber;

            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Incident(ReportNumber,ClientEID) VALUES('newReport', '" + txtUsernamePass.Text + "' )");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {
                //String baseReportNumber = "0000";
                //String autoReportNumber = DateTime.Now.ToString("yyyy") + "-";
                //Load Fields from Database Search
                //txtReportNo.Text = autoReportNumber + reader["id"];
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

            lblSearchReportNo.Visible = false;
            txtSearchReport.Visible = false;
            txtSearchReport.Text = "";
            btnSearchForReport.Visible = false;
            btnUpdateReport.Visible = true;
            lblUpdateReport.Visible = true;
            btnUpdateReport.Enabled = true;
            lblUpdateReport.Enabled = true;
            btnCloseReport.Visible = true;
            lblCloseReport.Visible = true;
            mainTabControl.Enabled = true;
            mainTabControl.SelectTab("Incident");
            mnuSendtoSupervisor.Enabled = true;
            cmdmnuIncident.Enabled = true;
            cmdmnuPersons.Enabled = true;
            cmdmnuNarrative.Enabled = true;
            cmdmnuSendToSupervisor.Enabled = true;
            txtIEIDNo.Text = txtUsernamePass.Text;
            txtAgency.Text = "BRP";
            txtAgency.Enabled = false;
            txtReportedDate.Enabled = false;

            MySqlConnection conSelect = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmdSelect = new MySqlCommand("Select id FROM Incident WHERE ReportNumber = 'newReport'");
            cmdSelect.Connection = conSelect;

            conSelect.Open();

            MySqlDataReader readerSelect = cmdSelect.ExecuteReader();
            if (readerSelect.Read() != false)
            {
                //String baseReportNumber = "0000";
                String autoReportNumber = DateTime.Now.ToString("yyyy") + "-";
                //Load Fields from Database Search
                txtReportNo.Text = autoReportNumber + readerSelect["id"];
                if (readerSelect.IsDBNull(0) == true)
                {

                    cmdSelect.Connection.Close();
                    readerSelect.Dispose();
                    cmdSelect.Dispose();
                    //return false;
                }
                else
                {
                    cmdSelect.Connection.Close();
                    readerSelect.Dispose();
                    cmdSelect.Dispose();
                    //return true;
                }
            }
            else
            {
                //return false;
            }


            //Update ReportNumber
            MySqlConnection conUpdate = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmdUpdate = new MySqlCommand("UPDATE Incident Set ReportNumber = '" + txtReportNo.Text + "' Where ReportNumber = 'newReport' AND ClientEID = '" + txtUsernamePass.Text + "'");
            cmdUpdate.Connection = conUpdate;

            conUpdate.Open();

            MySqlDataReader readerUpdate = cmdUpdate.ExecuteReader();
            if (readerUpdate.Read() != false)
            {
                //String baseReportNumber = "0000";
                //String autoReportNumber = DateTime.Now.ToString("yyyy") + "-";
                //Load Fields from Database Search
                //txtReportNo.Text = autoReportNumber + readerSelect["id"];
                if (readerUpdate.IsDBNull(0) == true)
                {

                    cmdUpdate.Connection.Close();
                    readerUpdate.Dispose();
                    cmdUpdate.Dispose();
                    //return false;
                }
                else
                {
                    cmdUpdate.Connection.Close();
                    readerUpdate.Dispose();
                    cmdUpdate.Dispose();
                    //return true;
                }
            }
            else
            {
                //return false;
            }
            




            
        }

        private void btnUpdateReport_Click(object sender, EventArgs e)
        {
            if (image1LocationTextBox.Text != "")
            {
                Upload("ftp://test.brprotective.com/brpclientpictures/", "blackraptor", "Aa3969889!", @image1LocationTextBox.Text);
            }
            if (image2LocationTextBox.Text != "")
            {
                Upload("ftp://test.brprotective.com/brpclientpictures/", "blackraptor", "Aa3969889!", @image2LocationTextBox.Text);
            }
                    
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("UPDATE Incident Set Agency = '" + txtAgency.Text + "', SupplementNumber = '" + txtSupplementNo.Text
                                              + "', ReportedDate = '" + txtReportedDate.Text + "', ReportedTime = '" + txtReportedTime.Text 
                                              + "', CADCallNumber = '" + txtCADCallNo.Text + "', Status = '" + txtStatus.Text
                                              + "', NatureOfCall = '" + txtNatureofCall.Text + "', PropertyId = '" + cmboPropertyId.Text 
                                              + "', UnitNumber = '" + txtUnitNumber.Text + "', City = '" + txtCity.Text 
                                              + "', ZipCode = '" + txtZipCode.Text + "', RepDist = '" + txtRepDist.Text 
                                              + "', Beat = '" + txtBeat.Text + "', Area = '" + txtArea.Text 
                                              + "', FromDate = '" + txtFromDate.Text + "', FromTime = '" + txtFromTime.Text 
                                              + "', ToDate = '" + txtToDate.Text + "', Officer = '" + txtOfficer.Text 
                                              + "', Assignment = '" + txtAssignment.Text + "', Confidential = '" + chkbxConfidential.Checked 
                                              + "', CmdrRpt = '" + chkbxCmdrRpt.Checked + "', EnteredBy = '" + txtEnteredby.Text 
                                              + "', EnteredBy2 = '" + txtAssignmentCopy.Text + "', ReviewOfficer = '" + txtReviewOfficer.Text 
                                              + "', RCStatus = '" + txtRCStatus.Text + "', RCStatusDate = '" + txtRCStatusDate.Text 
                                              + "', RCStatusTime = '" + txtRCStatusTime.Text + "', ExtraToReport = '" + rtxtExtratoReport.Text 
                                              + "', PInvolvement = '" + txtPInvolvement.Text + "', PInvolvementNumber = '" + txtPInvlNo.Text
                                              + "', PType = '" + txtPType.Text + "', PName = '" + txtPName.Text + "', PMini = '" + txtPMNI.Text
                                              + "', PRace = '" + txtPRace.Text + "', PSex = '" + txtPSex.Text + "', PDOB = '" + txtPDOB.Text 
                                              + "', PAge = '" + txtPAge.Text + "', PToAge = '" + txtPToAge.Text + "', 2ndOfficer = '" + txt2ndOfficer.Text + "', ToTime = '" + txtToTime.Text + "', 2ndAssignment = '" + txt2ndAssignment.Text + "', PJuvenile = '" + txtPJuvenile.Text 
                                              + "', PHeight = '" + txtPHeight.Text + "', PToHeight = '" + txtPToHeight.Text + "', ToTime = '" + txtToTime.Text + "', PWeight = '" + txtPWeight.Text
                                              + "', PToWeight = '" + txtPToWeight.Text + "', PHairColor = '" + txtPHairColor.Text + "', PEyeColor = '" + txtPEyeColor.Text 
                                              + "', PSkin = '" + txtPSkin.Text + "', PEthnicity = '" + txtPEthnicity.Text + "', PConfidential = '" + chkbxPConfidential.Checked 
                                              + "', PMeansOfAttack = '" + txtPMeansofAttack.Text + "', PExtentOfInjury = '" + txtPExtentOfInjury.Text + "', PDomViolence = '" + txtPDomViolence.Text
                                              + "', PRelationToOffender = '" + txtPRelationtoOffender.Text + "', PPlaceOfBirth = '" + txtPDOB.Text + "', firstPicUpload = 'ftp://test.brprotective.com/brpclientpictures/" + image1LocationTextBox.Text + "', secondPicUpload = 'ftp://test.brprotective.com/brpclientpictures/" + image2LocationTextBox.Text + "',  NNarative = '" + rtxtNarrative.Text + "' WHERE ReportNumber = '" + txtReportNo.Text + "' ");
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
            MessageBox.Show(" - Report Updated - ", "Report");
            
        }

        

        private void reportNoByClientEIDNoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.incidentTableAdapter1.ReportNoByClientEIDNo(this.sql29409DataSet1.Incident);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clientEIDNoToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void item1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSearchReportNo.Visible = true;
            txtSearchReport.Visible = true;
            btnSearchForReport.Visible = true;

        }

        private void btnSearchForReport_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Incident WHERE ReportNumber = '" + txtSearchReport.Text + "' ");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {
                //Enable the Client Main Section
                mainTabControl.Enabled = true;
                mainTabControl.SelectTab("Incident");
                mnuSendtoSupervisor.Enabled = true;
                btnCloseReport.Visible = true;
                lblCloseReport.Visible = true;
                btnUpdateReport.Visible = true;
                lblUpdateReport.Visible = true;
                btnUpdateReport.Enabled = true;
                lblUpdateReport.Enabled = true;
                cmdmnuIncident.Enabled = true;
                cmdmnuPersons.Enabled = true;
                cmdmnuNarrative.Enabled = true;
                cmdmnuSendToSupervisor.Enabled = true;

                //Load Fields from Database Search
                txtAgency.Text = "" + reader["Agency"];
                txtReportNo.Text = "" + reader["ReportNumber"];
                txtSupplementNo.Text = "" + reader["SupplementNumber"];
                txtReportedDate.Text = "" + reader["ReportedDate"];
                txtReportedTime.Text = "" + reader["ReportedTime"];
                txtCADCallNo.Text = "" + reader["CADCallNumber"];
                txtStatus.Text = "" + reader["Status"];
                txtNatureofCall.Text = "" + reader["NatureOfCall"];
                cmboPropertyId.Text = "" + reader["PropertyId"];
                txtUnitNumber.Text = "" + reader["UnitNumber"];
                txtIEIDNo.Text = txtUsernamePass.Text;
                txtCity.Text = "" + reader["City"];
                txtZipCode.Text = "" + reader["ZIPCode"];
                txtRepDist.Text = "" + reader["RepDist"];
                txtBeat.Text = "" + reader["Beat"];
                txtArea.Text = "" + reader["Area"];
                txtFromDate.Text = "" + reader["FromDate"];
                txtFromTime.Text = "" + reader["FromTime"];
                txtToDate.Text = "" + reader["ToDate"];
                txtOfficer.Text = "" + reader["Officer"];
                txtAssignment.Text = "" + reader["Assignment"];
                txt2ndOfficer.Text = "" + reader["2ndOfficer"];
                txt2ndAssignment.Text = "" + reader["2ndAssignment"];
                //chkbxConfidential.CheckState =  reader["Confidential"];
                txtEnteredby.Text = "" + reader["EnteredBy"];
                txtAssignmentCopy.Text = "" + reader["EnteredBy2"];
                txtReviewOfficer.Text = "" + reader["ReviewOfficer"];
                txtRCStatus.Text = "" + reader["RCStatus"];
                txtRCStatusDate.Text = "" + reader["RCStatusDate"];
                txtRCStatusTime.Text = "" + reader["RCStatusTime"];
                rtxtExtratoReport.Text = "" + reader["ExtraToReport"];
                txtPInvolvement.Text = "" + reader["PInvolvement"];
                txtPInvlNo.Text = "" + reader["PInvolvementNumber"];
                txtPType.Text = "" + reader["PType"];
                txtPName.Text = "" + reader["PName"];
                txtPMNI.Text = "" + reader["PMini"];
                txtPRace.Text = "" + reader["PRace"];
                txtPSex.Text = "" + reader["PSex"];
                txtPDOB.Text = "" + reader["PDOB"];
                txtPAge.Text = "" + reader["PAge"];
                txtPToAge.Text = "" + reader["PToAge"];
                txtPJuvenile.Text = "" + reader["PJuvenile"];
                txtPHeight.Text = "" + reader["PHeight"];
                txtPToHeight.Text = "" + reader["PToHeight"];
                txtPWeight.Text = "" + reader["PWeight"];
                txtPToWeight.Text = "" + reader["PToWeight"];
                txtPHairColor.Text = "" + reader["PHairColor"];
                txtPEyeColor.Text = "" + reader["PEyeColor"];
                txtPSkin.Text = "" + reader["PSkin"];
                txtPEthnicity.Text = "" + reader["PEthnicity"];
                //chkbxConfidential
                txtPMeansofAttack.Text = "" + reader["PMeansOfAttack"];
                txtPExtentOfInjury.Text = "" + reader["PExtentOfInjury"];
                txtPDomViolence.Text = "" + reader["PDomViolence"];
                txtPRelationtoOffender.Text = "" + reader["PRelationToOffender"];
                txtPPlaceofBirth.Text = "" + reader["PPlaceOfBirth"];
                rtxtNarrative.Text = "" + reader["NNarative"];
                txtFinalReport.Text = "" + reader["FinalReportVersion"];
                String finalReport = txtFinalReport.Text;
                if (finalReport == "Approved")
                {
                    cmdmnuSendToSupervisor.Visible = false;
                    mnuSendtoSupervisor.Enabled = false;
                    mainTabControl.Enabled = false;
                    lblReportFinalized.Visible = true;
                    btnUpdateReport.Visible = false;
                    lblUpdateReport.Visible = false;
                    btnPrintReport.Visible = true;
                    
                }
                else
                {

                }

                
                txtSearchResults.Text = "found";
                MessageBox.Show("Report Found - Loading Data...", "Search Reports");
                lblSearchReportNo.Visible = false;
                txtSearchReport.Visible = false;
                txtSearchReport.Text = "";
                btnSearchForReport.Visible = false;


                
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
                
                MessageBox.Show("Report Not Found", "Search Reports");
                lblSearchReportNo.Visible = false;
                txtSearchReport.Visible = false;
                txtSearchReport.Text = "";
                btnSearchForReport.Visible = false;
            }

            


            
        }

        private void txtSearchReport_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnCloseReport_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to Close this Report?", "Report", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                btnSubmitReport.Visible = true;
                lblCertainReport.Visible = false;
                lblNoteFinalChanges.Visible = false;
                btnNoCancel.Visible = false;
                btnYesSumbit.Visible = false;
                btnUpdateReport.Visible = false;
                btnUpdateReport.Enabled = false;
                lblUpdateReport.Visible = false;
                btnCloseReport.Visible = false;
                lblCloseReport.Visible = false;
                btnPrintReport.Visible = false;
                

                mainTabControl.SelectTab("Incident");
                IncidentTabControl.SelectTab("Offense");
                mainTabControl.Enabled = false;
                mnuSendtoSupervisor.Enabled = false;
                btnUpdateReport.Enabled = false;
                lblUpdateReport.Enabled = false;
                cmdmnuIncident.Enabled = false;
                cmdmnuPersons.Enabled = false;
                cmdmnuNarrative.Enabled = false;
                cmdmnuSendToSupervisor.Enabled = false;
                cmdmnuSendToSupervisor.Visible = true;
                lblReportFinalized.Visible = false;

                txtAgency.Text = "";
                cmboPPropertyId.Text = "";
                txtReportNo.Text = "";
                txtSupplementNo.Text = "";
                txtReportedDate.Text = "";
                txtReportedTime.Text = "";
                txtCADCallNo.Text = "";
                txtStatus.Text = "";
                txtNatureofCall.Text = "";
                cmboPropertyId.Text = "";
                txtUnitNumber.Text = "";
                txtCity.Text = "";
                txtZipCode.Text = "";
                txtRepDist.Text = "";
                txtBeat.Text = "";
                txtArea.Text = "";
                txtFromDate.Text = "";
                txtFromTime.Text = "";
                txtToDate.Text = "";
                txtOfficer.Text = "";
                txtAssignment.Text = "";
                chkbxConfidential.Checked = false;
                chkbxCmdrRpt.Checked = false;
                txtEnteredby.Text = "";
                txtAssignmentCopy.Text = "";
                txtReviewOfficer.Text = "";
                txtRCStatus.Text = "";
                txtRCStatusDate.Text = "";
                txtRCStatusTime.Text = "";
                rtxtExtratoReport.Text = "";
                txtPInvolvement.Text = "";
                txtPInvlNo.Text = "";
                txtPType.Text = "";
                txtPName.Text = "";
                txtPMNI.Text = "";
                txtPRace.Text = "";
                txtPSex.Text = "";
                txtPDOB.Text = "";
                txtPAge.Text = "";
                txtPToAge.Text = "";
                txtPJuvenile.Text = "";
                txtPHeight.Text = "";
                txtPToHeight.Text = "";
                txtPWeight.Text = "";
                txtPToWeight.Text = "";
                txtPHairColor.Text = "";
                txtPEyeColor.Text = "";
                txtPSkin.Text = "";
                txtPEthnicity.Text = "";
                chkbxPConfidential.Checked = false;
                txtPMeansofAttack.Text = "";
                txtPExtentOfInjury.Text = "";
                txtPDomViolence.Text = "";
                txtPRelationtoOffender.Text = "";
                txtPDOB.Text = "";
                rtxtNarrative.Text = "";
                image1LocationTextBox.Text = "";
                image2LocationTextBox.Text = "";
                picUpload1.ImageLocation = "";
                picUpload2.ImageLocation = "";
                MessageBox.Show("- Report Closed -", "Report");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                
            }
        }

        private void cmdmnuIncident_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectTab("Incident");
            cmdmnuIncident.BackColor = Color.SteelBlue;
            cmdmnuPersons.BackColor = Color.LightSteelBlue;
            cmdmnuNarrative.BackColor = Color.LightSteelBlue;
            cmdmnuSendToSupervisor.BackColor = Color.LightSteelBlue;
        }

        private void cmdmnuPersons_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectTab("Persons");
            cmdmnuIncident.BackColor = Color.LightSteelBlue;
            cmdmnuPersons.BackColor = Color.SteelBlue;
            cmdmnuNarrative.BackColor = Color.LightSteelBlue;
            cmdmnuSendToSupervisor.BackColor = Color.LightSteelBlue;
        }

        private void cmdmnuNarrative_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectTab("Narrative");
            cmdmnuIncident.BackColor = Color.LightSteelBlue;
            cmdmnuPersons.BackColor = Color.LightSteelBlue;
            cmdmnuNarrative.BackColor = Color.SteelBlue;
            cmdmnuSendToSupervisor.BackColor = Color.LightSteelBlue;
        }

        private void cmdmnuSendToSupervisor_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectTab("SendToSupervisor");
            cmdmnuIncident.BackColor = Color.LightSteelBlue;
            cmdmnuPersons.BackColor = Color.LightSteelBlue;
            cmdmnuNarrative.BackColor = Color.LightSteelBlue;
            cmdmnuSendToSupervisor.BackColor = Color.SteelBlue;
        }

        private void cmdmnuIOffense_Click(object sender, EventArgs e)
        {
            IncidentTabControl.SelectTab("Offense");
            cmdmnuIOffense.BackColor = Color.SteelBlue;
            cmdmnuIAttachments.BackColor = Color.LightSteelBlue;
            cmdmnuIExtraToReport.BackColor = Color.LightSteelBlue;
            
        }

        private void cmdmnuIAttachments_Click(object sender, EventArgs e)
        {
            IncidentTabControl.SelectTab("Attachments");
            cmdmnuIOffense.BackColor = Color.LightSteelBlue;
            cmdmnuIAttachments.BackColor = Color.SteelBlue;
            cmdmnuIExtraToReport.BackColor = Color.LightSteelBlue;
           
        }

        private void cmdmnuIExtraToReport_Click(object sender, EventArgs e)
        {
            IncidentTabControl.SelectTab("reportExtra");
            cmdmnuIOffense.BackColor = Color.LightSteelBlue;
            cmdmnuIAttachments.BackColor = Color.LightSteelBlue;
            cmdmnuIExtraToReport.BackColor = Color.SteelBlue;
        }

        private void btnSubmittedReports_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            clientReportStatus reportStatus = new clientReportStatus(txtUsernamePass.Text);
            reportStatus.Show();
        }

        private void cmdCloseProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdMinimizeProgram_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Start ReportViewer application
            //System.Diagnostics.Process.Start("BrpReportViewerControl.exe");
            //OpenNotepad();
            //Process.Start("\\BrpReportViewerControl.exe");
            var startupPath = System.IO.Path.GetDirectoryName(
                       System.Reflection.Assembly.GetEntryAssembly().Location);
            var programPath = System.IO.Path.Combine(startupPath, "BrpReportViewerControl.exe");

            System.Diagnostics.Process.Start(programPath);
        }

        private void OpenNotepad()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "BrpReportViewerControl.exe";
            //startInfo.Arguments = f;
            Process.Start(startInfo);
            
            
            
        }
        static void OpenNotepad(string f)
        {
            
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            lblSearchReportNo.Visible = true;
            txtSearchReport.Visible = true;
            btnSearchForReport.Visible = true;
        }

        private void cmdMinimizeProgram_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmdmnuViewAllUsers_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rtxtNarrative_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmCheckForUpdate brpCheckForUpdate = new frmCheckForUpdate();
            brpCheckForUpdate.Show();
        }

        private void Persons_Click(object sender, EventArgs e)
        {

        }

        private void txtPAgency_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.InitialDirectory = "C:\\";
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //UploadVideo(dlg.FileName, dlg.OpenFile);
                    image2LocationTextBox.Text = dlg.FileName;
                    picUpload2.ImageLocation = dlg.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: can not read file from disk.Original error: " + ex.Message);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.InitialDirectory = "C:\\";
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";
            dlg.FilterIndex = 0;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //UploadVideo(dlg.FileName, dlg.OpenFile);
                    image1LocationTextBox.Text = dlg.FileName;
                    picUpload1.ImageLocation = dlg.FileName;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: can not read file from disk.Original error: " + ex.Message);
                }
            
        }






        }

        private void txtPHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPType_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            //Update report with option to show the ReportViewerControl App
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("UPDATE Incident Set reportviewerprint = '" + txtReportNo.Text + "' WHERE ReportNumber = '" + txtReportNo.Text + "' ");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {
                if (reader.IsDBNull(0) == true)
                {
            //Load BrpReportViewerControl App
            var startupPath = System.IO.Path.GetDirectoryName(
                       System.Reflection.Assembly.GetEntryAssembly().Location);
            var programPath = System.IO.Path.Combine(startupPath, "BrpReportViewerControl.exe");

            System.Diagnostics.Process.Start(programPath);
            //      
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
            //MessageBox.Show(" - Report Updated - ", "Report");
            
        }

        private void attachments_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmboPropertyId_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmboPropertyId_TextUpdate(object sender, EventArgs e)
        {
            cmboPPropertyId.Text = cmboPropertyId.Text;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmBrowser brpBrowser = new frmBrowser();
            brpBrowser.Show();
        }



           
        }

        
    }


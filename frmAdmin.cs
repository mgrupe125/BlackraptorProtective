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
    public partial class frmAdmin : Form
    {
        MySqlCommand myCmdQuery = new MySqlCommand();
        MySqlDataAdapter myDA = new MySqlDataAdapter();
        BindingSource bS = new BindingSource();
        MySqlCommandBuilder myCB = new MySqlCommandBuilder();
        DataSet ds = new DataSet();
        int TogMove;
        int MValX;
        int MValY;

        public frmAdmin(string user_EIDAdmin)
        {
            InitializeComponent();
            txtEIDAdmin.Text = user_EIDAdmin;
        }

        private void btnDeleteUserAccount_Click(object sender, EventArgs e)
        {
            if (cmboConfirmAccountDeletion.Text != "No")
            {
                MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
                MySqlCommand cmd = new MySqlCommand("Delete FROM ClientLogin WHERE clientusername = '" + cmboDeleteUser.Text + "' ");
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
                MessageBox.Show(" - Account Deleted! - ");
                cmboDeleteUser.Text = "";
                cmboConfirmAccountDeletion.Text = "No";
                groupDeleteUsers.Visible = false;

            }
            else
            {
                MessageBox.Show("* Must select Yes to Confirm Account Removal.");




            }
            
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("SELECT ClientEIDNo FROM ClientLogin WHERE clientusername = '" + txtEIDAdmin.Text + "' ");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {
                lblClientEIDNoLoggedIn.Text = "" + reader["ClientEIDNo"];
                txtEIDAdmin.Text = "" + reader["ClientEIDNo"];
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

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp mainAbout = new frmHelp();
            mainAbout.Show();
        }

        private void searchForApprovedReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupAddUser.Visible = true;
            groupDeleteUsers.Visible = false;
            groupChangeRoles.Visible = false;
            groupViewAllUsers.Visible = false;
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupAddUser.Visible = false;
            groupDeleteUsers.Visible = true;
            groupChangeRoles.Visible = false;
            groupViewAllUsers.Visible = false;
        }

        private void changeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupAddUser.Visible = false;
            groupDeleteUsers.Visible = false;
            groupChangeRoles.Visible = true;
            groupViewAllUsers.Visible = false;
        }

        private void viewAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupAddUser.Visible = false;
            groupDeleteUsers.Visible = false;
            groupChangeRoles.Visible = false;
            groupViewAllUsers.Visible = true;
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            //Insert New User
            if (txtUserAdd.Text != "" & txtPasswordAdd.Text != "" & txtEIDAdd.Text != "" & cmboUserAdd.Text != "")
            {
                if (txtConfirmPasswordAdd.Text == txtPasswordAdd.Text)
                {

                    MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO ClientLogin(clientusername, clientpassword, ClientEIDNo, clientRole) VALUES('" + txtUserAdd.Text + "', '" + txtPasswordAdd.Text + "', '" + txtEIDAdd.Text + "', '" + cmboUserAdd.Text + "' )");
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
                    MessageBox.Show(" - New User Account Created! - ");
                    txtUserAdd.Text = "";
                    txtPasswordAdd.Text = "";
                    txtConfirmPasswordAdd.Text = "";
                    txtEIDAdd.Text = "";
                    cmboUserAdd.Text = "Client";
                    groupAddUser.Visible = false;



                }
                else
                {
                    MessageBox.Show(" * Passwords Do Not Match (Please Re-Check) ");
                }


            }
            else
            {
                MessageBox.Show(" * All Fields are Required. ");



            }
        }

        private void btnChangeUserRoles_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViewAllUsers_Click(object sender, EventArgs e)
        {
            



        }

        private void btnViewAllUsersClose_Click(object sender, EventArgs e)
        {
            groupViewAllUsers.Visible = false;
        }

        private void btnDeleteUsersClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- No Changes Made -");
            groupDeleteUsers.Visible = false;
        }

        private void btnChangeUserRolesClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- No Changes Made -");
            groupChangeRoles.Visible = false;
        }

        private void btnCloseAddUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- No Changes Made -");
            groupAddUser.Visible = false;
        }

        private void btnViewAllUsers_Click_1(object sender, EventArgs e)
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

            grdViewUserAccounts.DataSource = bS;
            //bNMember.BindingSource = bS;
        }

        private void btnChangeUserRoles_Click_1(object sender, EventArgs e)
        {
            if (cmboChangeUserRole.Text != "")
            {
                MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
                MySqlCommand cmd = new MySqlCommand("UPDATE ClientLogin Set clientRole = '" + cmboChangeUserRole.Text + "' WHERE clientusername = '" + cmboEmpChangeRoles.Text + "' ");


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
                MessageBox.Show(" - User Account Role Changed! - ", "Administrator");
                cmboEmpChangeRoles.Text = "";
                cmboChangeUserRole.Text = "";
                groupChangeRoles.Visible = false;

            }
            else
            {
                MessageBox.Show("* Must select either option to Change Role.");
            }
        }

        private void btnUserAdd_Click_1(object sender, EventArgs e)
        {
            if (txtUserAdd.Text != "" & txtPasswordAdd.Text != "" & txtEIDAdd.Text != "" & cmboUserAdd.Text != "")
            {
                if (txtConfirmPasswordAdd.Text == txtPasswordAdd.Text)
                {

                    MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO ClientLogin(clientusername, clientpassword, ClientEIDNo, clientRole, LastName, FirstName, MiddleInitial, Social, Race, Sex, StreetAddress, City, State, Zip, HomePhone, CellPhone, Height, HairColor, EyeColor, MartialStatus, DOB, DriversLicenseNumber, ExpirationDate) VALUES('" + txtUserAdd.Text + "', '" + txtPasswordAdd.Text + "', '" + txtEIDAdd.Text + "', '" + cmboUserAdd.Text + "', '" + txtEmpAddLast.Text + "', '" + txtEmpAddFirst.Text + "', '" + txtEmpAddMiddleInitial.Text + "', '" + txtEmpAddSocial.Text + "', '" + txtEmpAddRace.Text + "', '" + txtEmpAddSex.Text + "', '" + txtEmpAddStreetAddress.Text + "', '" + txtEmpAddCity.Text + "', '" + txtEmpAddState.Text + "', '" + txtEmpAddZip.Text + "', '" + txtEmpAddHomePhone.Text + "', '" + txtEmpAddCellPhone.Text + "', '" + txtEmpAddHeight.Text + "', '" + txtEmpAddHairColor.Text + "', '" + txtEmpAddEyeColor.Text + "', '" + cmboEmpAddMaritalStatus.Text + "', '" + txtEmpAddDOB.Text + "', '" + txtEmpAddDriversLicense.Text + "', '" + txtEmpAddDLExpirationDate.Text + "'  )");
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
                    MessageBox.Show(" - New User Account Created! - ", "Administrator");
                    txtUserAdd.Text = "";
                    txtPasswordAdd.Text = "";
                    txtConfirmPasswordAdd.Text = "";
                    txtEIDAdd.Text = "";
                    cmboUserAdd.Text = "Client";
                    groupAddUser.Visible = false;



                }
                else
                {
                    MessageBox.Show(" * Passwords Do Not Match (Please Re-Check) ");
                }


            }
            else
            {
                MessageBox.Show(" * All Fields are Required. ");



            }
        }

        private void btnDeleteUserAccount_Click_1(object sender, EventArgs e)
        {
            if (cmboConfirmAccountDeletion.Text != "No")
            {
                MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
                MySqlCommand cmd = new MySqlCommand("Delete FROM ClientLogin WHERE clientusername = '" + cmboDeleteUser.Text + "' ");
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
                MessageBox.Show(" - Account Deleted! - ", "Administrator");
                cmboDeleteUser.Text = "";
                cmboConfirmAccountDeletion.Text = "No";
                groupDeleteUsers.Visible = false;

            }
            else
            {
                MessageBox.Show("* Must select Yes to Confirm Account Removal.");




            }
        }

        private void cmdmnuNarrative_Click(object sender, EventArgs e)
        {

        }

        private void cmdmnuPersons_Click(object sender, EventArgs e)
        {

        }

        private void cmdmnuIncident_Click(object sender, EventArgs e)
        {

        }

        private void cmdmnuViewAllUsers_Click(object sender, EventArgs e)
        {
            adminTabControl.SelectTab("viewallusers");
            cmdmnuViewAllUsers.BackColor = Color.SteelBlue;
            cmdmnuChangeUserRoles.BackColor = Color.LightSteelBlue;
            cmdmnuAddNewUsers.BackColor = Color.LightSteelBlue;
            cmdmnuDeleteUsers.BackColor = Color.LightSteelBlue;
        }

        private void cmdmnuChangeUserRoles_Click(object sender, EventArgs e)
        {
            adminTabControl.SelectTab("changeuserroles");
            cmdmnuViewAllUsers.BackColor = Color.LightSteelBlue;
            cmdmnuChangeUserRoles.BackColor = Color.SteelBlue;
            cmdmnuAddNewUsers.BackColor = Color.LightSteelBlue;
            cmdmnuDeleteUsers.BackColor = Color.LightSteelBlue;
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


            myCmdQuery.CommandText = "SELECT clientusername FROM ClientLogin";
            myCmdQuery.CommandType = CommandType.Text;
            myCmdQuery.Connection = myconnection;


            myDA.SelectCommand = myCmdQuery;


            myCB.DataAdapter = myDA;

            //fill the dataset
            myDA.Fill(ds, "member");
            bS.DataSource = ds;
            bS.DataMember = "member";

            cmboSelectEmployee.DataSource = bS;
            //bNMember.BindingSource = bS;

            

        }

        private void cmdmnuAddNewUsers_Click(object sender, EventArgs e)
        {
            adminTabControl.SelectTab("addnewusers");
            cmdmnuViewAllUsers.BackColor = Color.LightSteelBlue;
            cmdmnuChangeUserRoles.BackColor = Color.LightSteelBlue;
            cmdmnuAddNewUsers.BackColor = Color.SteelBlue;
            cmdmnuDeleteUsers.BackColor = Color.LightSteelBlue;
        }

        private void cmdmnuDeleteUsers_Click(object sender, EventArgs e)
        {
            adminTabControl.SelectTab("deleteusers");
            cmdmnuViewAllUsers.BackColor = Color.LightSteelBlue;
            cmdmnuChangeUserRoles.BackColor = Color.LightSteelBlue;
            cmdmnuAddNewUsers.BackColor = Color.LightSteelBlue;
            cmdmnuDeleteUsers.BackColor = Color.SteelBlue;
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


            myCmdQuery.CommandText = "SELECT clientusername FROM ClientLogin";
            myCmdQuery.CommandType = CommandType.Text;
            myCmdQuery.Connection = myconnection;


            myDA.SelectCommand = myCmdQuery;


            myCB.DataAdapter = myDA;

            //fill the dataset
            myDA.Fill(ds, "member");
            bS.DataSource = ds;
            bS.DataMember = "member";

            cmboDeleteUser.DataSource = bS;
            //bNMember.BindingSource = bS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdMinimizeProgram_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void employeeInfo_Click(object sender, EventArgs e)
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


            myCmdQuery.CommandText = "SELECT clientusername FROM ClientLogin";
            myCmdQuery.CommandType = CommandType.Text;
            myCmdQuery.Connection = myconnection;


            myDA.SelectCommand = myCmdQuery;


            myCB.DataAdapter = myDA;

            //fill the dataset
            myDA.Fill(ds, "member");
            bS.DataSource = ds;
            bS.DataMember = "member";

            cmboSelectEmployee.DataSource = bS;
            //bNMember.BindingSource = bS;
            
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdmnuEmployeeInfo_Click(object sender, EventArgs e)
        {
            employeeTabControl.SelectTab("employeeInfo");
            cmdmnuEmployeeInfo.BackColor = Color.SteelBlue;
            cmdmnuChangeEmployeeRole.BackColor = Color.LightSteelBlue;
            cmdUpdateEmployee.BackColor = Color.LightSteelBlue;
            
        }

        private void cmdmnuChangeEmployeeRole_Click(object sender, EventArgs e)
        {
            employeeTabControl.SelectTab("changeEmployeeRole");
            cmdmnuEmployeeInfo.BackColor = Color.LightSteelBlue;
            cmdmnuChangeEmployeeRole.BackColor = Color.SteelBlue;
            cmdUpdateEmployee.BackColor = Color.LightSteelBlue;
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


            myCmdQuery.CommandText = "SELECT clientusername FROM ClientLogin";
            myCmdQuery.CommandType = CommandType.Text;
            myCmdQuery.Connection = myconnection;


            myDA.SelectCommand = myCmdQuery;


            myCB.DataAdapter = myDA;

            //fill the dataset
            myDA.Fill(ds, "member");
            bS.DataSource = ds;
            bS.DataMember = "member";

            cmboEmpChangeRoles.DataSource = bS;
            //bNMember.BindingSource = bS;


           
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
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

        private void cmdMinimizeProgram_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void changeuserroles_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeUserRoles_Click_2(object sender, EventArgs e)
        {
            if (cmboEmpChangeRoles.Text != "")
            {
                MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
                MySqlCommand cmd = new MySqlCommand("UPDATE ClientLogin Set clientRole = '" + cmboChangeUserRole.Text + "' WHERE clientusername = '" + cmboEmpChangeRoles.Text + "' ");


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
                MessageBox.Show(" - User Account Role Changed! - ", "Administrator");
                cmboEmpChangeRoles.Text = "";
                cmboChangeUserRole.Text = "";
                groupChangeRoles.Visible = false;

            }
            else
            {
                MessageBox.Show("* Must select either option to Change Role.");
            }












        }

        private void cmboSelectEmployee_TextUpdate(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Update Employee Fields
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ClientLogin WHERE clientusername = '" + cmboSelectEmployee.Text + "' ");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {
                
                //List of Employee Fields to Update
                txtEmpLastName.Text = "" + reader["LastName"];
                txtEmpFirstName.Text = "" + reader["FirstName"];
                txtEmpMiddleInitial.Text = "" + reader["MiddleInitial"];
                txtEmpSocial.Text = "" + reader["Social"];
                txtEmpRace.Text = "" + reader["Race"];
                txtEmpSex.Text = "" + reader["Sex"];
                txtEmpStreetAddress.Text = "" + reader["StreetAddress"];
                txtEmpCity.Text = "" + reader["City"];
                txtEmpState.Text = "" + reader["State"];
                txtEmpZip.Text = "" + reader["Zip"];
                txtEmpHomePhone.Text = "" + reader["HomePhone"];
                txtEmpCellPhone.Text = "" + reader["CellPhone"];
                txtEmpHeight.Text = "" + reader["Height"];
                txtEmpHairColor.Text = "" + reader["HairColor"];
                txtEmpEyeColor.Text = "" + reader["EyeColor"];
                cmboMaritalStatus.Text = "" + reader["MartialStatus"];
                txtEmpDOB.Text = "" + reader["DOB"];
                txtEmpDriversLicense.Text = "" + reader["DriversLicenseNumber"];
                txtEmpDLExpirationDate.Text = "" + reader["ExpirationDate"];


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

        private void txtEmpAddHomePhone_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtEmpStreetAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpAddMiddleInitial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpAddHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdUpdateEmployee_Click(object sender, EventArgs e)
        {
            employeeTabControl.SelectTab("updateEmployee");
            cmdmnuEmployeeInfo.BackColor = Color.LightSteelBlue;
            cmdmnuChangeEmployeeRole.BackColor = Color.LightSteelBlue;
            cmdUpdateEmployee.BackColor = Color.SteelBlue;
            adminTabControl.SelectTab("changeuserroles");
            cmdmnuViewAllUsers.BackColor = Color.LightSteelBlue;
            cmdmnuChangeUserRoles.BackColor = Color.SteelBlue;
            cmdmnuAddNewUsers.BackColor = Color.LightSteelBlue;
            cmdmnuDeleteUsers.BackColor = Color.LightSteelBlue;
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


            myCmdQuery.CommandText = "SELECT clientusername FROM ClientLogin";
            myCmdQuery.CommandType = CommandType.Text;
            myCmdQuery.Connection = myconnection;


            myDA.SelectCommand = myCmdQuery;


            myCB.DataAdapter = myDA;

            //fill the dataset
            myDA.Fill(ds, "member");
            bS.DataSource = ds;
            bS.DataMember = "member";

            cmboUpdateSelectEmployee.DataSource = bS;
            //bNMember.BindingSource = bS;

            
            
        }

        private void changeEmployeeRole_Click(object sender, EventArgs e)
        {

        }

        private void updateEmployee_Click(object sender, EventArgs e)
        {

        }

        private void cmdUpdateShowEmployee_Click(object sender, EventArgs e)
        {
            //Update Employee Fields
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ClientLogin WHERE clientusername = '" + cmboUpdateSelectEmployee.Text + "' ");
            cmd.Connection = con;

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() != false)
            {

                //List of Employee Fields to Update
                txtEmpUpdateLast.Text = "" + reader["LastName"];
                txtEmpUpdateFirst.Text = "" + reader["FirstName"];
                txtEmpUpdateMiddleInitial.Text = "" + reader["MiddleInitial"];
                txtEmpUpdateSocial.Text = "" + reader["Social"];
                txtEmpUpdateRace.Text = "" + reader["Race"];
                txtEmpUpdateSex.Text = "" + reader["Sex"];
                txtEmpUpdateStreetAddress.Text = "" + reader["StreetAddress"];
                txtEmpUpdateCity.Text = "" + reader["City"];
                txtEmpUpdateState.Text = "" + reader["State"];
                txtEmpUpdateZip.Text = "" + reader["Zip"];
                txtEmpUpdateHomePhone.Text = "" + reader["HomePhone"];
                txtEmpUpdateCellPhone.Text = "" + reader["CellPhone"];
                txtEmpUpdateHeight.Text = "" + reader["Height"];
                txtEmpUpdateHairColor.Text = "" + reader["HairColor"];
                txtEmpUpdateEyeColor.Text = "" + reader["EyeColor"];
                cmboEmpUpdateMaritalStatus.Text = "" + reader["MartialStatus"];
                txtEmpUpdateDOB.Text = "" + reader["DOB"];
                txtEmpUpdateDriversLicense.Text = "" + reader["DriversLicenseNumber"];
                txtEmpUpdateDLExpirationDate.Text = "" + reader["ExpirationDate"];


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

        private void button2_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server=sql29409.db.10825756.hostedresource.com;Database=sql29409;Uid=sql29409;Pwd=Aa3969889!;");
            MySqlCommand cmd = new MySqlCommand("UPDATE ClientLogin Set LastName = '" + txtEmpUpdateLast.Text + "', FirstName = '" + txtEmpUpdateFirst.Text + "', MiddleInitial = '" + txtEmpUpdateMiddleInitial.Text + "', Social = '" + txtEmpUpdateSocial.Text + "', Race = '" + txtEmpUpdateRace.Text + "', Sex = '" + txtEmpUpdateSex.Text + "', StreetAddress = '" + txtEmpUpdateStreetAddress.Text + "', City = '" + txtEmpUpdateCity.Text + "', State = '" + txtEmpUpdateState.Text + "', Zip = '" + txtEmpUpdateZip.Text + "', HomePhone = '" + txtEmpUpdateHomePhone.Text + "', CellPhone = '" + txtEmpUpdateCellPhone.Text + "', Height = '" + txtEmpUpdateHeight.Text + "', HairColor = '" + txtEmpUpdateHairColor.Text + "', EyeColor = '" + txtEmpUpdateEyeColor.Text + "', MartialStatus = '" + cmboEmpUpdateMaritalStatus.Text + "', DOB = '" + txtEmpUpdateDOB.Text + "', DriversLicenseNumber = '" + txtEmpUpdateDriversLicense.Text + "', ExpirationDate = '" + txtEmpUpdateDLExpirationDate.Text + "' WHERE clientusername = '" + cmboUpdateSelectEmployee.Text + "' ");


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
                MessageBox.Show("Employee Successfully Updated!", "Administrator");
                //return false;
            }
            
                
        }
        }
    }


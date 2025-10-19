using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Lanka_Toys_Employee
{
    public partial class DashBoard_Form : Form
    {
        public DashBoard_Form()
        {
            InitializeComponent();

            // Greet the user based on the current hour
            if (int.Parse(Login_Form.Hour) >= 5 && int.Parse(Login_Form.Hour) < 12)
            {
                lbl_AdminGreeting.Text = "Good Morning! It's nice meet you " + Login_Form.EmployeeName;
            }
            else if (int.Parse(Login_Form.Hour) >= 12 && int.Parse(Login_Form.Hour) < 16)
            {
                lbl_AdminGreeting.Text = "Good Afternoon! It's nice meet you " + Login_Form.EmployeeName;
            }
            else if (int.Parse(Login_Form.Hour) > 16 && int.Parse(Login_Form.Hour) < 19)
            {
                lbl_AdminGreeting.Text = "Good Evening! It's nice meet you " + Login_Form.EmployeeName;
            }
            else
            {
                lbl_AdminGreeting.Text = "         Hi! It's nice meet you " + Login_Form.EmployeeName;
            }

            // Display the last login time
            lbl_AccessedTime.Text = "Last time you Logged in " + Login_Form.Time;

        }

        //Dashboard button click
        private void Btn_Dashoard_Click(object sender, EventArgs e)
        {
            this.Form_Loader.Controls.Clear(); // Clear the current controls
            DashBoard_Profile_Form DashBoard_Profile_Form_New = new DashBoard_Profile_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; // Create a new profile form
            DashBoard_Profile_Form_New.FormBorderStyle = FormBorderStyle.None; // Set form border style
            this.Form_Loader.Controls.Add(DashBoard_Profile_Form_New); // Add the new form to the loader panel
            DashBoard_Profile_Form_New.Show(); // Show the new form

        }

        //the Close button click
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Exit the application
            }

        }

        //the Minimize button click
        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; // Minimize the form
        }

         //the Sign Out button click event
        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            Login_Form SignUp_Page = new Login_Form(); // Create a new login form

            var result = MessageBox.Show("Are you sure, Do you really need to Sign Out....?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the current form
                SignUp_Page.Show(); // Show the login form
            }
        }

        //the Add Member button click event
        private void Btn_AddMember_Click(object sender, EventArgs e)
        {
            AddMember_Form AddMember = new AddMember_Form(); // Create a new add member form
            AddMember.Show(); // Show the add member form

        }

        //the Management Menu button click event
        private void Btn_Management_Menu_Click(object sender, EventArgs e)
        {
            this.Form_Loader.Controls.Clear(); // Clear the current controls
            Management_Form Management_Form_New = new Management_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; // Create a new management form
            Management_Form_New.FormBorderStyle = FormBorderStyle.None; // Set form border style
            this.Form_Loader.Controls.Add(Management_Form_New); // Add the new form to the loader panel
            Management_Form_New.Show(); // Show the new form

        }

        //the Report Menu button click event
        private void Btn_Report_Menu_Click(object sender, EventArgs e)
        {
            this.Form_Loader.Controls.Clear(); // Clear the current controls
            Report_Form Report_Form_New = new Report_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; // Create a new report form
            Report_Form_New.FormBorderStyle = FormBorderStyle.None; // Set form border style
            this.Form_Loader.Controls.Add(Report_Form_New); // Add the new form to the loader panel
            Report_Form_New.Show(); // Show the new form

        }
    }
}

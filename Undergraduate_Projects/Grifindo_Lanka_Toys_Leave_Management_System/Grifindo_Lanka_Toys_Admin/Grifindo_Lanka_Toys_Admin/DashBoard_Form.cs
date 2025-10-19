using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Lanka_Toys_Admin
{
    public partial class DashBoard_Form : Form
    {
        public DashBoard_Form()
        {
            InitializeComponent();
            //To move the border
            //Form_Border.MouseDown += (sender, e) => { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } };

            //greeting message based on the current time (hour)
            if (int.Parse(Login_Form.Hour) >= 5 && int.Parse(Login_Form.Hour) < 12)
            {
                lbl_AdminGreeting.Text = "Good Morning! It's nice meet you " + Login_Form.AdminName;
            }
            else if (int.Parse(Login_Form.Hour) >= 12 && int.Parse(Login_Form.Hour) < 16)
            {
                lbl_AdminGreeting.Text = "Good Afternoon! It's nice meet you " + Login_Form.AdminName;
            }
            else if (int.Parse(Login_Form.Hour) > 16 && int.Parse(Login_Form.Hour) < 19)
            {
                lbl_AdminGreeting.Text = "Good Evening! It's nice meet you " + Login_Form.AdminName;
            }
            else
            {
                lbl_AdminGreeting.Text = "         Hi! It's nice meet you " + Login_Form.AdminName;
            }
            // Display the last login time
            lbl_AccessedTime.Text = "Last time you Logged in " + Login_Form.Time;

        }

        //Close button click
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            // Confirm if the user wants to exit the application
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Close the application
            }
        }

        //Minimize button click
        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Add Member button click
        private void Btn_AddMember_Click(object sender, EventArgs e)
        {
            AddMember_Form AddMember = new AddMember_Form();
            AddMember.Show(); // Show the Add Member form
        }

        // Sign Out button click
        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            Login_Form SignUp_Page = new Login_Form();

            // To confirm if the user wants to sign out
            var result = MessageBox.Show("Are you sure, Do you really need to Sign Out....?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the current form
                SignUp_Page.Show(); // Show the login form
            }
        }

        // Event handler for the Dashboard button click
        private void Btn_Dashoard_Click(object sender, EventArgs e)
        {
            // Loading the dashboard profile form in the Form Loader panel
            this.Form_Loader.Controls.Clear();
            DashBoard_Profile_Form DashBoard_Profile_Form_New = new DashBoard_Profile_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DashBoard_Profile_Form_New.FormBorderStyle = FormBorderStyle.None;
            this.Form_Loader.Controls.Add(DashBoard_Profile_Form_New);
            DashBoard_Profile_Form_New.Show();
        }

        // Event handler for the Management Menu button click
        private void Btn_Management_Menu_Click(object sender, EventArgs e)
        {
            // Loading the management form in the Form Loader panel
            this.Form_Loader.Controls.Clear();
            Management_Form Management_Form_Vrb = new Management_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Management_Form_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Form_Loader.Controls.Add(Management_Form_Vrb);
            Management_Form_Vrb.Show();

        }

        // Event handler for the Report Menu button click
        private void Btn_Report_Menu_Click(object sender, EventArgs e)
        {
            // Loading the report form in the Form Loader panel
            this.Form_Loader.Controls.Clear();
            Report_Form Report_Form_New = new Report_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Report_Form_New.FormBorderStyle = FormBorderStyle.None;
            this.Form_Loader.Controls.Add(Report_Form_New);
            Report_Form_New.Show();

        }
    }
}

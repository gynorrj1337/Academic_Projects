using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Grifindo_Lanka_Toys_Employee
{
    public partial class Login_Form : Form
    {

        // Static variables for global use [for using it in make forms]
        public static string EmployeeName;
        public static string Time;
        public static string Hour;
        public static string connectionString = @"Data Source=Code-Maestro; Initial Catalog = Grifindo_Lanka_Toys; Integrated Security=True;";
        public static string EmployeeID;

        public Login_Form()
        {
            InitializeComponent();
        }

        //Clear button click event
        private void lbl_Clear_Click(object sender, EventArgs e)
        {
            txt_EmployeeID.Clear(); // Clear the Employee ID text box
            txt_Password.Clear(); // Clear the Password text box
            txt_EmployeeID.Focus(); // Set focus to the Employee ID text box

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Exit the application
            }

        }

        //Show button click event to reveal the password
        private void btn_Show_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = false; // Show the password
            btn_Hide.BringToFront(); // Bring the Hide button to the front
        }

        // Handle the Hide button click event to Hide the password
        private void btn_Hide_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true; // Hide the password
            btn_Show.BringToFront(); // Bring the Show button to the front
        }

        //Sign In button click event
        private void btn_SignIn_Click(object sender, EventArgs e)
        {

            string Entered_Display_Name = txt_EmployeeID.Text; // Get entered Employee ID
            string Entered_Password = txt_Password.Text; // Get entered Password
            SqlConnection Connect = new SqlConnection(connectionString); // Create SQL connection
            Connect.Open(); // Open the SQL connection
            // Query to fetch employee record matching the entered ID and password
            string search_query = "SELECT * from Employee WHERE Employee_ID = '" + Entered_Display_Name + "' AND Password COLLATE SQL_Latin1_General_CP1_CS_AS = '" + Entered_Password + "'";
            SqlCommand Fetch = new SqlCommand(search_query, Connect);
            SqlDataReader row = Fetch.ExecuteReader(); // Execute the query



            if (row.HasRows) //If credentials are Correct
            {
                row.Read();
                //To send user name to DashBoard_Form
                string EmployeeFirstName = row["First_Name"].ToString(); // Get employee's first name
                string EmployeeLastName = row["Last_Name"].ToString(); // Get employee's last name
                EmployeeID = row["Employee_ID"].ToString(); // Set EmployeeID
                EmployeeName = EmployeeFirstName; // Set EmployeeName
                DateTime CTime = DateTime.Now; // Get current time
                Time = CTime.ToString("HH:mm:ss"); // Set Time
                Hour = CTime.ToString("HH"); // Set Hour
                this.Hide(); // Hide the login form
                DashBoard_Form Main_Page = new DashBoard_Form(); // Create the dashboard form
                Main_Page.Show(); // Show the dashboard form

            }
            else
            {
                // Shows a message box if the credentials are incorrect
                MessageBox.Show("Invalid Login Credentials, \nPlease Try Again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

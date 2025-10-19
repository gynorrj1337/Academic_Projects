using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Grifindo_Lanka_Toys_Admin
{
    public partial class Login_Form : Form
    {

        public static string AdminName;
        public static string Time;
        public static string Hour;
        public static string connectionString = @"Data Source=Code-Maestro; Initial Catalog = Grifindo_Lanka_Toys; Integrated Security=True;";
        public Login_Form()
        {
            InitializeComponent();
        }

        private void lbl_Clear_Click(object sender, EventArgs e)
        {

            txt_AdminID.Clear();
            txt_Password.Clear();
            txt_AdminID.Focus();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = false;
            btn_Hide.BringToFront();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;
            btn_Show.BringToFront();

        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {

            string Entered_Display_Name = txt_AdminID.Text;
            string Entered_Password = txt_Password.Text;
            SqlConnection Connect = new SqlConnection(@"Data Source=Code-Maestro; Initial Catalog = Grifindo_Lanka_Toys; Integrated Security=True;");
            Connect.Open();
            string search_query = "SELECT * from Admin WHERE Admin_ID = '" + Entered_Display_Name + "' AND Password COLLATE SQL_Latin1_General_CP1_CS_AS = '" + Entered_Password + "'";
            SqlCommand Fetch = new SqlCommand(search_query, Connect);
            SqlDataReader row = Fetch.ExecuteReader();



            if (row.HasRows) //If credentials are Correct
            {
                row.Read();
                //To send user name to DashBoard_Form
                string AdminFirstName = row["First_Name"].ToString();
                string AdminLastName = row["Last_Name"].ToString();
                AdminName = AdminFirstName;
                DateTime CTime = DateTime.Now;
                Time = CTime.ToString("HH:mm:ss");
                Hour = CTime.ToString("HH");
                this.Hide();
                DashBoard_Form Main_Page = new DashBoard_Form();
                Main_Page.Show();
                YearlyLeave_Update();
                MonthlyLeave_Update();

            }
            else
            {
                // Shows a message box if the credentials are wrong
                MessageBox.Show("Invalid Login Credentials, \nPlease Try Again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void YearlyLeave_Update()
        {
            //need to get today's date and time
            // DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;

            //Getting the first day of this year
            DateTime FirstDayofYear = new DateTime(today.Year, 1, 1);

            //calculating difference
            int DayDifference = (today - FirstDayofYear).Days;

            //checking for Leap year
            bool isLeapYear = DateTime.IsLeapYear(today.Year);
            int MaxDayinYear;
            //determining number of days
            if (isLeapYear) { MaxDayinYear = 366; }
            else { MaxDayinYear = 365; }

            

            //checking the day difference and updating
            if (DayDifference > MaxDayinYear)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        // Open the connection
                        connection.Open();
                        SqlCommand command = new SqlCommand("Update Leave_Balance SET Remaining_Annual_Leaves = Initial_Annual_Leaves, Remaining_Casual_Leaves = Initial_Casual_Leaves", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        // Inform the user
                        MessageBox.Show("Annual Leaves and Casual Leaves are Updated", "Update Leaves", MessageBoxButtons.OK);
                    }
                }
                catch (SqlException ex)
                {
                    string message = "Update Error:";
                    message += ex.Message;
                    MessageBox.Show(message);

                }

            }
        }

            private void MonthlyLeave_Update()
            {
                //need to get today's date and time
                DateTime now = DateTime.Now;
                DateTime today = DateTime.Today;

                //Getting the first day of this month
                DateTime FirstDayofMonth = new DateTime(today.Year, today.Month, 1);

                //calculating difference
                int DayDifference = (today - FirstDayofMonth).Days;

                //checking number of days in a month
                 int DaysinMonth = DateTime.DaysInMonth(today.Year, today.Month);

                //checking the day difference and updating
                if (DayDifference > DaysinMonth)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {

                            // Open the connection
                            connection.Open();
                            SqlCommand command = new SqlCommand("Update Leave_Balance SET Remaining_Short_Leaves = Initial_Short_Leaves", connection);
                            command.ExecuteNonQuery();
                            connection.Close();
                            // Inform the user
                            MessageBox.Show("Short Leaves are Updated", "Update Leaves", MessageBoxButtons.OK);
                        }
                    }
                    catch (SqlException ex)
                    {
                        string message = "Update Error:";
                        message += ex.Message;
                        MessageBox.Show(message);

                    }

                }

            }
    }
}

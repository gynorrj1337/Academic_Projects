using Microsoft.Win32;
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

namespace Grifindo_Lanka_Toys_Employee
{
    public partial class Add_Leave_Form : Form
    {
        SqlConnection Connection = new SqlConnection(Login_Form.connectionString);

        public Add_Leave_Form()
        {
            InitializeComponent();
            Location_Change();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_LeaveID.Text = "";
            cmb_LeaveType.Text = "";
            txt_Reason.Clear();
            DateTime CTime = DateTime.Now;
            String Now = CTime.ToString("HH:mm:ss");
            dtp_StartTime.Text = Now;
            dtp_EndTime.Text = Now;
        }

        string Remaining_Days = "0";
        int numberOfDays = 0;
        DateTime startDate = DateTime.Today;
        DateTime endDate = DateTime.Today;
        string todayDate = DateTime.Today.ToString("yyyy-MM-dd");
        string todayTime = DateTime.Today.ToString("yyyy-MM-dd HH:mm");

        private void Remaining_Leave()
        {
            Connection.Open();
            string query = "SELECT * FROM Leave_Balance WHERE (Employee_ID = @Employee_ID)";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.AddWithValue("@Employee_ID", Login_Form.EmployeeID);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        if (cmb_LeaveType.Text == "Annual")
                        {
                            Remaining_Days = reader["Remaining_Annual_Leaves"].ToString();
                        }
                        else if (cmb_LeaveType.Text == "Casual")
                        {
                            Remaining_Days = reader["Remaining_Casual_Leaves"].ToString();
                        }
                        else if (cmb_LeaveType.Text == "Short")
                        {
                            Remaining_Days = reader["Remaining_Short_Leaves"].ToString();
                        }
                        reader.Close();
                    }
                }
            }
            Connection.Close();
        }
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            try
            {


                DateTime ApplicationDate = DateTime.Now;
                string Application_Date = ApplicationDate.ToString("yyyy/MM/dd");
                DateTime shortLeaveStartTime = DateTime.MinValue;
                DateTime shortLeaveEndTime = DateTime.MinValue;

                if (cmb_LeaveType.Text == "Short")
                {
                    DateTime Short_Leave_Date = dtp_LeaveDate.Value.Date;
                    TimeSpan Short_Leave_StartTime = dtp_StartTime.Value.TimeOfDay;
                    TimeSpan Short_Leave_EndTime = dtp_EndTime.Value.TimeOfDay;

                    shortLeaveStartTime = Short_Leave_Date.Add(Short_Leave_StartTime);
                    shortLeaveEndTime = Short_Leave_Date.Add(Short_Leave_EndTime);

                }

                string LeaveStartTime = shortLeaveStartTime.ToString("yyyy/MM/dd HH:mm");
                string LeaveEndTime = shortLeaveEndTime.ToString("yyyy/MM/dd HH:mm");

                if (cmb_LeaveType.Text == "Annual")
                {
                    DateTime today = DateTime.Today;
                    if (dtp_StartTime.Value >= dtp_EndTime.Value)
                    {
                        MessageBox.Show("The annual leave end date must be later than the start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Check if the leave request is at least 7 days in advance
                    if ((dtp_StartTime.Value - today).Days < 7)
                    {
                        MessageBox.Show("Annual leave start date must be requested at least 7 days in advance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                
                    if (cmb_LeaveType.Text == "Casual")
                    {
                        DateTime today = DateTime.Today;
                        if (dtp_StartTime.Value >= dtp_EndTime.Value)
                        {
                        MessageBox.Show("The casual leave end date must be later than the start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        }
                    DateTime today1 = DateTime.Today;

                        // Ensure that the start date for casual leave is in the future
                        if (dtp_StartTime.Value <= today1)
                        {
                            MessageBox.Show("The Casual leave start date must be in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Check if the leave date is before today
                        if (dtp_StartTime.Value < today1)
                        {
                            MessageBox.Show("The leave date must not be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Ensure the number of days is not negative
                        if (numberOfDays < 0)
                        {
                            MessageBox.Show("Number of Days should not be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Check if the number of days requested is less than or equal to the remaining days
                        if (int.Parse(Remaining_Days) < numberOfDays)
                        {
                            MessageBox.Show("Number of Days exceeds Remaining Days.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (cmb_LeaveType.Text == "Short")
                    {
                        if (shortLeaveEndTime - shortLeaveStartTime != TimeSpan.FromMinutes(90))
                        {
                            MessageBox.Show("Short leave duration must be exactly 1 hour and 30 minutes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                    DateTime today = DateTime.Today;

                    // Ensure that the start date for casual leave is in the future
                    

                    // Check if the leave date is before today
                    if (dtp_LeaveDate.Value < today)
                    {
                        MessageBox.Show("The leave date must not be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Ensure the number of days is not negative
                    if (numberOfDays < 0)
                    {
                        MessageBox.Show("Number of Days should not be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if the number of days requested is less than or equal to the remaining days
                    if (int.Parse(Remaining_Days) < numberOfDays)
                    {
                        MessageBox.Show("Number of Days exceeds Remaining Days.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                    if (string.IsNullOrEmpty(cmb_LeaveID.Text))
                    {

                        if (cmb_LeaveType.Text == "" || dtp_StartTime.Text == "" || dtp_EndTime.Text == "" || txt_Reason.Text == "")
                        {
                            MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {

                            Connection.Open();
                            string query = "SELECT * FROM Leave_Balance WHERE (Employee_ID = @Employee_ID)";

                            using (SqlCommand command = new SqlCommand(query, Connection))
                            {
                                command.Parameters.AddWithValue("@Employee_ID", Login_Form.EmployeeID);

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {

                                        if (cmb_LeaveType.Text == "Annual")
                                        {
                                            Remaining_Days = reader["Remaining_Annual_Leaves"].ToString();
                                        }
                                        else if (cmb_LeaveType.Text == "Casual")
                                        {
                                            Remaining_Days = reader["Remaining_Casual_Leaves"].ToString();
                                        }
                                        else if (cmb_LeaveType.Text == "Short")
                                        {
                                            Remaining_Days = reader["Remaining_Short_Leaves"].ToString();
                                        }
                                        reader.Close();
                                    }
                                }
                            }
                            Connection.Close();

                            if (cmb_LeaveType.Text == "Annual" || cmb_LeaveType.Text == "Casual")
                            {
                                startDate = dtp_StartTime.Value;
                                endDate = dtp_EndTime.Value;

                                // Calculate the difference in days
                                TimeSpan difference = endDate - startDate;
                                numberOfDays = difference.Days + 1;
                            }
                            else if (cmb_LeaveType.Text == "Short")
                                numberOfDays = 1;


                        if (cmb_LeaveType.Text == "Annual" || cmb_LeaveType.Text == "Casual")
                        {
                            if (endDate < startDate)
                            {
                                MessageBox.Show("End Date Should Not Be less than Start Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                                    );
                                return;
                            }
                        }
                        if (int.Parse(Remaining_Days) < numberOfDays)
                            {
                                MessageBox.Show("No Sufficient Leaves \nNo of Leaves Avaiable: " + Remaining_Days + "\nLeave Rejected", "Leave Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            Connection.Open();
                        /////////////////////////////////////////////
                        if (cmb_LeaveType.Text == "Casual")
                        {

                            DateTime leaveStartDate = dtp_StartTime.Value; // Start date picker for leave
                            DateTime leaveEndDate = dtp_EndTime.Value; // End date picker for leave
                            int employeeId = int.Parse(Login_Form.EmployeeID); // Method to get the current employee ID

                            if (ValidateCasualLeave(leaveStartDate, leaveEndDate, employeeId))
                            {
                                SqlCommand Register = new SqlCommand(@"INSERT INTO Leave (Employee_ID, Leave_Type, Leave_Status, Leave_Start_Date, Leave_End_Date, Leave_Application_Date, Leave_Reason)
                        VALUES (@Employee_ID, @Leave_Type, @Leave_Status, @Leave_Start_Date, @Leave_End_Date, @Leave_Application_Date, @Leave_Reason);
                        SELECT SCOPE_IDENTITY();", Connection); ///when the above values are filled it must be sent for employee table of db
                                // Register.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text); ///assigning the Employee_ID to textbox of Employee No 
                                Register.Parameters.AddWithValue("@Employee_ID", Login_Form.EmployeeID);
                                Register.Parameters.AddWithValue("@Leave_Type", cmb_LeaveType.Text);
                                Register.Parameters.AddWithValue("@Leave_Status", "Pending");
                                if (cmb_LeaveType.Text == "Short")
                                {
                                    Register.Parameters.AddWithValue("@Leave_Start_Date", LeaveStartTime);
                                    Register.Parameters.AddWithValue("@Leave_End_Date", LeaveEndTime);
                                }
                                else if (cmb_LeaveType.Text == "Annual" || cmb_LeaveType.Text == "Casual")
                                {
                                    Register.Parameters.AddWithValue("@Leave_Start_Date", dtp_StartTime.Value);
                                    Register.Parameters.AddWithValue("@Leave_End_Date", dtp_EndTime.Value);
                                }

                                Register.Parameters.AddWithValue("@Leave_Application_Date", Application_Date);
                                Register.Parameters.AddWithValue("@Leave_Reason", txt_Reason.Text);

                                //Register.ExecuteNonQuery(); //Registering all Collected Data into Database

                                int newEmployeeID = Convert.ToInt32(Register.ExecuteScalar());
                                cmb_LeaveID.Text = newEmployeeID.ToString();
                                MessageBox.Show("Casual leave application submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        //////////////////////////////
                        else if (cmb_LeaveType.Text == "Annual" || cmb_LeaveType.Text == "Short") {
                            SqlCommand Register = new SqlCommand(@"INSERT INTO Leave (Employee_ID, Leave_Type, Leave_Status, Leave_Start_Date, Leave_End_Date, Leave_Application_Date, Leave_Reason)
                        VALUES (@Employee_ID, @Leave_Type, @Leave_Status, @Leave_Start_Date, @Leave_End_Date, @Leave_Application_Date, @Leave_Reason);
                        SELECT SCOPE_IDENTITY();", Connection); ///when the above values are filled it must be sent for employee table of db
                            // Register.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text); ///assigning the Employee_ID to textbox of Employee No 
                            Register.Parameters.AddWithValue("@Employee_ID", Login_Form.EmployeeID);
                            Register.Parameters.AddWithValue("@Leave_Type", cmb_LeaveType.Text);
                            Register.Parameters.AddWithValue("@Leave_Status", "Pending");
                            if (cmb_LeaveType.Text == "Short")
                            {
                                Register.Parameters.AddWithValue("@Leave_Start_Date", LeaveStartTime);
                                Register.Parameters.AddWithValue("@Leave_End_Date", LeaveEndTime);
                            }
                            else if (cmb_LeaveType.Text == "Annual" || cmb_LeaveType.Text == "Casual")
                            {
                                Register.Parameters.AddWithValue("@Leave_Start_Date", dtp_StartTime.Value);
                                Register.Parameters.AddWithValue("@Leave_End_Date", dtp_EndTime.Value);
                            }

                            Register.Parameters.AddWithValue("@Leave_Application_Date", Application_Date);
                            Register.Parameters.AddWithValue("@Leave_Reason", txt_Reason.Text);

                            //Register.ExecuteNonQuery(); //Registering all Collected Data into Database

                            int newEmployeeID = Convert.ToInt32(Register.ExecuteScalar());
                            cmb_LeaveID.Text = newEmployeeID.ToString();

                            MessageBox.Show("Record Added Successfully \n Leave No: " + newEmployeeID, "Request Leave", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                            Btn_Clear.PerformClick();


                        }
                    }
                    else
                    {
                        MessageBox.Show("Keep Leave ID Empty", "Empty Leave ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_LeaveID.Text = "";
                    }
                
            }
            catch (Exception ex)
            {
                string message = "Insert Error:";
                message += ex.Message;
                MessageBox.Show(message);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }



        }

        private void cmb_LeaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_LeaveType.Text == "Annual" || cmb_LeaveType.Text == "Casual")
            {
                lbl_StartTime.Text = "Start Date";
                lbl_EndTime.Text = "End Date";

                dtp_StartTime.Format = DateTimePickerFormat.Custom;
                dtp_EndTime.Format = DateTimePickerFormat.Custom;
                dtp_StartTime.CustomFormat = "yyyy/MM/dd";
                dtp_EndTime.CustomFormat = "yyyy/MM/dd";

                lbl_LeaveDate.Visible = false;
                dtp_LeaveDate.Visible = false;
                lbl_StartTime.Location = new System.Drawing.Point(8, 112);
                dtp_StartTime.Location = new System.Drawing.Point(224, 110);
                lbl_EndTime.Location = new System.Drawing.Point(8, 149);
                dtp_EndTime.Location = new System.Drawing.Point(224, 147);
                lbl_Reason.Location = new System.Drawing.Point(8, 185);
                txt_Reason.Location = new System.Drawing.Point(224, 185);
                Btn_Clear.Location = new System.Drawing.Point(11, 301);
                Btn_Delete.Location = new System.Drawing.Point(128, 301);
                Btn_Update.Location = new System.Drawing.Point(767, 301);
                Btn_Register.Location = new System.Drawing.Point(881, 301);
                Grp_Add_Leave.Size = new System.Drawing.Size(981, 355);


            }
            else if (cmb_LeaveType.Text == "Short")
            {
                lbl_StartTime.Text = "Start Time";
                lbl_EndTime.Text = "End Time";

                dtp_StartTime.Format = DateTimePickerFormat.Time;
                dtp_EndTime.Format = DateTimePickerFormat.Time;

                lbl_LeaveDate.Visible = true;
                dtp_LeaveDate.Visible = true;
                lbl_LeaveDate.Location = new System.Drawing.Point(8, 110);
                dtp_LeaveDate.Location = new System.Drawing.Point(224, 108);
                lbl_StartTime.Location = new System.Drawing.Point(8, 150);
                dtp_StartTime.Location = new System.Drawing.Point(224, 148);
                lbl_EndTime.Location = new System.Drawing.Point(8, 187);
                dtp_EndTime.Location = new System.Drawing.Point(224, 185);
                lbl_Reason.Location = new System.Drawing.Point(8, 223);
                txt_Reason.Location = new System.Drawing.Point(224, 223);
                Btn_Clear.Location = new System.Drawing.Point(11, 339);
                Btn_Delete.Location = new System.Drawing.Point(128, 339);
                Btn_Update.Location = new System.Drawing.Point(767, 339);
                Btn_Register.Location = new System.Drawing.Point(881, 339);
                Grp_Add_Leave.Size = new System.Drawing.Size(981, 395);


            }

        }

        private void Location_Change()
        {
            lbl_LeaveDate.Visible = false;
            dtp_LeaveDate.Visible = false;
            lbl_StartTime.Location = new System.Drawing.Point(8, 112);
            dtp_StartTime.Location = new System.Drawing.Point(224, 110);
            lbl_EndTime.Location = new System.Drawing.Point(8, 149);
            dtp_EndTime.Location = new System.Drawing.Point(224, 147);
            lbl_Reason.Location = new System.Drawing.Point(8, 185);
            txt_Reason.Location = new System.Drawing.Point(224, 185);
            Btn_Clear.Location = new System.Drawing.Point(11, 301);
            Btn_Delete.Location = new System.Drawing.Point(128, 301);
            Btn_Update.Location = new System.Drawing.Point(767, 301);
            Btn_Register.Location = new System.Drawing.Point(881, 301);
            Grp_Add_Leave.Size = new System.Drawing.Size(981, 355);
        }

        private void Add_Leave_Form_Load(object sender, EventArgs e)
        {

            try
            {
                cmb_LeaveID.Focus();
                Connection.Open();
                DateTime TodayDate = DateTime.Today;
                string now = TodayDate.ToString("yyyy/MM/dd");
                SqlCommand command = new SqlCommand("Select (Leave_ID)from Leave where (Employee_ID = @Employee_ID and Leave_End_Date >= @Today_Date and Leave_Status = @Status)", Connection);
                command.Parameters.AddWithValue("@Employee_ID", Login_Form.EmployeeID);
                command.Parameters.AddWithValue("@Today_Date", now);
                command.Parameters.AddWithValue("@Status", "Pending");
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Leave_ID", typeof(int));
                table.Load(reader);
                cmb_LeaveID.ValueMember = "Leave_ID";
                cmb_LeaveID.DataSource = table;
                Connection.Close();
                cmb_LeaveID.Text = "";
            }
            catch (SqlException ex)
            {
                string message = "Search Error:";
                message += ex.Message;
                MessageBox.Show(message);
                Connection.Close();
            }


        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime ApplicationDate = DateTime.Now;
                string Application_Date = ApplicationDate.ToString("yyyy/MM/dd");
                DateTime shortLeaveStartTime = DateTime.MinValue;
                DateTime shortLeaveEndTime = DateTime.MinValue;

                if (cmb_LeaveType.Text == "Short")
                {
                    DateTime Short_Leave_Date = dtp_LeaveDate.Value.Date;
                    TimeSpan Short_Leave_StartTime = dtp_StartTime.Value.TimeOfDay;
                    TimeSpan Short_Leave_EndTime = dtp_EndTime.Value.TimeOfDay;

                    shortLeaveStartTime = Short_Leave_Date.Add(Short_Leave_StartTime);
                    shortLeaveEndTime = Short_Leave_Date.Add(Short_Leave_EndTime);

                }

                string LeaveStartTime = shortLeaveStartTime.ToString("yyyy/MM/dd HH:mm");
                string LeaveEndTime = shortLeaveEndTime.ToString("yyyy/MM/dd HH:mm");

                if (cmb_LeaveType.Text == "Annual")
                {
                    DateTime today = DateTime.Today;
                    if (dtp_StartTime.Value >= dtp_EndTime.Value)
                    {
                        MessageBox.Show("The annual leave end date must be later than the start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Check if the leave request is at least 7 days in advance
                    if ((dtp_StartTime.Value - today).Days < 7)
                    {
                        MessageBox.Show("Annual leave start date must be requested at least 7 days in advance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

                if (cmb_LeaveType.Text == "Casual")
                {
                    DateTime today = DateTime.Today;

                    // Ensure that the start date for casual leave is in the future
                    if (dtp_StartTime.Value <= today)
                    {
                        MessageBox.Show("The Casual leave start date must be in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if the leave date is before today
                    if (dtp_StartTime.Value < today)
                    {
                        MessageBox.Show("The leave date must not be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Ensure the number of days is not negative
                    if (numberOfDays < 0)
                    {
                        MessageBox.Show("Number of Days should not be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if the number of days requested is less than or equal to the remaining days
                    if (int.Parse(Remaining_Days) < numberOfDays)
                    {
                        MessageBox.Show("Number of Days exceeds Remaining Days.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (cmb_LeaveType.Text == "Short")
                {
                    if (shortLeaveEndTime - shortLeaveStartTime != TimeSpan.FromMinutes(90))
                    {
                        MessageBox.Show("Short leave duration must be exactly 1 hour and 30 minutes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    DateTime today = DateTime.Today;

                    // Ensure that the start date for casual leave is in the future


                    // Check if the leave date is before today
                    if (dtp_LeaveDate.Value < today)
                    {
                        MessageBox.Show("The leave date must not be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Ensure the number of days is not negative
                    if (numberOfDays < 0)
                    {
                        MessageBox.Show("Number of Days should not be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if the number of days requested is less than or equal to the remaining days
                    if (int.Parse(Remaining_Days) < numberOfDays)
                    {
                        MessageBox.Show("Number of Days exceeds Remaining Days.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (string.IsNullOrEmpty(cmb_LeaveID.Text))
                {
                    MessageBox.Show("Enter a Leave ID to update the record", "Enter Leave ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (cmb_LeaveType.Text == "" || dtp_StartTime.Text == "" || dtp_EndTime.Text == "" || txt_Reason.Text == "")
                    {
                        if ((cmb_LeaveType.Text == "Short") && dtp_LeaveDate.Text == "")
                        {
                            MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {


                        Connection.Open();
                        string query = "SELECT * FROM Leave_Balance WHERE (Employee_ID = @Employee_ID)";

                        using (SqlCommand command = new SqlCommand(query, Connection))
                        {
                            command.Parameters.AddWithValue("@Employee_ID", Login_Form.EmployeeID);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {

                                    if (cmb_LeaveType.Text == "Annual")
                                    {
                                        Remaining_Days = reader["Remaining_Annual_Leaves"].ToString();
                                    }
                                    else if (cmb_LeaveType.Text == "Casual")
                                    {
                                        Remaining_Days = reader["Remaining_Casual_Leaves"].ToString();
                                    }
                                    else if (cmb_LeaveType.Text == "Short")
                                    {
                                        Remaining_Days = reader["Remaining_Short_Leaves"].ToString();
                                    }
                                    reader.Close();
                                }
                            }
                        }
                        Connection.Close();
                        MessageBox.Show("" + Remaining_Days + "", "");
                        if (cmb_LeaveType.Text == "Annual" || cmb_LeaveType.Text == "Casual")
                        {
                            DateTime startDate = dtp_StartTime.Value;
                            DateTime endDate = dtp_EndTime.Value;

                            // Calculate the difference in days
                            TimeSpan difference = endDate - startDate;
                            numberOfDays = difference.Days + 1;
                        }
                        else if (cmb_LeaveType.Text == "Short")
                            numberOfDays = 1;

                        if (cmb_LeaveType.Text == "Annual" || cmb_LeaveType.Text == "Casual")
                        {
                            if (endDate < startDate)
                            {
                                MessageBox.Show("End Date Should Not Be less than Start Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                                    );
                                return;
                            }
                        }

                        if (cmb_LeaveType.Text == "Casual" && startDate <= DateTime.Parse(todayDate))
                        {
                            MessageBox.Show("Start Date should be today or future", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                                );
                            return;
                        }
                        

                        if (int.Parse(Remaining_Days) < numberOfDays)
                        {
                            MessageBox.Show("No Sufficient Leaves \nNo of Leaves Avaiable: " + Remaining_Days + "\nLeave Rejected", "Leave Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        Connection.Open();
                        SqlCommand Update = new SqlCommand("Update Leave Set Leave_Type = @Leave_Type, Leave_Start_Date = @Leave_Start_Date, Leave_End_Date = @Leave_End_Date, Leave_Application_Date = @Leave_Application_Date, Leave_Reason = @Leave_Reason WHERE Leave_ID=@Leave_ID", Connection);

                        Update.Parameters.AddWithValue("@Leave_Type", cmb_LeaveType.Text);
                        if (cmb_LeaveType.Text == "Short")
                        {
                            Update.Parameters.AddWithValue("@Leave_Start_Date", LeaveStartTime);
                            Update.Parameters.AddWithValue("@Leave_End_Date", shortLeaveEndTime);
                        }
                        else if (cmb_LeaveType.Text == "Annual" || cmb_LeaveType.Text == "Casual")
                        {
                            Update.Parameters.AddWithValue("@Leave_Start_Date", dtp_StartTime.Value);
                            Update.Parameters.AddWithValue("@Leave_End_Date", dtp_EndTime.Value);
                        }
                        Update.Parameters.AddWithValue("@Leave_Application_Date", Application_Date);
                        Update.Parameters.AddWithValue("@Leave_Reason", txt_Reason.Text);
                        Update.Parameters.AddWithValue("@Leave_ID", cmb_LeaveID.Text);

                        Update.ExecuteNonQuery();
                        MessageBox.Show("Record Updated SucessFully", "Update Leave", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Btn_Clear.PerformClick();

                    }

                }
            }
            catch (Exception Ex)
            {

                string message = "Update Error:";
                message += Ex.Message;
                MessageBox.Show(message);
                Connection.Close();


            }
            finally { Connection.Close(); }

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Lea_ID = cmb_LeaveID.Text;
                    if (string.IsNullOrEmpty(Lea_ID))
                    {
                        MessageBox.Show("Enter a Leave ID to Delete the record", "Enter Leave ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Connection.Open();
                        SqlCommand Delete = new SqlCommand("DELETE FROM Leave where Leave_ID = @Leave_ID", Connection);
                        Delete.Parameters.AddWithValue("@Leave_ID", cmb_LeaveID.Text);
                        Delete.ExecuteNonQuery();
                        Connection.Close();
                        MessageBox.Show("Record Have Been Deleted", "Leave Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Btn_Clear.PerformClick();
                    }
                }
            }
            catch (SqlException ex)
            {
                string message = "Delete Error:";
                message += ex.Message;
                MessageBox.Show(message);
                Connection.Close();
            }


        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {


            try
            {
                if (string.IsNullOrEmpty(cmb_LeaveID.Text))
                {
                    MessageBox.Show("Please enter a Leave ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(Login_Form.connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Leave WHERE (Leave_ID = @Leave_ID and Leave_End_Date >= @Today_Date and Leave_Status = @Status)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        DateTime TodayDate = DateTime.Today;
                        string now = TodayDate.ToString("yyyy/MM/dd");
                        command.Parameters.AddWithValue("@Leave_ID", cmb_LeaveID.Text);
                        command.Parameters.AddWithValue("@Today_Date", now);
                        command.Parameters.AddWithValue("@Status", "Pending");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cmb_LeaveID.Text = reader["Leave_ID"].ToString();
                                cmb_LeaveType.Text = reader["Leave_Type"].ToString();

                                string leaveStartDate = reader["Leave_Start_Date"].ToString();
                                string leaveEndDate = reader["Leave_End_Date"].ToString();

                                if (cmb_LeaveType.Text == "Short")
                                {
                                    DateTime leaveStartDateTime = DateTime.Parse(leaveStartDate);
                                    DateTime leaveEndDateTime = DateTime.Parse(leaveEndDate);

                                    string LeaveDate = leaveStartDateTime.ToString("yyyy/MM/dd");
                                    string LeaveStartTime = leaveStartDateTime.ToString("HH:mm");
                                    string LeaveEndTime = leaveEndDateTime.ToString("HH:mm");

                                    dtp_LeaveDate.Text = LeaveDate;
                                    dtp_StartTime.Text = LeaveStartTime;
                                    dtp_EndTime.Text = LeaveEndTime;

                                }
                                else if (cmb_LeaveType.Text == "Annual" || cmb_LeaveType.Text == "Casual")
                                {
                                    dtp_StartTime.Text = reader["Leave_Start_Date"].ToString();
                                    dtp_EndTime.Text = reader["Leave_End_Date"].ToString();
                                }

                                txt_Reason.Text = reader["Leave_Reason"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("No record found for the given Leave ID.");
                            }
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                string message = "Udate Error:";
                message += ex.Message;
                MessageBox.Show(message);
                Connection.Close();
            }
            finally { Connection.Close(); }
        }

        /// ///Error
        
        private DataRow GetRoster(int employeeId)
        {
            DataTable rosterTable = new DataTable();
            string connectionString = Login_Form.connectionString;
            string query = "SELECT Start_Time, End_Time, Monday_Work, Tuesday_Work, Wednesday_Work, Thursday_Work, Friday_Work, Saturday_Work, Sunday_Work " +
                           "FROM Employee_Schedule WHERE Employee_ID = @EmployeeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeID", Login_Form.EmployeeID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(rosterTable);
            }

            // Check if data is returned
            if (rosterTable.Rows.Count > 0)
            {
                return rosterTable.Rows[0];
            }

            return null; // No roster found for the given employee
        }

        private bool ValidateCasualLeave(DateTime leaveStartDate, DateTime leaveEndDate, int employeeId)
        {
            DataRow roster = GetRoster(employeeId);
            if (roster == null) return false; // No roster found

            // Determine the day of the week for the leave request
            DayOfWeek leaveDay = leaveStartDate.DayOfWeek;
            bool worksOnLeaveDay = Convert.ToBoolean(roster[leaveDay.ToString() + "_Work"]);

            if (worksOnLeaveDay)
            {
                // Get roster start and end times
                DateTime rosterStartTime = DateTime.Parse(roster["Start_Time"].ToString());
                DateTime rosterEndTime = DateTime.Parse(roster["End_Time"].ToString());

                // Check if the leave overlaps with the roster hours
                if (leaveStartDate.TimeOfDay < rosterEndTime.TimeOfDay && leaveEndDate.TimeOfDay > rosterStartTime.TimeOfDay)
                {
                    MessageBox.Show("Casual leave cannot be applied during the scheduled work hours.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true; // Leave is valid
        }

        ///UseLess
    }
}

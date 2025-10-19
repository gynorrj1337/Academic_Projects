using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Lanka_Toys_Admin
{
    public partial class Leave_Approval_Form : Form
    {
        SqlConnection Connection = new SqlConnection(Login_Form.connectionString);
        public Leave_Approval_Form()
        {
            InitializeComponent();
            Location_Change();
        }

        private void Leave_Approval_Form_Load(object sender, EventArgs e)
        {
            try
            {
                cmb_LeaveID.Focus();
                Connection.Open();
                SqlCommand command = new SqlCommand("Select (Leave_ID) from Leave WHERE Leave_Status = @Status", Connection);
                command.Parameters.AddWithValue("@Leave_ID", cmb_LeaveID.Text);
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
            catch (Exception ex)
            {
                string message = "Search Error:";
                message += ex.Message;
                MessageBox.Show(message);
                Connection.Close();

            }

        }

        private void Location_Change()
        {
            lbl_LeaveDate.Visible = false;
            txt_LeaveDate.Visible = false;
            lbl_StartTime.Location = new System.Drawing.Point(6, 138);
            txt_StartTime.Location = new System.Drawing.Point(188, 138);
            lbl_EndTime.Location = new System.Drawing.Point(6, 175);
            txt_EndTime.Location = new System.Drawing.Point(188, 175);
            lbl_Reason.Location = new System.Drawing.Point(6, 251);
            txt_Reason.Location = new System.Drawing.Point(188, 251);
            lbl_Status.Location = new System.Drawing.Point(6, 212);
            txt_Status.Location = new System.Drawing.Point(188, 212);
            Btn_Approve.Location = new System.Drawing.Point(747, 415);
            Btn_Reject.Location = new System.Drawing.Point(864, 415);
            Grp_LeaveApproval.Size = new System.Drawing.Size(994, 482);
            Grp_EmployeeDetails.Size = new System.Drawing.Size(963, 348);

        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            bool dataRetrieved = false;
            if (string.IsNullOrEmpty(cmb_LeaveID.Text))
            {
                MessageBox.Show("Please enter a Leave ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(Login_Form.connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Leave WHERE (Leave_ID = @Leave_ID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    DateTime TodayDate = DateTime.Today;
                    string now = TodayDate.ToString("yyyy/MM/dd");
                    command.Parameters.AddWithValue("@Leave_ID", cmb_LeaveID.Text);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cmb_LeaveID.Text = reader["Leave_ID"].ToString();
                            txt_EmployeeID.Text = reader["Employee_ID"].ToString();
                            txt_LeaveType.Text = reader["Leave_Type"].ToString();

                            string leaveStartDate = reader["Leave_Start_Date"].ToString();
                            string leaveEndDate = reader["Leave_End_Date"].ToString();

                            if (txt_LeaveType.Text == "Short")
                            {
                                DateTime leaveStartDateTime = DateTime.Parse(leaveStartDate);
                                DateTime leaveEndDateTime = DateTime.Parse(leaveEndDate);

                                string LeaveDate = leaveStartDateTime.ToString("yyyy/MM/dd");
                                string LeaveStartTime = leaveStartDateTime.ToString("HH:mm");
                                string LeaveEndTime = leaveEndDateTime.ToString("HH:mm");

                                txt_LeaveDate.Text = LeaveDate;
                                txt_StartTime.Text = LeaveStartTime;
                                txt_EndTime.Text = LeaveEndTime;

                            }
                            else if (txt_LeaveType.Text == "Annual" || txt_LeaveType.Text == "Casual")
                            {

                                DateTime leaveStartDateTime = DateTime.Parse(leaveStartDate);
                                DateTime leaveEndDateTime = DateTime.Parse(leaveEndDate);

                                string StartDate = leaveStartDateTime.ToString("yyyy/MM/dd");
                                string EndDate = leaveEndDateTime.ToString("yyyy/MM/dd");

                                txt_StartTime.Text = StartDate;
                                txt_EndTime.Text = EndDate;
                            }

                            txt_Status.Text = reader["Leave_Status"].ToString();
                            txt_Reason.Text = reader["Leave_Reason"].ToString();
                            connection.Close();
                            dataRetrieved = true;
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Leave ID.");
                        }

                        if (dataRetrieved)
                        {
                            connection.Open();
                            string query1 = "SELECT * FROM Employee WHERE Employee_ID = @Employee_ID";

                            using (SqlCommand command1 = new SqlCommand(query1, connection))
                            {
                                command1.Parameters.AddWithValue("@Employee_ID", txt_EmployeeID.Text);

                                using (SqlDataReader reader1 = command1.ExecuteReader())
                                {
                                    if (reader1.Read())
                                    {
                                        txt_EmployeeName.Text = reader1["First_Name"].ToString() + " " + reader1["Last_Name"].ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void txt_LeaveType_TextChanged(object sender, EventArgs e)
        {
            if (txt_LeaveType.Text == "Annual" || txt_LeaveType.Text == "Casual")
            {
                lbl_StartTime.Text = "Start Date";
                lbl_EndTime.Text = "End Date";

                //dtp_StartTime.Format = DateTimePickerFormat.Custom;
                //dtp_EndTime.Format = DateTimePickerFormat.Custom;
                //dtp_StartTime.CustomFormat = "yyyy/MM/dd";
                //dtp_EndTime.CustomFormat = "yyyy/MM/dd";

                lbl_LeaveDate.Visible = false;
                txt_LeaveDate.Visible = false;
                lbl_StartTime.Location = new System.Drawing.Point(6, 138);
                txt_StartTime.Location = new System.Drawing.Point(188, 138);
                lbl_EndTime.Location = new System.Drawing.Point(6, 175);
                txt_EndTime.Location = new System.Drawing.Point(188, 175);
                lbl_Reason.Location = new System.Drawing.Point(6, 251);
                txt_Reason.Location = new System.Drawing.Point(188, 251);
                lbl_Status.Location = new System.Drawing.Point(6, 212);
                txt_Status.Location = new System.Drawing.Point(188, 212);
                Btn_Approve.Location = new System.Drawing.Point(747, 415);
                Btn_Reject.Location = new System.Drawing.Point(864, 415);
                Grp_LeaveApproval.Size = new System.Drawing.Size(994, 482);
                Grp_EmployeeDetails.Size = new System.Drawing.Size(963, 348);



            }
            else if (txt_LeaveType.Text == "Short")
            {
                lbl_StartTime.Text = "Start Time";
                lbl_EndTime.Text = "End Time";

                //dtp_StartTime.Format = DateTimePickerFormat.Time;
                //dtp_EndTime.Format = DateTimePickerFormat.Time;

                lbl_LeaveDate.Visible = true;
                txt_LeaveDate.Visible = true;
                lbl_LeaveDate.Location = new System.Drawing.Point(6, 143);
                txt_LeaveDate.Location = new System.Drawing.Point(188, 143);
                lbl_StartTime.Location = new System.Drawing.Point(6, 183);
                txt_StartTime.Location = new System.Drawing.Point(188, 183);
                lbl_EndTime.Location = new System.Drawing.Point(6, 220);
                txt_EndTime.Location = new System.Drawing.Point(188, 220);
                lbl_Reason.Location = new System.Drawing.Point(6, 296);
                txt_Reason.Location = new System.Drawing.Point(188, 296);
                lbl_Status.Location = new System.Drawing.Point(6, 257);
                txt_Status.Location = new System.Drawing.Point(188, 257);
                Btn_Approve.Location = new System.Drawing.Point(747, 484);
                Btn_Reject.Location = new System.Drawing.Point(864, 484);
                Grp_LeaveApproval.Size = new System.Drawing.Size(994, 547);
                Grp_EmployeeDetails.Size = new System.Drawing.Size(963, 402);



            }
        }

        private void Clear()
        {
            cmb_LeaveID.Text = "";
            txt_EmployeeID.Text = "";
            txt_EmployeeName.Clear();
            txt_LeaveType.Clear();
            txt_LeaveDate.Clear();
            txt_StartTime.Clear();
            txt_EndTime.Clear();
            txt_Status.Clear();
            txt_Reason.Clear();
        }
        private void Btn_Approve_Click(object sender, EventArgs e)
        {
            Connection.Open();
            string query = "SELECT * FROM Leave_Balance WHERE (Employee_ID = @Employee_ID)";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.AddWithValue("@Employee_ID", txt_EmployeeID.Text);
                string Remaining_Days = "0";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        if (txt_LeaveType.Text == "Annual")
                        {
                            Remaining_Days = reader["Remaining_Annual_Leaves"].ToString();
                        }
                        else if (txt_LeaveType.Text == "Casual")
                        {
                            Remaining_Days = reader["Remaining_Casual_Leaves"].ToString();
                        }
                        else if (txt_LeaveType.Text == "Short")
                        {
                            Remaining_Days = reader["Remaining_Short_Leaves"].ToString();
                        }
                        reader.Close();
                        int numberOfDays = (DateTime.Parse(txt_EndTime.Text) - DateTime.Parse(txt_StartTime.Text)).Days + 1;

                        if (int.Parse(Remaining_Days) < numberOfDays)
                        {
                            MessageBox.Show("No Sufficient Leaves \nNo of Leaves Aviable: " + Remaining_Days + "\nLeave Rejected", "Leave Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            SqlCommand Update = new SqlCommand("UPDATE Leave SET Leave_Status = @Status WHERE Leave_ID = @Leave_ID", Connection); ///when the above values are filled it must be sent for employee table of db
                            Update.Parameters.AddWithValue("@Leave_ID", cmb_LeaveID.Text);
                            Update.Parameters.AddWithValue("@Status", "Rejected");

                            Update.ExecuteNonQuery();
                            Connection.Close();
                            Clear();

                            return;
                        }
                        int Balance_Leave = (int.Parse(Remaining_Days) - numberOfDays);
                        
                        SqlCommand Update_Status = new SqlCommand("UPDATE Leave SET Leave_Status = @Status WHERE Leave_ID = @Leave_ID", Connection); ///when the above values are filled it must be sent for employee table of db
                        Update_Status.Parameters.AddWithValue("@Leave_ID", cmb_LeaveID.Text);
                        Update_Status.Parameters.AddWithValue("@Status", "Approved");
                        Update_Status.ExecuteNonQuery();

                        if (txt_LeaveType.Text == "Annual")
                        {
                            SqlCommand Change_Leave = new SqlCommand("UPDATE Leave_Balance SET Remaining_Annual_Leaves = @Remaining_Leaves WHERE Employee_ID = @Employee_ID", Connection); ///when the above values are filled it must be sent for employee table of db
                            Change_Leave.Parameters.AddWithValue("@Employee_ID", txt_EmployeeID.Text);
                            Change_Leave.Parameters.AddWithValue("@Remaining_Leaves", Balance_Leave);
                            Change_Leave.ExecuteNonQuery();
                        }
                        else if (txt_LeaveType.Text == "Casual")
                        {
                            SqlCommand Change_Leave = new SqlCommand("UPDATE Leave_Balance SET Remaining_Casual_Leaves = @Remaining_Leaves WHERE Employee_ID = @Employee_ID", Connection); ///when the above values are filled it must be sent for employee table of db
                            Change_Leave.Parameters.AddWithValue("@Employee_ID", txt_EmployeeID.Text);
                            Change_Leave.Parameters.AddWithValue("@Remaining_Leaves", Balance_Leave);
                            Change_Leave.ExecuteNonQuery();
                        }
                        else if (txt_LeaveType.Text == "Short")
                        {
                            SqlCommand Change_Leave = new SqlCommand("UPDATE Leave_Balance SET Remaining_Short_Leaves = @Remaining_Leaves WHERE Employee_ID = @Employee_ID", Connection); ///when the above values are filled it must be sent for employee table of db
                            Change_Leave.Parameters.AddWithValue("@Employee_ID", txt_EmployeeID.Text);
                            Change_Leave.Parameters.AddWithValue("@Remaining_Leaves", Balance_Leave);
                            Change_Leave.ExecuteNonQuery();
                        }
                       
                        Connection.Close();
                        MessageBox.Show("Leave Appliation Approved Successfully \n Leave Application No: " + cmb_LeaveID.Text, "Leave Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                }
            }

        }

        private void Btn_Reject_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand Update = new SqlCommand("UPDATE Leave SET Leave_Status = @Status WHERE Leave_ID = @Leave_ID", Connection); ///when the above values are filled it must be sent for employee table of db
            Update.Parameters.AddWithValue("@Leave_ID", cmb_LeaveID.Text);
            Update.Parameters.AddWithValue("@Status", "Rejected");

            Update.ExecuteNonQuery();
            Connection.Close();

            MessageBox.Show("Leave Appliation Rejected Successfully \n Leave Application No: " + cmb_LeaveID.Text, "Leave Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();


        }
    }

}



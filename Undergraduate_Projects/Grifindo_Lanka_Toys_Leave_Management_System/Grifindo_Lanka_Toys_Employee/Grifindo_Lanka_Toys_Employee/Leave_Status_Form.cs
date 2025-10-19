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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Grifindo_Lanka_Toys_Employee
{
    public partial class Leave_Status_Form : Form
    {
        SqlConnection Connection = new SqlConnection(Login_Form.connectionString);
        public Leave_Status_Form()
        {
            InitializeComponent();
            Location_Changed();
        }

        private void Location_Changed()
        {
            lbl_LeaveDate.Visible = false;
            txt_LeaveDate.Visible = false;
            lbl_StartTime.Location = new System.Drawing.Point(6, 138);
            txt_StartTime.Location = new System.Drawing.Point(188, 138);
            lbl_EndTime.Location = new System.Drawing.Point(6, 175);
            txt_EndTime.Location = new System.Drawing.Point(188, 175);
            lbl_Reason.Location = new System.Drawing.Point(6, 283);
            txt_Reason.Location = new System.Drawing.Point(188, 283);
            lbl_Status.Location = new System.Drawing.Point(6, 244);
            txt_Status.Location = new System.Drawing.Point(188, 244);
            lbl_SubmissionDate.Location = new System.Drawing.Point(6, 212);
            txt_SubmissionDate.Location = new System.Drawing.Point(188, 212);

            Grp_EmployeeDetails.Size = new System.Drawing.Size(963, 405);
            Grp_LeaveStatus.Size = new System.Drawing.Size(994, 482);

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
                lbl_Reason.Location = new System.Drawing.Point(6, 283);
                txt_Reason.Location = new System.Drawing.Point(188, 283);
                lbl_Status.Location = new System.Drawing.Point(6, 244);
                txt_Status.Location = new System.Drawing.Point(188, 244);
                lbl_SubmissionDate.Location = new System.Drawing.Point(6, 212);
                txt_SubmissionDate.Location = new System.Drawing.Point(188, 212);

                Grp_EmployeeDetails.Size = new System.Drawing.Size(963, 405);
                Grp_LeaveStatus.Size = new System.Drawing.Size(994, 482);



            }
            else if (txt_LeaveType.Text == "Short")
            {
                lbl_StartTime.Text = "Start Time";
                lbl_EndTime.Text = "End Time";

                //dtp_StartTime.Format = DateTimePickerFormat.Time;
                //dtp_EndTime.Format = DateTimePickerFormat.Time;

                lbl_LeaveDate.Visible = true;
                txt_LeaveDate.Visible = true;
                lbl_LeaveDate.Location = new System.Drawing.Point(6, 137);
                txt_LeaveDate.Location = new System.Drawing.Point(188, 137);
                lbl_StartTime.Location = new System.Drawing.Point(6, 174);
                txt_StartTime.Location = new System.Drawing.Point(188, 174);
                lbl_EndTime.Location = new System.Drawing.Point(6, 211);
                txt_EndTime.Location = new System.Drawing.Point(188, 211);
                lbl_Reason.Location = new System.Drawing.Point(6, 319);
                txt_Reason.Location = new System.Drawing.Point(188, 319);
                lbl_Status.Location = new System.Drawing.Point(6, 280);
                txt_Status.Location = new System.Drawing.Point(188, 280);
                lbl_SubmissionDate.Location = new System.Drawing.Point(6, 248);
                txt_SubmissionDate.Location = new System.Drawing.Point(188, 248);

                Grp_EmployeeDetails.Size = new System.Drawing.Size(963, 426);
                Grp_LeaveStatus.Size = new System.Drawing.Size(994, 518);

            }

        }

        private void Leave_Status_Form_Load(object sender, EventArgs e)
        {
            try
            {
                cmb_LeaveID.Focus();
                Connection.Open();
                SqlCommand command = new SqlCommand("Select (Leave_ID) from Leave WHERE (Employee_ID = @Employee_ID and Leave_End_Date >= @Today)", Connection);
                command.Parameters.AddWithValue("@Employee_ID", Login_Form.EmployeeID);
                command.Parameters.AddWithValue("@Today", DateTime.Today);

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

                string query = "SELECT * FROM Leave WHERE Leave_ID = @Leave_ID and Employee_ID = @Employee_ID and Leave_End_Date >= @Today";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Leave_ID", cmb_LeaveID.Text);
                    command.Parameters.AddWithValue("@Employee_ID", Login_Form.EmployeeID);
                    command.Parameters.AddWithValue("@Today", DateTime.Today);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cmb_LeaveID.Text = reader["Leave_ID"].ToString();
                            txt_EmployeeID.Text = reader["Employee_ID"].ToString();
                            txt_LeaveType.Text = reader["Leave_Type"].ToString();
                            string type = txt_LeaveType.Text;


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
                                txt_StartTime.Text = reader["Leave_Start_Date"].ToString();
                                txt_EndTime.Text = reader["Leave_End_Date"].ToString();
                            }
                            txt_SubmissionDate.Text = Convert.ToDateTime(reader["Leave_Application_Date"]).ToString("yyyy/MM/dd");
                            txt_Status.Text = reader["Leave_Status"].ToString();
                            txt_Reason.Text = reader["Leave_Reason"].ToString();
                            connection.Close();
                            dataRetrieved = true;

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
        }
    }
}
    

    


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

namespace Grifindo_Lanka_Toys_Admin
{
    public partial class Roster_Form : Form
    {
        SqlConnection Connection = new SqlConnection(Login_Form.connectionString);
        public Roster_Form()
        {
            InitializeComponent();

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Cmb_EmployeeID.Text = "";
            chk_Monday.Checked = false;
            chk_Tuesday.Checked = false;
            chk_Wednesday.Checked = false;
            chk_Thursday.Checked = false;
            chk_Friday.Checked = false;
            chk_Saturday.Checked = false;
            chk_Sunday.Checked = false;
            DateTime CTime = DateTime.Now;
            String Now = CTime.ToString("HH:mm:ss");
            dtp_StartTime.Text = Now;
            dtp_EndTime.Text = Now;

            txt_Name.Clear();

        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {

            try
            {

                if (Cmb_EmployeeID.Text == "" || dtp_StartTime.Text == "" || dtp_EndTime.Text == "")
                {
                    MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int Monday;
                    int Tuesday;
                    int Wednesday;
                    int Thursday;
                    int Friday;
                    int Saturday;
                    int Sunday;

                    if (chk_Monday.Checked == true)
                    { Monday = 1; }
                    else
                    { Monday = 0; }

                    if (chk_Tuesday.Checked == true)
                    { Tuesday = 1; }
                    else
                    { Tuesday = 0; }

                    if (chk_Wednesday.Checked == true)
                    { Wednesday = 1; }
                    else
                    { Wednesday = 0; }

                    if (chk_Thursday.Checked == true)
                    { Thursday = 1; }
                    else
                    { Thursday = 0; }

                    if (chk_Friday.Checked == true)
                    { Friday = 1; }
                    else
                    { Friday = 0; }

                    if (chk_Saturday.Checked == true)
                    { Saturday = 1; }
                    else
                    { Saturday = 0; }

                    if (chk_Sunday.Checked == true)
                    { Sunday = 1; }
                    else
                    { Sunday = 0; }

                    DateTime Start_Duration = dtp_StartTime.Value; // or any DateTime object
                    string StartTime = Start_Duration.ToString("HH:mm");

                    DateTime End_Duration = dtp_EndTime.Value; // or any DateTime object
                    string EndTime = End_Duration.ToString("HH:mm");


                    if (DateTime.Parse(EndTime) <= DateTime.Parse(StartTime))
                    {
                        MessageBox.Show("Start Time Should be Earlier than End Time", "Enter Time", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Connection.Open();
                    SqlCommand Register = new SqlCommand(@"INSERT INTO Employee_Schedule (Employee_ID,Start_Time, End_Time, Monday_Work, Tuesday_Work, Wednesday_Work, Thursday_Work, Friday_Work, Saturday_Work, Sunday_Work)
                        VALUES (@Employee_ID, @Start_Time, @End_Time, @Monday_Work, @Tuesday_Work, @Wednesday_Work, @Thursday_Work, @Friday_Work, @Saturday_Work, @Sunday_Work);
                        SELECT SCOPE_IDENTITY();", Connection); ///when the above values are filled it must be sent for employee table of db
                    // Register.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text); ///assigning the Employee_ID to textbox of Employee No 
                    Register.Parameters.AddWithValue("@Employee_ID", Cmb_EmployeeID.Text);
                    Register.Parameters.AddWithValue("@Start_Time", StartTime); // Ensure this is of type DateTime or appropriate type
                    Register.Parameters.AddWithValue("@End_Time", EndTime); // Ensure this is of type DateTime or appropriate type
                    Register.Parameters.AddWithValue("@Monday_Work", Monday);
                    Register.Parameters.AddWithValue("@Tuesday_Work", Tuesday);
                    Register.Parameters.AddWithValue("@Wednesday_Work", Wednesday);
                    Register.Parameters.AddWithValue("@Thursday_Work", Thursday);
                    Register.Parameters.AddWithValue("@Friday_Work", Friday);
                    Register.Parameters.AddWithValue("@Saturday_Work", Saturday);
                    Register.Parameters.AddWithValue("@Sunday_Work", Sunday);

                    Register.ExecuteNonQuery();
                    //Register.ExecuteNonQuery(); //Registering all Collected Data into Database


                    MessageBox.Show("Record Added Successfully \nRegistration No: " + Cmb_EmployeeID.Text, "Update Employee Roster", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Btn_Clear.PerformClick();


                }

            }

            catch (Exception ex)
            {
                string message = "Insert Error:";
                message += ex.Message;
                MessageBox.Show(message);
                Connection.Close();
            }
            finally { Connection.Close(); }



        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

            try
            {

                if (Cmb_EmployeeID.Text == "" || dtp_StartTime.Text == "" || dtp_EndTime.Text == "")
                {
                    MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (chk_Monday.Checked == false && chk_Tuesday.Checked == false && chk_Wednesday.Checked == false && chk_Thursday.Checked == false && chk_Friday.Checked == false && chk_Saturday.Checked == false && chk_Sunday.Checked == false) 
                {
                    MessageBox.Show("Each employee should be assigned at least one day.", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int Monday;
                    int Tuesday;
                    int Wednesday;
                    int Thursday;
                    int Friday;
                    int Saturday;
                    int Sunday;

                    if (chk_Monday.Checked == true)
                    { Monday = 1; }
                    else
                    { Monday = 0; }

                    if (chk_Tuesday.Checked == true)
                    { Tuesday = 1; }
                    else
                    { Tuesday = 0; }

                    if (chk_Wednesday.Checked == true)
                    { Wednesday = 1; }
                    else
                    { Wednesday = 0; }

                    if (chk_Thursday.Checked == true)
                    { Thursday = 1; }
                    else
                    { Thursday = 0; }

                    if (chk_Friday.Checked == true)
                    { Friday = 1; }
                    else
                    { Friday = 0; }

                    if (chk_Saturday.Checked == true)
                    { Saturday = 1; }
                    else
                    { Saturday = 0; }

                    if (chk_Sunday.Checked == true)
                    { Sunday = 1; }
                    else
                    { Sunday = 0; }

                    DateTime Start_Duration = dtp_StartTime.Value; // or any DateTime object
                    string StartTime = Start_Duration.ToString("HH:mm");

                    DateTime End_Duration = dtp_EndTime.Value; // or any DateTime object
                    string EndTime = End_Duration.ToString("HH:mm");

                    if (DateTime.Parse(EndTime) <= DateTime.Parse(StartTime))
                    {
                        MessageBox.Show("Start Time Should be Earlier than End Time", "Enter Time", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else if (chk_Monday.Checked == false && chk_Tuesday.Checked == false && chk_Wednesday.Checked == false && chk_Thursday.Checked == false && chk_Friday.Checked == false && chk_Saturday.Checked == false && chk_Sunday.Checked == false)
                    {
                        MessageBox.Show("Each employee should be assigned at least one day.", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Connection.Open();
                    SqlCommand Update = new SqlCommand("UPDATE Employee_Schedule SET Start_Time = @Start_Time, End_Time = @End_Time, Monday_Work = @Monday_Work, Tuesday_Work = @Tuesday_Work, Wednesday_Work = @Wednesday_Work, Thursday_Work = @Thursday_Work, Friday_Work = @Friday_Work, Saturday_Work = @Saturday_Work, Sunday_Work = @Sunday_Work WHERE Employee_ID = @Employee_ID", Connection); ///when the above values are filled it must be sent for employee table of db
                    Update.Parameters.AddWithValue("@Employee_ID", Cmb_EmployeeID.Text);
                    Update.Parameters.AddWithValue("@Start_Time", StartTime);
                    Update.Parameters.AddWithValue("@End_Time", EndTime);
                    Update.Parameters.AddWithValue("@Monday_Work", Monday);
                    Update.Parameters.AddWithValue("@Tuesday_Work", Tuesday);
                    Update.Parameters.AddWithValue("@Wednesday_Work", Wednesday);
                    Update.Parameters.AddWithValue("@Thursday_Work", Thursday);
                    Update.Parameters.AddWithValue("@Friday_Work", Friday);
                    Update.Parameters.AddWithValue("@Saturday_Work", Saturday);
                    Update.Parameters.AddWithValue("@Sunday_Work", Sunday);

                    Update.ExecuteNonQuery();


                    MessageBox.Show("Record Updated Successfully \nRegistration No: " + Cmb_EmployeeID.Text, "Update Employee Roster", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Btn_Clear.PerformClick();


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

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Emp_ID = Cmb_EmployeeID.Text;
                    if (string.IsNullOrEmpty(Emp_ID))
                    {
                        MessageBox.Show("Enter a Employee ID to Delete the record", "Enter Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Connection.Open();
                        SqlCommand Delete = new SqlCommand("DELETE FROM Employee_Schedule where Employee_ID = @Employee_ID", Connection);
                        Delete.Parameters.AddWithValue("@Employee_ID", Cmb_EmployeeID.Text);
                        Delete.ExecuteNonQuery();
                        Connection.Close();
                        MessageBox.Show("Record Have Been Deleted", "Employee Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Roster_Form_Load(object sender, EventArgs e)
        {
            try
            {
                chk_Monday.Focus();
                Connection.Open();
                SqlCommand command = new SqlCommand("Select (Employee_ID)from Employee", Connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Employee_ID", typeof(int));
                table.Load(reader);
                Cmb_EmployeeID.ValueMember = "Employee_ID";
                Cmb_EmployeeID.DataSource = table;
                Connection.Close();
                Cmb_EmployeeID.Text = "";

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

            try
            {

                if (string.IsNullOrEmpty(Cmb_EmployeeID.Text))
                {
                    MessageBox.Show("Please enter a Employee ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(Login_Form.connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Employee_Schedule WHERE Employee_ID = @Employee_ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Employee_ID", Cmb_EmployeeID.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Cmb_EmployeeID.Text = reader["Employee_ID"].ToString();
                                if (reader["Monday_Work"].ToString() == "1")
                                {
                                    chk_Monday.Checked = true;
                                }
                                else
                                {
                                    chk_Monday.Checked = false;
                                }

                                if (reader["Tuesday_Work"].ToString() == "1")
                                {
                                    chk_Tuesday.Checked = true;
                                }
                                else
                                {
                                    chk_Tuesday.Checked = false;
                                }

                                if (reader["Wednesday_Work"].ToString() == "1")
                                {
                                    chk_Wednesday.Checked = true;
                                }
                                else
                                {
                                    chk_Wednesday.Checked = false;
                                }

                                if (reader["Thursday_Work"].ToString() == "1")
                                {
                                    chk_Thursday.Checked = true;
                                }
                                else
                                {
                                    chk_Thursday.Checked = false;
                                }

                                if (reader["Friday_Work"].ToString() == "1")
                                {
                                    chk_Friday.Checked = true;
                                }
                                else
                                {
                                    chk_Friday.Checked = true;
                                }

                                if (reader["Saturday_Work"].ToString() == "1")
                                {
                                    chk_Saturday.Checked = true;
                                }
                                else
                                {
                                    chk_Saturday.Checked = false;
                                }

                                if (reader["Sunday_Work"].ToString() == "1")
                                {
                                    chk_Sunday.Checked = true;
                                }
                                else
                                {
                                    chk_Sunday.Checked = true;
                                }

                                dtp_StartTime.Text = reader["Start_Time"].ToString();
                                dtp_EndTime.Text = reader["End_Time"].ToString();
                                connection.Close();
                                dataRetrieved = true;
                            }
                           
                            if (dataRetrieved == true)
                            {
                                connection.Open();
                                string query1 = "SELECT * FROM Employee WHERE Employee_ID = @Employee_ID";

                                using (SqlCommand command1 = new SqlCommand(query1, connection))
                                {
                                    command1.Parameters.AddWithValue("@Employee_ID", Cmb_EmployeeID.Text);

                                    using (SqlDataReader reader1 = command1.ExecuteReader())
                                    {
                                        if (reader1.Read())
                                        {
                                            txt_Name.Text = reader1["First_Name"].ToString() + " " + reader1["Last_Name"].ToString();
                                        }
                                    }
                                }
                                connection.Close();
                            }
                            else if (dataRetrieved == false)
                            {
                                chk_Monday.Checked = false;
                                chk_Tuesday.Checked = false;
                                chk_Wednesday.Checked = false;
                                chk_Thursday.Checked = false;
                                chk_Friday.Checked = false;
                                chk_Saturday.Checked = false;
                                chk_Sunday.Checked = false;
                                DateTime CTime = DateTime.Now;
                                String Now = CTime.ToString("HH:mm:ss");
                                dtp_StartTime.Text = Now;
                                dtp_EndTime.Text = Now;
                                MessageBox.Show("Roster is not assigned to this employee", "Roster Not Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                return;
                            }
                        }
                    }
                }

                using (SqlConnection connection = new SqlConnection(Login_Form.connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Employee WHERE Employee_ID = @Employee_ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Employee_ID", Cmb_EmployeeID.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_Name.Text = reader["First_Name"].ToString() + " " + reader["Last_Name"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Leave Policy is not assigned to this employee", "Leave Not Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Cmb_EmployeeID_Leave(object sender, EventArgs e)
        {
            Connection.Open();
            string query1 = "SELECT * FROM Employee WHERE Employee_ID = @Employee_ID";

            using (SqlCommand command1 = new SqlCommand(query1, Connection))
            {
                command1.Parameters.AddWithValue("@Employee_ID", Cmb_EmployeeID.Text);

                using (SqlDataReader reader1 = command1.ExecuteReader())
                {
                    if (reader1.Read())
                    {
                        txt_Name.Text = reader1["First_Name"].ToString() + " " + reader1["Last_Name"].ToString();
                    }
                }
            }
            Connection.Close();

        }
    }
}

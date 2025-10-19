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

namespace E_Space_Mars_Colonization
{
    public partial class Job_Management : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; ");

        public Job_Management()
        {
            InitializeComponent();
        }

        private void Job_Clear_Button_Click(object sender, EventArgs e)
        {
            JobID_ComboBox.Text = "";
            Job_Name_TextBox.Clear();
            Qualification_Req_TextBox.Clear();
            Job_Type_ComboBox.Text = "";
            Job_Salary_TextBox.Clear();
            Job_Name_TextBox.Focus();
        }

        private void Job_Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Job_ID = JobID_ComboBox.Text;
                string Job_Name = Job_Name_TextBox.Text;
                string Job_Qualification = Qualification_Req_TextBox.Text;
                string Job_Type = Job_Type_ComboBox.Text;
                string Job_Salary = Job_Salary_TextBox.Text;
                
                if (string.IsNullOrEmpty(Job_ID))
                {
                    if (Job_Name == "" || Job_Qualification == "" || Job_Type == "" || Job_Salary == "" )
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string JobReg_Query_insert_1 = "INSERT INTO job (Job_Title, Job_Qualification, Job_Type, Job_Salary) " +
                             "VALUES('" + Job_Name + "','" + Job_Qualification + "','" + Job_Type + "','" + Job_Salary + "')" + "SELECT SCOPE_IDENTITY();";
                        con.Open();
                        SqlCommand Register = new SqlCommand(JobReg_Query_insert_1, con);
                        int job_ID = Convert.ToInt32(Register.ExecuteScalar());
                        con.Close();

                        JobID_ComboBox.Text = job_ID.ToString();
                        string jo_ID = JobID_ComboBox.Text;
                        MessageBox.Show("Record Added Successfully \nRegistration No: " + jo_ID, "Register Job", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    con.Open();
                    // Enable IDENTITY_INSERT
                    string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Job ON;";
                    using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                    {
                        enableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    //------------------------------------------
                    if (Job_Name == "" || Job_Qualification == "" || Job_Type == "" || Job_Salary == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string JobReg_Query_insert_2 = "Insert into Job (Job_ID ,Job_Title, Job_Qualification, Job_Type, Job_Salary) " +
                             "Values('" + Job_ID + "','" + Job_Name + "','" + Job_Qualification + "','" + Job_Type + "','" + Job_Salary + "')";

                        SqlCommand Register2 = new SqlCommand(JobReg_Query_insert_2, con);
                        Register2.ExecuteNonQuery();

                        MessageBox.Show("Record Added SucessFully", "Register Job", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    //------------------------------------
                    // Disable IDENTITY_INSERT
                    string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Job OFF;";
                    using (SqlCommand disableIdentityInsertCommand = new SqlCommand(disableIdentityInsertQuery, con))
                    {
                        disableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }

            catch (SqlException ex)
            {
                string message = "Insert Error:";
                message += ex.Message;
                MessageBox.Show(message);
                con.Close();
            }

        }

        private void JobID_Search_Button_Click(object sender, EventArgs e)
        {
            string Job_ID = JobID_ComboBox.Text;

            if (string.IsNullOrEmpty(Job_ID))
            {
                MessageBox.Show("Please enter a Job ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Job WHERE Job_ID = @Job_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Job_ID", Job_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            JobID_ComboBox.Text = reader["Job_ID"].ToString();
                            Job_Name_TextBox.Text = reader["Job_Title"].ToString();
                            Qualification_Req_TextBox.Text = reader["Job_Qualification"].ToString();
                            Job_Type_ComboBox.Text = reader["Job_Type"].ToString();
                            Job_Salary_TextBox.Text = reader["Job_Salary"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Job ID.");
                        }
                    }
                }
            }

        }

        private void Job_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {

                string Job_ID = JobID_ComboBox.Text;
                string Job_Name = Job_Name_TextBox.Text;
                string Job_Qualification = Qualification_Req_TextBox.Text;
                string Job_Type = Job_Type_ComboBox.Text;
                string Job_Salary = Job_Salary_TextBox.Text;

                string Job_Query_update = "UPDATE Job SET " +
                      "Job_Title = '" + Job_Name + "', " +
                      "Job_Qualification = '" + Job_Qualification + "', " +
                      "Job_Type = '" + Job_Type + "', " +
                      "Job_Salary = '" + Job_Salary + "' " +
                      "WHERE Job_ID = '" + Job_ID + "'";
                if (string.IsNullOrEmpty(Job_ID))
                {
                    MessageBox.Show("Enter a Job ID to update the record", "Enter Job ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Job_Name == "" || Job_Qualification == "" || Job_Type == "" || Job_Salary == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        SqlCommand Update = new SqlCommand(Job_Query_update, con);
                        Update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated SucessFully", "Update Job", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                string message = "Update Error:";
                message += ex.Message;
                MessageBox.Show(message);
                con.Close();
            }

        }

        private void Job_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Job_ID = JobID_ComboBox.Text;
                    if (string.IsNullOrEmpty(Job_ID))
                    {
                        MessageBox.Show("Enter a Job ID to Delete the record", "Enter Job ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Job_Delete_Query = "DELETE from Job WHERE Job_ID = " + Job_ID + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(Job_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
                        Job_Clear_Button.PerformClick();
                        MessageBox.Show("Record Have Been Deleted", "Job Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                string message = "Insert Error:";
                message += ex.Message;
                MessageBox.Show(message);
                con.Close();
            }

        }

        private void Job_Management_Load(object sender, EventArgs e)
        {
            try
            {
                Job_Name_TextBox.Focus();
                con.Open();
                SqlCommand command = new SqlCommand("Select (Job_ID)from Job", con);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Job_ID", typeof(int));
                table.Load(reader);
                JobID_ComboBox.ValueMember = "Job_ID";
                JobID_ComboBox.DataSource = table;
                con.Close();
                JobID_ComboBox.Text = "";
                

            }
            catch (SqlException ex)
            {
                string message = "Search Error:";
                message += ex.Message;
                MessageBox.Show(message);
                con.Close();
            }

        }
    }
}

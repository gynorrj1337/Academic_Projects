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
    public partial class Colonist_Job_Management : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; ");

        public Colonist_Job_Management()
        {
            InitializeComponent();
        }

        private void CJobAss_Clear_Button_Click(object sender, EventArgs e)
        {
            CJobAss_CJobID_ComboBox.Text = "";
            CJobAss_JobID_ComboBox.Text = "";
            CJobAss_CID_ComboBox.Text = "";
            CJobAss_JobID_ComboBox.Focus();

        }

        private void CJobAss_Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Colonist_Job_ID = CJobAss_CJobID_ComboBox.Text;
                string Job_ID = CJobAss_JobID_ComboBox.Text;
                string Colonist_ID = CJobAss_CID_ComboBox.Text;
                
                if (string.IsNullOrEmpty(Colonist_Job_ID))
                {
                    if (Job_ID == "" || Colonist_ID == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string JobAss_Query_insert_1 = "INSERT INTO Colonist_Job (Colonist_ID, Job_ID) " +
                             "VALUES('" + Colonist_ID + "','" + Job_ID + "')" + "SELECT SCOPE_IDENTITY();";
                        con.Open();
                        SqlCommand Register = new SqlCommand(JobAss_Query_insert_1, con);
                        int JobAss_ID = Convert.ToInt32(Register.ExecuteScalar());
                        con.Close();

                        CJobAss_CJobID_ComboBox.Text = JobAss_ID.ToString();
                        string Job_Ass_ID = CJobAss_CJobID_ComboBox.Text;
                        MessageBox.Show("Record Added Successfully \nRegistration No: " + Job_Ass_ID, "Assign Job", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    con.Open();
                    // Enable IDENTITY_INSERT
                    string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Colonist_Job ON;";
                    using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                    {
                        enableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    //------------------------------------------
                    if (Job_ID == "" || Colonist_ID == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string JobAss_Query_insert_2 = "Insert into Colonist_Job (Colonist_Job_ID ,Colonist_ID, Job_ID) " +
                             "Values('" + Colonist_Job_ID + "','" + Colonist_ID + "','" + Job_ID + "')";

                        SqlCommand Register2 = new SqlCommand(JobAss_Query_insert_2, con);
                        Register2.ExecuteNonQuery();

                        MessageBox.Show("Record Added SucessFully", "Assign Job", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    //------------------------------------
                    // Disable IDENTITY_INSERT
                    string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Colonist_Job OFF;";
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

        private void CJobAss_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Colonist_Job_ID = CJobAss_CJobID_ComboBox.Text;
                string Job_ID = CJobAss_JobID_ComboBox.Text;
                string Colonist_ID = CJobAss_CID_ComboBox.Text;

                string ColonistJob_Query_update = "UPDATE Colonist_Job SET " +
                      "Job_ID = '" + Job_ID + "', " +
                      "Colonist_ID = '" + Colonist_ID + "' " +
                      "WHERE Colonist_Job_ID = '" + Colonist_Job_ID + "'";
                if (string.IsNullOrEmpty(Colonist_Job_ID))
                {
                    MessageBox.Show("Enter a Colonist Job ID to update the record", "Enter Colonist Job ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Job_ID == "" || Colonist_ID == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        SqlCommand Update = new SqlCommand(ColonistJob_Query_update, con);
                        Update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated SucessFully", "Update Colonist Job", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CJobAss_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Colonist_Job_ID = CJobAss_CJobID_ComboBox.Text;
                    if (string.IsNullOrEmpty(Colonist_Job_ID))
                    {
                        MessageBox.Show("Enter a Colonist Job ID to Delete the record", "Enter Colonist Job ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Colonist_Job_Delete_Query = "DELETE from Colonist_Job WHERE Colonist_Job_ID = " + Colonist_Job_ID + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(Colonist_Job_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
                        CJobAss_Clear_Button.PerformClick();
                        MessageBox.Show("Record Have Been Deleted", "Colonist Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CJobAss_CID_Search_Button_Click(object sender, EventArgs e)
        {
            string Colonist_ID = CJobAss_CID_ComboBox.Text;

            if (string.IsNullOrEmpty(Colonist_ID))
            {
                MessageBox.Show("Please enter a Colonist ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Colonist WHERE Colonist_ID = @Colonist_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Colonist_ID", Colonist_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Colonist_Name_TextBox.Text = reader["First_Name"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Colonist ID.");
                        }
                    }
                }
            }

        }

        private void CJobAss_JobID_Search_Button_Click(object sender, EventArgs e)
        {
            string Job_ID = CJobAss_JobID_ComboBox.Text;

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
                            Job_Name_Textbox.Text = reader["Job_Title"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Job ID.");
                        }
                    }
                }
            }

        }

        private void CJobAss_CJobID_Search_Button_Click(object sender, EventArgs e)
        {
            string Colonist_Job_ID = CJobAss_CJobID_ComboBox.Text;

            if (string.IsNullOrEmpty(Colonist_Job_ID))
            {
                MessageBox.Show("Please enter a Colonist Job ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Colonist_Job WHERE Colonist_Job_ID = @Colonist_Job_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Colonist_Job_ID", Colonist_Job_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CJobAss_CJobID_ComboBox.Text = reader["Colonist_Job_ID"].ToString();
                            CJobAss_JobID_ComboBox.Text = reader["Job_ID"].ToString();
                            CJobAss_CID_ComboBox.Text = reader["Colonist_ID"].ToString();
                            CJobAss_JobID_Search_Button.PerformClick();
                            CJobAss_CID_Search_Button.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Colonist Qualification ID.");
                        }
                    }
                }
            }

        }

        private void Colonist_Job_Management_Load(object sender, EventArgs e)
        {
            try
            {
                CJobAss_JobID_ComboBox.Focus();
                con.Open();
                SqlCommand command = new SqlCommand("Select (Colonist_Job_ID)from Colonist_Job", con);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Colonist_Job_ID", typeof(int));
                table.Load(reader);
                CJobAss_CJobID_ComboBox.ValueMember = "Colonist_Job_ID";
                CJobAss_CJobID_ComboBox.DataSource = table;
                con.Close();
                CJobAss_CJobID_ComboBox.Text = "";
                //////////////////////////////////////////////
                con.Open();
                SqlCommand command3 = new SqlCommand("Select (Colonist_ID)from Colonist", con);
                SqlDataReader reader3;
                reader3 = command3.ExecuteReader();
                DataTable table3 = new DataTable();
                table3.Columns.Add("Colonist_ID", typeof(int));
                table3.Load(reader3);
                CJobAss_CID_ComboBox.ValueMember = "Colonist_ID";
                CJobAss_CID_ComboBox.DataSource = table3;
                con.Close();
                CJobAss_CID_ComboBox.Text = "";
                //////////////////////////////////////////////
                con.Open();
                SqlCommand command2 = new SqlCommand("Select (Job_ID)from Job", con);
                SqlDataReader reader2;
                reader2 = command2.ExecuteReader();
                DataTable table2 = new DataTable();
                table2.Columns.Add("Job_ID", typeof(int));
                table2.Load(reader2);
                CJobAss_JobID_ComboBox.ValueMember = "Job_ID";
                CJobAss_JobID_ComboBox.DataSource = table2;
                con.Close();
                CJobAss_JobID_ComboBox.Text = "";

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

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
    public partial class Dependent_Management : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; ");

        public Dependent_Management()
        {
            InitializeComponent();

        }

        private void DepeReg_Clear_Button_Click(object sender, EventArgs e)
        {

            DependentID_Reg_ComboBox.Text = "";
            Dependent_FName_TextBox.Clear();
            Dependent_MName_TextBox.Clear();
            Dependent_LName_TextBox.Clear();
            DateTime This_Day = DateTime.Today;
            Dependent_DOB_Picker.Text = This_Day.ToString();
            Dependent_Male_RBtn.Checked = false;
            Dependent_Female_RBtn.Checked = false;
            Dependent_Relationship_ComboBox.Text = "";
            ColonistID_Reg_ComboBox.Text = "";
            CName_Qua_Name_TextBox.Clear();
            Dependent_CStatus_ComboBox.Text = "";
            Dependent_ContactNo_Textbox.Clear();
            Dependent_FName_TextBox.Focus();
        }

        private void DepReg_Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Dependent_ID = DependentID_Reg_ComboBox.Text;
                string Colonist_ID = ColonistID_Reg_ComboBox.Text;
                string First_Name = Dependent_FName_TextBox.Text;
                string Middle_Name = Dependent_MName_TextBox.Text;
                string Last_Name = Dependent_LName_TextBox.Text;
                Dependent_DOB_Picker.Format = DateTimePickerFormat.Custom;
                Dependent_DOB_Picker.CustomFormat = "yyyy/MM/dd";
                string Date_Of_Birth = Dependent_DOB_Picker.Text;
                string Gender;
                if (Dependent_Male_RBtn.Checked)
                {
                    Gender = "Male";
                }
                else if (Dependent_Female_RBtn.Checked)
                {
                    Gender = "Female";
                }
                else
                {
                    Gender = "";
                }
                string Civil_Status = Dependent_CStatus_ComboBox.Text;
                string Relationship = Dependent_Relationship_ComboBox.Text;
                string Contact_No = Dependent_ContactNo_Textbox.Text;
                

                if (string.IsNullOrEmpty(Dependent_ID))
                {
                    if (Colonist_ID == "" || First_Name == "" || Last_Name == "" || Date_Of_Birth == "" || Civil_Status == "" || Gender == "" || Relationship == "" || Contact_No == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string DepReg_Query_insert_1 = "INSERT INTO Dependent (Colonist_ID, First_Name, Middle_Name, Last_Name, Date_Of_Birth, Gender, Relationship_To_Colonist, Contact_No, Civil_Status) " +
                             "VALUES('"+ Colonist_ID +"','" + First_Name + "','" + Middle_Name + "','" + Last_Name + "','" + Date_Of_Birth + "','" + Gender + "','" + Relationship + "','" + Contact_No + "','" + Civil_Status + "')" + "SELECT SCOPE_IDENTITY();";
                        con.Open();
                        SqlCommand Register = new SqlCommand(DepReg_Query_insert_1, con);
                        int Dep_ID = Convert.ToInt32(Register.ExecuteScalar());
                        con.Close();

                        DependentID_Reg_ComboBox.Text = Dep_ID.ToString();
                        string Depe_ID = DependentID_Reg_ComboBox.Text;
                        MessageBox.Show("Record Added Successfully \nRegistration No: " + Depe_ID, "Register Dependent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    con.Open();
                    // Enable IDENTITY_INSERT
                    string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Dependent ON;";
                    using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                    {
                        enableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    //------------------------------------------
                    if (Colonist_ID == ""||First_Name == "" || Last_Name == "" || Date_Of_Birth == "" || Civil_Status == "" || Gender == "" || Relationship == "" || Contact_No == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string DepReg_Query_insert_2 = "Insert into Dependent (DependentID ,Colonist_ID ,First_Name, Middle_Name, Last_Name, Date_Of_Birth, Gender, Relationship_To_Colonist, Contact_No, Civil_Status) " +
                             "Values('"+ Dependent_ID +"','" + Colonist_ID + "','" + First_Name + "','" + Middle_Name + "','" + Last_Name + "','" + Date_Of_Birth + "','" + Gender + "','" + Relationship + "','" + Contact_No + "','" + Civil_Status + "')";

                        SqlCommand Register2 = new SqlCommand(DepReg_Query_insert_2, con);
                        Register2.ExecuteNonQuery();

                        MessageBox.Show("Record Added SucessFully", "Register Dependent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    //------------------------------------
                    // Disable IDENTITY_INSERT
                    string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Dependent OFF;";
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

        private void Dependent_Registration_Search_Click(object sender, EventArgs e)
        {
            string Colonist_ID = ColonistID_Reg_ComboBox.Text;

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
                            CName_Qua_Name_TextBox.Text = reader["First_Name"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Colonist ID.");
                        }
                    }
                }
            }

        }

        private void Dependent_Management_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Select (Colonist_ID)from Colonist", con);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Colonist_ID", typeof(int));
                table.Load(reader);
                ColonistID_Reg_ComboBox.ValueMember = "Colonist_ID";
                ColonistID_Reg_ComboBox.DataSource = table;
                con.Close();
                ColonistID_Reg_ComboBox.Text = "";
                //////////////////////////////////////////////
                con.Open();
                SqlCommand command2 = new SqlCommand("Select (DependentID)from Dependent", con);
                SqlDataReader reader2;
                reader2 = command2.ExecuteReader();
                DataTable table2 = new DataTable();
                table2.Columns.Add("DependentID", typeof(int));
                table2.Load(reader2);
                DependentID_Reg_ComboBox.ValueMember = "DependentID";
                DependentID_Reg_ComboBox.DataSource = table2;
                con.Close();
                DependentID_Reg_ComboBox.Text = "";

            }
            catch (SqlException ex)
            {
                string message = "Search Error:";
                message += ex.Message;
                MessageBox.Show(message);
                con.Close();
            }

        }

        private void DepReg_Search_Button_Click(object sender, EventArgs e)
        {
            string DependentID = DependentID_Reg_ComboBox.Text;

            if (string.IsNullOrEmpty(DependentID))
            {
                MessageBox.Show("Please enter a Dependent ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Dependent WHERE DependentID = @DependentID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DependentID", DependentID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DependentID_Reg_ComboBox.Text = reader["DependentID"].ToString();
                            ColonistID_Reg_ComboBox.Text = reader["Colonist_ID"].ToString();
                            Dependent_FName_TextBox.Text = reader["First_Name"].ToString();
                            Dependent_MName_TextBox.Text = reader["Middle_Name"].ToString();
                            Dependent_LName_TextBox.Text = reader["Last_Name"].ToString();
                            Dependent_DOB_Picker.Format = DateTimePickerFormat.Custom;
                            Dependent_DOB_Picker.CustomFormat = "yyyy/MM/dd";
                            Dependent_DOB_Picker.Text = reader["Date_Of_Birth"].ToString();
                            if (reader["Gender"].ToString() == "Male")
                            {
                                Dependent_Male_RBtn.Checked = true;
                            }
                            else
                            {
                                Dependent_Female_RBtn.Checked = true;
                            }

                            Dependent_Relationship_ComboBox.Text = reader["Relationship_To_Colonist"].ToString();
                            Dependent_CStatus_ComboBox.Text = reader["Civil_Status"].ToString();
                            Dependent_ContactNo_Textbox.Text = reader["Contact_No"].ToString();
                            Dependent_Registration_Search.PerformClick();

                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Dependent ID.");
                        }
                    }
                }
            }

        }

        private void DepReg_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Dependent_ID = DependentID_Reg_ComboBox.Text;
                string Colonist_ID = ColonistID_Reg_ComboBox.Text;
                string First_Name = Dependent_FName_TextBox.Text;
                string Middle_Name = Dependent_MName_TextBox.Text;
                string Last_Name = Dependent_LName_TextBox.Text;
                Dependent_DOB_Picker.Format = DateTimePickerFormat.Custom;
                Dependent_DOB_Picker.CustomFormat = "yyyy/MM/dd";
                string Date_Of_Birth = Dependent_DOB_Picker.Text;
                string Gender;
                if (Dependent_Male_RBtn.Checked)
                {
                    Gender = "Male";
                }
                else if (Dependent_Female_RBtn.Checked)
                {
                    Gender = "Female";
                }
                else
                {
                    Gender = "";
                }
                string Civil_Status = Dependent_CStatus_ComboBox.Text;
                string Relationship = Dependent_Relationship_ComboBox.Text;
                string Contact_No = Dependent_ContactNo_Textbox.Text;


                string Dependent_Query_update = "UPDATE Dependent SET " +
                      "Colonist_ID = '" +Colonist_ID+ "', " +
                      "First_Name = '" + First_Name + "', " +
                      "Middle_Name = '" + Middle_Name + "', " +
                      "Last_Name = '" + Last_Name + "', " +
                      "Date_Of_Birth = '" + Date_Of_Birth + "', " +
                      "Gender = '" + Gender + "', " +
                      "Relationship_To_Colonist = '" + Relationship + "', " +
                      "Contact_No = '" + Contact_No + "', " +
                      "Civil_Status = '" + Civil_Status + "'" +
                      "WHERE DependentID = '" + Dependent_ID + "'";
                if (string.IsNullOrEmpty(Dependent_ID))
                {
                    MessageBox.Show("Enter a Dependent ID to update the record", "Enter Dependent ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Colonist_ID == "" || First_Name == "" || Last_Name == "" || Date_Of_Birth == "" || Civil_Status == "" || Gender == "" || Relationship == "" || Contact_No == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        SqlCommand Update = new SqlCommand(Dependent_Query_update, con);
                        Update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated SucessFully", "Update Dependent", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DepRegDelete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Dependent_ID = DependentID_Reg_ComboBox.Text;
                    if (string.IsNullOrEmpty(Dependent_ID))
                    {
                        MessageBox.Show("Enter a Dependent ID to Delete the record", "Enter Dependent ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Colonist_Delete_Query = "DELETE from Dependent WHERE DependentID = " + Dependent_ID + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(Colonist_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
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
    }
}

    


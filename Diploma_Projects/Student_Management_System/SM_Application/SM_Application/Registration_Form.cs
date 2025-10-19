using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;

namespace SM_Application
{
    public partial class Registration_Form : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Student;Integrated Security=True; ");
        //SqlCommand cmd;
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void DoorNo_TextBox_Click(object sender, EventArgs e)
        {
        }


        private void Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Registration_No = Registration_ComboBox.Text;
                string First_Name = FName_TextBox.Text;
                string Last_Name = LName_TextBox.Text;
                DOB_Picker.Format = DateTimePickerFormat.Custom;
                DOB_Picker.CustomFormat = "yyyy/MM/dd";
                string Date_Of_Birth = DOB_Picker.Text;
                string Gender;
                if (Male_RBtn.Checked)
                {
                    Gender = "Male";
                }
                else if(Female_RBtn.Checked)
                {
                    Gender = "Female";
                }
                else
                {
                    Gender = "";
                }
                
                string Address = Address_TextBox.Text;
                string Email = EMail_Textbox.Text;
                string MobilePhoneNo = PhoneNo_Textbox.Text;
                string HomePhoneNo = HomeNo_Textbox.Text;
                string Parent_Name = PName_Textbox.Text;
                string Parent_NIC = PNIC_Textbox.Text;
                string Parent_ContactNo = PPhoneNo_Textbox.Text;

                if (string.IsNullOrEmpty(Registration_No))
                {
                    if (First_Name == "" || Last_Name == "" || Date_Of_Birth == "" || Gender == "" || Address == "" || MobilePhoneNo == "" || Parent_Name == "" || Parent_NIC == "" || Parent_ContactNo == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Query_insert = "INSERT INTO Registration (First_Name, Last_Name, Date_Of_Birth, Gender, Address, Email, MobilePhoneNo, HomePhoneNo, Parent_Name, Parent_NIC, Parent_ContactNo) " +
                         "VALUES('" + First_Name + "','" + Last_Name + "','" + Date_Of_Birth + "','" + Gender + "','" + Address + "','" + Email + "','" + MobilePhoneNo + "','" + HomePhoneNo + "','" + Parent_Name + "','" + Parent_NIC + "','" + Parent_ContactNo + "')" + "SELECT SCOPE_IDENTITY();";
                        con.Open();
                        SqlCommand Register = new SqlCommand(Query_insert, con);
                        int registration_No = Convert.ToInt32(Register.ExecuteScalar());
                        

                        SqlCommand command = new SqlCommand("Select (Registration_No)from Registration", con);
                        SqlDataReader reader;
                        reader = command.ExecuteReader();
                        DataTable table = new DataTable();
                        table.Columns.Add("Registration_No", typeof(int));
                        table.Load(reader);
                        Registration_ComboBox.ValueMember = "Registration_NO";
                        Registration_ComboBox.DataSource = table;
                        con.Close();
                        Registration_ComboBox.Text = registration_No.ToString();
                        string Reg_No = Registration_ComboBox.Text;
                        MessageBox.Show("Record Added Successfully \nRegistration No: " + Reg_No, "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
                else
                {
                    con.Open();
                    // Enable IDENTITY_INSERT
                    string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Registration ON;";
                    using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                    {
                        enableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    //------------------------------------------
                    if (First_Name == "" || Last_Name == "" || Date_Of_Birth == "" || Gender == "" || Address == "" || MobilePhoneNo == "" || Parent_Name == "" || Parent_NIC == "" || Parent_ContactNo == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else 
                    {
                        string Query_insert2 = "Insert into Registration (Registration_No, First_Name, Last_Name, Date_Of_Birth, Gender, Address, Email, MobilePhoneNo, HomePhoneNo, Parent_Name, Parent_NIC, Parent_ContactNo)" +
                        "Values('" + Registration_No + "','" + First_Name + "','" + Last_Name + "','" + Date_Of_Birth + "','" + Gender + "','" + Address + "','" + Email + "','" + MobilePhoneNo + "','" + HomePhoneNo + "','" + Parent_Name + "','" + Parent_NIC + "','" + Parent_ContactNo + "')";

                        SqlCommand Register = new SqlCommand(Query_insert2, con);
                        Register.ExecuteNonQuery();

                        MessageBox.Show("Record Added SucessFully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //------------------------------------
                    // Disable IDENTITY_INSERT
                    string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Registration OFF;";
                    using (SqlCommand disableIdentityInsertCommand = new SqlCommand(disableIdentityInsertQuery, con))
                    {
                        disableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    string Registration_No_Store = Registration_ComboBox.Text;
                    SqlCommand command = new SqlCommand("Select (Registration_No)from Registration", con);
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Columns.Add("Registration_No", typeof(int));
                    table.Load(reader);
                    Registration_ComboBox.ValueMember = "Registration_NO";
                    Registration_ComboBox.DataSource = table;
                    con.Close();
                    Registration_ComboBox.Text = Registration_No_Store.ToString();

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

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Registration_ComboBox.Text = "";
            FName_TextBox.Clear();
            LName_TextBox.Clear();
            DateTime This_Day = DateTime.Today;
            DOB_Picker.Text = This_Day.ToString();
            Male_RBtn.Checked = false;
            Female_RBtn.Checked = false;
            Address_TextBox.Clear();
            EMail_Textbox.Clear();
            PhoneNo_Textbox.Clear();
            HomeNo_Textbox.Clear();
            PName_Textbox.Clear();
            PNIC_Textbox.Clear();
            PPhoneNo_Textbox.Clear();
            FName_TextBox.Focus();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string Registration_No = Registration_ComboBox.Text;

            if (string.IsNullOrEmpty(Registration_No))
            {
                MessageBox.Show("Please enter a registration number.","Search Record",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Student;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Registration WHERE Registration_No = @Registration_No";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Registration_No", Registration_No);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Registration_ComboBox.Text = reader["Registration_No"].ToString();
                            FName_TextBox.Text = reader["First_Name"].ToString();
                            LName_TextBox.Text = reader["Last_Name"].ToString();
                            DOB_Picker.Format = DateTimePickerFormat.Custom;
                            DOB_Picker.CustomFormat = "yyyy/MM/dd";
                            DOB_Picker.Text = reader["Date_Of_Birth"].ToString();
                            if (reader["Gender"].ToString() == "Male")
                            {
                                Male_RBtn.Checked = true;
                            }
                            else
                            {
                                Female_RBtn.Checked = true;
                            }

                            Address_TextBox.Text = reader["Address"].ToString();
                            EMail_Textbox.Text = reader["Email"].ToString();
                            PhoneNo_Textbox.Text = reader["MobilePhoneNo"].ToString();
                            HomeNo_Textbox.Text = reader["HomePhoneNo"].ToString();
                            PName_Textbox.Text = reader["Parent_Name"].ToString();
                            PNIC_Textbox.Text = reader["Parent_NIC"].ToString();
                            PPhoneNo_Textbox.Text = reader["Parent_ContactNo"].ToString();
                                                       
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given registration number.");
                        }
                    }
                }
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string Registration_No = Registration_ComboBox.Text;
                if (string.IsNullOrEmpty(Registration_No))
                {
                    MessageBox.Show("Enter a Registration No to Delete the record", "Enter Registration No", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string Registration_No_Store = Registration_ComboBox.Text;
                    string Delete_Query = "DELETE from Registration WHERE Registration_No = " + Registration_No + " ";
                    con.Open();
                    SqlCommand Command = new SqlCommand(Delete_Query, con);
                    Command.ExecuteNonQuery();
                    SqlCommand command = new SqlCommand("Select (Registration_No)from Registration", con);
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Columns.Add("Registration_No", typeof(int));
                    table.Load(reader);
                    Registration_ComboBox.ValueMember = "Registration_NO";
                    Registration_ComboBox.DataSource = table;
                    con.Close();
                    Registration_ComboBox.Text = Registration_No_Store.ToString();
                    MessageBox.Show("Record Have Been Deleted", "Student Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Registration_No = Registration_ComboBox.Text;
                string First_Name = FName_TextBox.Text;
                string Last_Name = LName_TextBox.Text;
                DOB_Picker.Format = DateTimePickerFormat.Custom;
                DOB_Picker.CustomFormat = "yyyy/MM/dd";
                string Date_Of_Birth = DOB_Picker.Text;
                string Gender;
                if (Male_RBtn.Checked)
                {
                    Gender = "Male";
                }
                else if (Female_RBtn.Checked)
                {
                    Gender = "Female";
                }
                else
                {
                    Gender = "";
                }

                string Address = Address_TextBox.Text;
                string Email = EMail_Textbox.Text;
                string MobilePhoneNo = PhoneNo_Textbox.Text;
                string HomePhoneNo = HomeNo_Textbox.Text;
                string Parent_Name = PName_Textbox.Text;
                string Parent_NIC = PNIC_Textbox.Text;
                string Parent_ContactNo = PPhoneNo_Textbox.Text;

                
                string Query_update = "UPDATE Registration SET " +
                      "First_Name = '" + First_Name + "', " +
                      "Last_Name = '" + Last_Name + "', " +
                      "Date_Of_Birth = '" + Date_Of_Birth + "', " +
                      "Gender = '" + Gender + "', " +
                      "Address = '" + Address + "', " +
                      "Email = '" + Email + "', " +
                      "MobilePhoneNo = '" + MobilePhoneNo + "', " +
                      "HomePhoneNo = '" + HomePhoneNo + "', " +
                      "Parent_Name = '" + Parent_Name + "', " +
                      "Parent_NIC = '" + Parent_NIC + "', " +
                      "Parent_ContactNo = '" + Parent_ContactNo + "' " +
                      "WHERE Registration_No = '"+ Registration_No + "'";
                if (string.IsNullOrEmpty(Registration_No))
                {
                    MessageBox.Show("Enter a Registration No to update the record", "Enter Registration No", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (First_Name == "" || Last_Name == "" || Date_Of_Birth == "" || Gender == "" || Address == "" || MobilePhoneNo == "" || Parent_Name == "" || Parent_NIC == "" || Parent_ContactNo == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        SqlCommand Update = new SqlCommand(Query_update, con);
                        Update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated SucessFully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Registration_Form_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Select (Registration_No)from Registration", con);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Registration_No", typeof(int));
                table.Load(reader);
                Registration_ComboBox.ValueMember = "Registration_NO";
                Registration_ComboBox.DataSource = table;
                con.Close();
                Registration_ComboBox.Text = "";
            }
            catch(SqlException ex)
            {
                string message = "Search Error:";
                message += ex.Message;
                MessageBox.Show(message);
                con.Close();
            }
        }
    }
}

         

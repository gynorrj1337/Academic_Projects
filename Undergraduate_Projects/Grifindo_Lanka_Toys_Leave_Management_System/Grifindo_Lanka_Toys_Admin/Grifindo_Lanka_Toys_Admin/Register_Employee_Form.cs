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
using Microsoft.Win32;


namespace Grifindo_Lanka_Toys_Admin
{
    public partial class Register_Employee_Form : Form
    {
        SqlConnection Connection = new SqlConnection(Login_Form.connectionString);

        public Register_Employee_Form()
        {
            InitializeComponent();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_EmployeeID.Text = "";
            cmb_Role.Text = "";
            txt_FName.Clear();
            txt_MName.Clear();
            txt_LName.Clear();
            DateTime This_Day = DateTime.Today;
            DOB_Picker.Text = This_Day.ToString();
            RBtn_Male.Checked = false;
            RBtn_Female.Checked = false;
            txt_Address.Clear();
            txt_ContactNo.Clear();
            txt_Password.Clear();

        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            try
            {

                string Gender;
                if (RBtn_Male.Checked)
                {
                    Gender = "Male";
                }
                else if (RBtn_Female.Checked)
                {
                    Gender = "Female";
                }
                else
                {
                    Gender = "";
                }

                if (string.IsNullOrEmpty(cmb_EmployeeID.Text))
                {

                    if (txt_FName.Text == "" || txt_LName.Text == "" || DOB_Picker.Text == "" || txt_Address.Text == "" || Gender == "" || txt_ContactNo.Text == "" || cmb_Role.Text == "" || txt_Password.Text == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        Connection.Open();
                        SqlCommand Register = new SqlCommand(@"INSERT INTO Employee (First_Name, Middle_Name, Last_Name, Date_Of_Birth, Address, Gender, Contact_No, Role, Password)
                        VALUES (@First_Name, @Middle_Name, @Last_Name, @Date_Of_Birth, @Address, @Gender, @Contact_No, @Role, @Password);
                        SELECT SCOPE_IDENTITY();", Connection); ///when the above values are filled it must be sent for employee table of db
                       // Register.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text); ///assigning the Employee_ID to textbox of Employee No 
                        Register.Parameters.AddWithValue("@First_Name", txt_FName.Text);
                        Register.Parameters.AddWithValue("@Middle_Name", txt_MName.Text);
                        Register.Parameters.AddWithValue("@Last_Name", txt_FName.Text);
                        Register.Parameters.AddWithValue("@Date_Of_Birth", DOB_Picker.Text);
                        Register.Parameters.AddWithValue("@Address", txt_Address.Text);
                        Register.Parameters.AddWithValue("@Gender", Gender);
                        Register.Parameters.AddWithValue("@Contact_No", txt_ContactNo.Text);
                        Register.Parameters.AddWithValue("@Role", cmb_Role.Text);
                        Register.Parameters.AddWithValue("@Password", txt_Password.Text);

                        //Register.ExecuteNonQuery(); //Registering all Collected Data into Database
                    
                        int newEmployeeID = Convert.ToInt32(Register.ExecuteScalar());
                        cmb_EmployeeID.Text = newEmployeeID.ToString();

                        MessageBox.Show("Record Added Successfully \nRegistration No: " + newEmployeeID, "Register Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Btn_Clear.PerformClick();


                    }
                }
                else
                {
                    if (txt_FName.Text == "" || txt_LName.Text == "" || DOB_Picker.Text == "" || txt_Address.Text == "" || Gender == "" || txt_ContactNo.Text == "" || cmb_Role.Text == "" || txt_Password.Text == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Connection.Open();
                        // Enable IDENTITY_INSERT
                        string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Employee ON;";
                        using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, Connection))
                        {
                            enableIdentityInsertCommand.ExecuteNonQuery();
                        }
                        //------------------------------------------
                        SqlCommand Register = new SqlCommand(@"INSERT INTO Employee (Employee_ID,First_Name, Middle_Name, Last_Name, Date_Of_Birth, Address, Gender, Contact_No, Role, Password)
                            VALUES (@Employee_ID,@First_Name, @Middle_Name, @Last_Name, @Date_Of_Birth, @Address, @Gender, @Contact_No, @Role, @Password);
                            SELECT SCOPE_IDENTITY();", Connection); ///when the above values are filled it must be sent for employee table of db

                        Register.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text); ///assigning the Employee_ID to textbox of Employee No 
                        Register.Parameters.AddWithValue("@First_Name", txt_FName.Text);
                        Register.Parameters.AddWithValue("@Middle_Name", txt_MName.Text);
                        Register.Parameters.AddWithValue("@Last_Name", txt_FName.Text);
                        Register.Parameters.AddWithValue("@Date_Of_Birth", DOB_Picker.Text);
                        Register.Parameters.AddWithValue("@Address", txt_Address.Text);
                        Register.Parameters.AddWithValue("@Gender", Gender);
                        Register.Parameters.AddWithValue("@Contact_No", txt_ContactNo.Text);
                        Register.Parameters.AddWithValue("@Role", cmb_Role.Text);
                        Register.Parameters.AddWithValue("@Password", txt_Password.Text);

                        //Register.ExecuteNonQuery(); //Registering all Collected Data into Database

                        int newEmployeeID = Convert.ToInt32(Register.ExecuteScalar());
                        cmb_EmployeeID.Text = newEmployeeID.ToString();
                        //------------------------------------
                        // Disable IDENTITY_INSERT
                        string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Employee OFF;";
                        using (SqlCommand disableIdentityInsertCommand = new SqlCommand(disableIdentityInsertQuery, Connection))
                        {
                            disableIdentityInsertCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Record Added Successfully \nRegistration No: " + cmb_EmployeeID.Text, "Register Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Btn_Clear.PerformClick();
                    }
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

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            string Gender;
            if (RBtn_Male.Checked)
            {
                Gender = "Male";
            }
            else if (RBtn_Female.Checked)
            {
                Gender = "Female";
            }
            else
            {
                Gender = "";
            }
            try
            {
                if (string.IsNullOrEmpty(cmb_EmployeeID.Text))
                {
                    MessageBox.Show("Enter a Employee ID to update the record", "Enter Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (txt_FName.Text == "" || txt_LName.Text == "" || DOB_Picker.Text == "" || txt_Address.Text == "" || Gender == "" || txt_ContactNo.Text == "" || cmb_Role.Text == "" || txt_Password.Text == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Connection.Open();
                        SqlCommand Update = new SqlCommand("Update Employee Set First_Name=@First_Name, Middle_Name=@Middle_Name, Last_Name=@Last_Name, Date_Of_Birth=@Date_Of_Birth, Address=@Address, Gender=@Gender, Contact_No=@Contact_No, Role=@Role, Password=@Password WHERE Employee_ID=@Employee_ID", Connection);

                        Update.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text); ///assigning the Employee_ID to textbox of Employee No 
                        Update.Parameters.AddWithValue("@First_Name", txt_FName.Text);
                        Update.Parameters.AddWithValue("@Middle_Name", txt_MName.Text);
                        Update.Parameters.AddWithValue("@Last_Name", txt_LName.Text);
                        Update.Parameters.AddWithValue("@Date_Of_Birth", DOB_Picker.Text);
                        Update.Parameters.AddWithValue("@Address", txt_Address.Text);
                        Update.Parameters.AddWithValue("@Gender", Gender);
                        Update.Parameters.AddWithValue("@Contact_No", txt_ContactNo.Text);
                        Update.Parameters.AddWithValue("@Role", cmb_Role.Text);
                        Update.Parameters.AddWithValue("@Password", txt_Password.Text);

                        Update.ExecuteNonQuery();
                        MessageBox.Show("Record Updated SucessFully", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string Emp_ID = cmb_EmployeeID.Text;
                    if (string.IsNullOrEmpty(Emp_ID))
                    {
                        MessageBox.Show("Enter a Employee ID to Delete the record", "Enter Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Connection.Open();
                        SqlCommand Delete = new SqlCommand("DELETE FROM Employee where Employee_ID = @Employee_ID", Connection);
                        Delete.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text);
                        Delete.ExecuteNonQuery();
                        Connection.Close();
                        MessageBox.Show("Record Have Been Deleted", "Employee Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Register_Employee_Form_Load(object sender, EventArgs e)
        {
            try
            {
                txt_FName.Focus();
                Connection.Open();
                SqlCommand command = new SqlCommand("Select (Employee_ID)from Employee", Connection);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Employee_ID", typeof(int));
                table.Load(reader);
                cmb_EmployeeID.ValueMember = "Employee_ID";
                cmb_EmployeeID.DataSource = table;
                Connection.Close();
                cmb_EmployeeID.Text = "";

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
            if (string.IsNullOrEmpty(cmb_EmployeeID.Text))
            {
                MessageBox.Show("Please enter a Employee ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(Login_Form.connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Employee WHERE Employee_ID = @Employee_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cmb_EmployeeID.Text = reader["Employee_ID"].ToString();
                            txt_FName.Text = reader["First_Name"].ToString();
                            txt_MName.Text = reader["Middle_Name"].ToString();
                            txt_LName.Text = reader["Last_Name"].ToString();
                            DOB_Picker.Format = DateTimePickerFormat.Custom;
                            DOB_Picker.CustomFormat = "yyyy/MM/dd";
                            DOB_Picker.Text = reader["Date_Of_Birth"].ToString();
                            if (reader["Gender"].ToString() == "Male")
                            {
                                RBtn_Male.Checked = true;
                            }
                            else
                            {
                                RBtn_Female.Checked = true;
                            }

                            txt_Address.Text = reader["Address"].ToString();
                            cmb_Role.Text = reader["Role"].ToString();
                            txt_ContactNo.Text = reader["Contact_No"].ToString();
                            txt_Password.Text = reader["Password"].ToString();


                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Employee ID.");
                        }
                    }
                }
            }

        }
    }
}

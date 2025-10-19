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
    public partial class Leave_Policy_Form : Form
    {
        SqlConnection Connection = new SqlConnection(Login_Form.connectionString);

        public Leave_Policy_Form()
        {
            InitializeComponent();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_EmployeeID.Text = "";
            txt_Annualleaves.Clear();
            txt_CasualLeaves.Clear();
            txt_MonthlyLeaves.Clear();
            txt_Name.Clear();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            try
            {

                    if ( cmb_EmployeeID.Text == "" || txt_Annualleaves.Text == "" || txt_CasualLeaves.Text == "" || txt_MonthlyLeaves.Text == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                    }
                    else
                    {
                    if (int.Parse(txt_Annualleaves.Text) > 14)
                    {
                        MessageBox.Show("Annual Leaves per Year should be less than 14 days", "Annual Leaves", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (int.Parse(txt_CasualLeaves.Text) > 7)
                    {

                        MessageBox.Show("Casual Leaves per Casual should be less than 7 days", "Casual Leaves", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (int.Parse(txt_MonthlyLeaves.Text) > 2)
                    {
                        MessageBox.Show("Monthly Leaves per Month should be less than 2 days", "Monthly Leaves", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Connection.Open();
                        SqlCommand Register = new SqlCommand(@"INSERT INTO Leave_Balance (Employee_ID,Initial_Annual_Leaves, Initial_Casual_Leaves, Initial_Short_Leaves, Remaining_Annual_Leaves, Remaining_Casual_Leaves, Remaining_Short_Leaves)
                        VALUES (@Employee_ID, @Initial_Annual_Leaves, @Initial_Casual_Leaves, @Initial_Short_Leaves,@Remaining_Annual_Leaves, @Remaining_Casual_Leaves, @Remaining_Short_Leaves);
                        SELECT SCOPE_IDENTITY();", Connection); ///when the above values are filled it must be sent for employee table of db
                        Register.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text);
                        Register.Parameters.AddWithValue("@Initial_Annual_Leaves", txt_Annualleaves.Text);
                        Register.Parameters.AddWithValue("@Initial_Casual_Leaves", txt_CasualLeaves.Text);
                        Register.Parameters.AddWithValue("@Initial_Short_Leaves", txt_MonthlyLeaves.Text);
                        Register.Parameters.AddWithValue("@Remaining_Annual_Leaves", txt_Annualleaves.Text);
                        Register.Parameters.AddWithValue("@Remaining_Casual_Leaves", txt_CasualLeaves.Text);
                        Register.Parameters.AddWithValue("@Remaining_Short_Leaves", txt_MonthlyLeaves.Text);

                        Register.ExecuteNonQuery(); //Registering all Collected Data into Database


                        MessageBox.Show("Record Added Successfully \nEmployee No: " + cmb_EmployeeID.Text, "Set Employee Leaves", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            finally { Connection.Close(); }


        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmb_EmployeeID.Text))
                {
                    MessageBox.Show("Enter a Employee ID to update the record", "Enter Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (cmb_EmployeeID.Text == "" || txt_Annualleaves.Text == "" || txt_CasualLeaves.Text == "" || txt_MonthlyLeaves.Text == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    { 
                        if (int.Parse(txt_Annualleaves.Text) > 14)
                        {
                            MessageBox.Show("Annual Leaves per Year should be less than 14 days", "Annual Leaves", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (int.Parse(txt_CasualLeaves.Text) > 7)
                        {

                            MessageBox.Show("Casual Leaves per Casual should be less than 7 days", "Casual Leaves", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (int.Parse(txt_MonthlyLeaves.Text) > 2)
                        {
                            MessageBox.Show("Monthly Leaves per Month should be less than 2 days", "Monthly Leaves", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Connection.Open();
                        SqlCommand Update = new SqlCommand("Update Leave_Balance Set Initial_Annual_Leaves = @Initial_Annual_Leaves, Initial_Casual_Leaves = @Initial_Casual_Leaves, Initial_Short_Leaves = @Initial_Short_Leaves, Remaining_Annual_Leaves = @Remaining_Annual_Leaves, Remaining_Casual_Leaves=@Remaining_Casual_Leaves,Remaining_Short_Leaves=@Remaining_Short_Leaves  WHERE Employee_ID = @Employee_ID", Connection);
                       
                        Update.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text);
                        Update.Parameters.AddWithValue("@Initial_Annual_Leaves", txt_Annualleaves.Text);
                        Update.Parameters.AddWithValue("@Initial_Casual_Leaves", txt_CasualLeaves.Text);
                        Update.Parameters.AddWithValue("@Initial_Short_Leaves", txt_MonthlyLeaves.Text);
                        Update.Parameters.AddWithValue("@Remaining_Annual_Leaves", txt_Annualleaves.Text);
                        Update.Parameters.AddWithValue("@Remaining_Casual_Leaves", txt_CasualLeaves.Text);
                        Update.Parameters.AddWithValue("@Remaining_Short_Leaves", txt_MonthlyLeaves.Text);

                        Update.ExecuteNonQuery();
                        MessageBox.Show("Record Updated SucessFully", "Update Employee Leaves", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        SqlCommand Delete = new SqlCommand("DELETE FROM Leave_Balance where Employee_ID = @Employee_ID", Connection);
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

        private void Leave_Policy_Form_Load(object sender, EventArgs e)
        {
            try
            {
                txt_Annualleaves.Focus();
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

        private void Btn_EmployeeSearch_Click(object sender, EventArgs e)
        {
            bool dataRetrieved = false;
            if (string.IsNullOrEmpty(cmb_EmployeeID.Text))
            {
                
                MessageBox.Show("Please enter a Employee ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(Login_Form.connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Leave_Balance WHERE Employee_ID = @Employee_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cmb_EmployeeID.Text = reader["Employee_ID"].ToString();
                            txt_Annualleaves.Text = reader["Initial_Annual_Leaves"].ToString();
                            txt_CasualLeaves.Text = reader["Initial_Casual_Leaves"].ToString();
                            txt_MonthlyLeaves.Text = reader["Initial_Short_Leaves"].ToString();
                            connection.Close();
                            dataRetrieved = true;

                        }
                        
                        if (dataRetrieved == true)
                        {
                            connection.Open();
                            string query1 = "SELECT * FROM Employee WHERE Employee_ID = @Employee_ID";

                            using (SqlCommand command1 = new SqlCommand(query1, connection))
                            {
                                command1.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text);

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
                             MessageBox.Show("Leave Policy is not assigned to this employee", "Leave Not Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Annualleaves.Clear();
                            txt_CasualLeaves.Clear();
                            txt_MonthlyLeaves.Clear();
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
                    command.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_Name.Text = reader["First_Name"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Leave Policy is not assigned to this employee","Leave Not Assigned",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                }

            }
        }

        private void cmb_EmployeeID_Leave(object sender, EventArgs e)
        {
            Connection.Open();
            string query1 = "SELECT * FROM Employee WHERE Employee_ID = @Employee_ID";

            using (SqlCommand command1 = new SqlCommand(query1, Connection))
            {
                command1.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text);

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

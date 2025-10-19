using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Lanka_Toys_Admin
{
    public partial class Employee_Leave_Report_Form : Form
    {
        SqlConnection Connection = new SqlConnection(Login_Form.connectionString); // SQL connection object

        public Employee_Leave_Report_Form()
        {
            InitializeComponent(); // Initialize the form components
        }

        // Handle form load event
        private void Employee_Leave_Report_Form_Load(object sender, EventArgs e)
        {
            // Add "All Employee" as the first item in the Combobox
            cmb_EmployeeID.Items.Add("All Employee");

            try
            {
                // Fetch employee IDs from the database
                using (SqlConnection connection = new SqlConnection(Login_Form.connectionString))
                {
                    connection.Open();

                    string query = "SELECT Employee_ID FROM Employee";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Add each employee ID to the ComboBox
                        while (reader.Read())
                        {
                            cmb_EmployeeID.Items.Add(reader["Employee_ID"].ToString());
                        }
                    }
                }
                
                cmb_EmployeeID.Text = "";  // Clear the ComboBox selection
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }

        // the DIsplay button
        private void Btn_Display_Click(object sender, EventArgs e)
        {
            string Query = ""; // Initialize query string

            try
            {
                DateTime startDate = dtp_StartDate.Value; // Get start date
                DateTime endDate = dtp_EndDate.Value; // Get end date


                DateTime endDatePlusOne = endDate.AddDays(1); // Calculate end date plus one day

                string StartDate = startDate.ToString("yyyy-MM-dd"); // Format start date
                string EndDate = endDatePlusOne.ToString("yyyy-MM-dd"); // Format end date plus one day


                using (SqlConnection Connection = new SqlConnection(Login_Form.connectionString))
                {
                    Connection.Open();

                    // check the query based on selected employee ID
                    if (cmb_EmployeeID.Text == "All Employee")
                    {
                        Query = "SELECT * FROM LEAVE WHERE (Leave_Start_Date >= @Start_Date AND Leave_End_Date < @End_Date) ORDER BY Leave_ID";
                    }
                    else
                    {
                        Query = "SELECT * FROM LEAVE WHERE (Employee_ID = @Employee_ID AND Leave_Start_Date >= @Start_Date AND Leave_End_Date < @End_Date) ORDER BY Leave_ID";
                    }

                    using (SqlCommand Fetch = new SqlCommand(Query, Connection))
                    {
                        // Add parameters to the query
                        if (cmb_EmployeeID.Text != "All Employee")
                        {
                            Fetch.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text);
                        }
                        Fetch.Parameters.AddWithValue("@Start_Date", StartDate );
                        Fetch.Parameters.AddWithValue("@End_Date", EndDate);

                        SqlDataAdapter da = new SqlDataAdapter(Fetch);
                        DataSet Data = new DataSet();
                        da.Fill(Data); // Fill the dataset with the query results
                        dgv_History.DataSource = Data.Tables[0]; // Bind the data to the DataGridView
                    }
                }


            }
            catch (SqlException ex)
            {
                // Display an error message if a SQL exception occurs
                string message = "Udate Error:";
                message += ex.Message;
                MessageBox.Show(message);
            }
            finally { Connection.Close(); } // Ensure the connection is closed

        }
        //leave event for the ComboBox
        private void cmb_EmployeeID_Leave(object sender, EventArgs e)
        {
            Connection.Open();
            string query1 = "SELECT * FROM Employee WHERE Employee_ID = @Employee_ID";

            using (SqlCommand command1 = new SqlCommand(query1, Connection))
            {
                command1.Parameters.AddWithValue("@Employee_ID", cmb_EmployeeID.Text);

                using (SqlDataReader reader1 = command1.ExecuteReader())
                {
                    if (cmb_EmployeeID.Text != "All Employee") 
                    {
                        if (reader1.Read())
                        {
                            // Display the employee's name if a valid ID is selected
                            txt_EmployeeName.Text = reader1["First_Name"].ToString() + " " + reader1["Last_Name"].ToString();
                            
                        }
                    }
                }
            }
            Connection.Close(); //the connection is closed


        }
    }

}
            
            
        
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

namespace Grifindo_Lanka_Toys_Employee
{
    public partial class Leave_History_Form : Form
    {
        // SQL connection object using connection string from Login_Form
        SqlConnection Connection = new SqlConnection(Login_Form.connectionString);
        public Leave_History_Form()
        {
            InitializeComponent();
        }

        //form load event
        private void Leave_History_Form_Load(object sender, EventArgs e)
        {

            try
            {
                // Open a new SQL connection
                using (SqlConnection connection = new SqlConnection(Login_Form.connectionString))
                {
                    connection.Open();
                    // Query to select leave balance for the current employee
                    string query = "SELECT * FROM Leave_Balance WHERE (Employee_ID = @Employee_ID)";
                    // Create SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Employee_ID", Login_Form.EmployeeID);
                        // Execute command and read results
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate text boxes with remaining leave balances
                                txt_AnnualLeaves.Text = reader["Remaining_Annual_Leaves"].ToString();
                                txt_CasualLeaves.Text = reader["Remaining_Casual_Leaves"].ToString();
                                txt_ShortLeaves.Text = reader["Remaining_Short_Leaves"].ToString();
                                connection.Close();
                                // Focus the Display button
                                Btn_Display.Focus();

                            }
                            else
                            {
                                // Inform user if no leave policy is set for the employee
                                MessageBox.Show("Leave Policy is set to this employee \nEmployee ID" + Login_Form.EmployeeID);
                            }


                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Show error message if SQL exception occurs
                string message = "Udate Error:";
                message += ex.Message;
                MessageBox.Show(message);
            }
            finally { Connection.Close(); } // Make Sure the connection is closed in the finally block
        }

        //the Display button click event
        private void Btn_Display_Click(object sender, EventArgs e)
        {
            try
            {
                // Open SQL connection
                Connection.Open();
                // Query to select all leave records for the current employee, ordered by Leave_ID
                SqlCommand cmd = new SqlCommand("SELECT * FROM LEAVE WHERE (Employee_ID = @Employee_ID)  ORDER BY Leave_ID", Connection);
                cmd.Parameters.AddWithValue("@Employee_ID", Login_Form.EmployeeID);
                // Create a data adapter and fill a DataSet with the query results
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet Data = new DataSet();
                da.Fill(Data);
                // Bind the data to the DataGridView
                dgv_History.DataSource = Data.Tables[0];

                DataTable dt = new DataTable();
                da.Fill(dt);


            }
            catch (SqlException ex)
            {
                // Show error message if SQL exception occurs
                string message = "Udate Error:";
                message += ex.Message;
                MessageBox.Show(message); 
            }
            finally { Connection.Close(); } // Make the connection is closed in the finally block


        }
    } }
            
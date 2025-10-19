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
    public partial class House_Assignment_Management : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; ");

        public House_Assignment_Management()
        {
            InitializeComponent();
        }

        private void ColAss_Clear_Button_Click(object sender, EventArgs e)
        {
            ColonyAss_ColonyAssID_ComboBox.Text = "";
            ColonyAss_CAssID_ComboBox.Text = "";
            ColonyAss_CNoAssID_ComboBox.Text = "";
            ColonyAss_HType_ComboBox.Text = "";
            ColonyAss_CAssID_ComboBox.Focus();

        }

        private void ColAss_Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Colony_Assign_ID = ColonyAss_ColonyAssID_ComboBox.Text;
                string Colonist_ID = ColonyAss_CAssID_ComboBox.Text;
                string Colony_Lot_No = ColonyAss_CNoAssID_ComboBox.Text;
                string House_Type = ColonyAss_HType_ComboBox.Text;

                if (string.IsNullOrEmpty(Colony_Assign_ID))
                {
                    if (Colonist_ID == "" || Colony_Lot_No == "" || House_Type == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Colony_Assign_Query_insert_1 = "INSERT INTO Colony_Assignment (Colonist_ID, Colony_Lot_No, House_Type) " +
                             "VALUES('" + Colonist_ID + "','" + Colony_Lot_No + "','" + House_Type + "')" + "SELECT SCOPE_IDENTITY();";
                        con.Open();
                        SqlCommand Register = new SqlCommand(Colony_Assign_Query_insert_1, con);
                        int Colony_ID = Convert.ToInt32(Register.ExecuteScalar());
                        con.Close();

                        ColonyAss_ColonyAssID_ComboBox.Text = Colony_ID.ToString();
                        string Col_ID = ColonyAss_ColonyAssID_ComboBox.Text;
                        MessageBox.Show("Record Added Successfully \nRegistration No: " + Col_ID, "Assign Mars Colony", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    con.Open();
                    // Enable IDENTITY_INSERT
                    string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Colony_Assignment ON;";
                    using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                    {
                        enableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    //------------------------------------------
                    if (Colonist_ID == "" || Colony_Lot_No == "" || House_Type == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Colony_Assign_Query_insert_2 = "Insert into Colony_Assignment (Colony_Assignment_ID, Colonist_ID, Colony_Lot_No, House_Type) " +
                             "Values('" + Colony_Assign_ID + "','" + Colonist_ID + "','" + Colony_Lot_No + "','" + House_Type + "')";

                        SqlCommand Register2 = new SqlCommand(Colony_Assign_Query_insert_2, con);
                        Register2.ExecuteNonQuery();

                        MessageBox.Show("Record Added SucessFully", "Assign Mars Colony", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    //------------------------------------
                    // Disable IDENTITY_INSERT
                    string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Colony_Assignment OFF;";
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

        private void ColAss_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Colony_Assign_ID = ColonyAss_ColonyAssID_ComboBox.Text;
                string Colonist_ID = ColonyAss_CAssID_ComboBox.Text;
                string Colony_Lot_No = ColonyAss_CNoAssID_ComboBox.Text;
                string House_Type = ColonyAss_HType_ComboBox.Text;


                string Colony_Assignment_Query_update = "UPDATE Colony_Assignment SET " +
                      "Colonist_ID = '" + Colonist_ID + "', " +
                      "Colony_Lot_No = '" + Colony_Lot_No + "', " +
                      "House_Type = '" + House_Type + "' " +
                      "WHERE Colony_Assignment_ID = '" + Colony_Assign_ID + "'";
                if (string.IsNullOrEmpty(Colony_Assign_ID))
                {
                    MessageBox.Show("Enter a Colony Assignment ID to update the record", "Enter Colony Assignment ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Colonist_ID == "" || Colony_Lot_No == "" || House_Type == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        SqlCommand Update = new SqlCommand(Colony_Assignment_Query_update, con);
                        Update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated SucessFully", "Update Colony Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ColAss_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Colony_Assign_ID = ColonyAss_ColonyAssID_ComboBox.Text;
                    if (string.IsNullOrEmpty(Colony_Assign_ID))
                    {
                        MessageBox.Show("Enter a Colony Assignment ID to Delete the record", "Enter Colony Assignment ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Colonist_Delete_Query = "DELETE from Colony_Assignment WHERE Colony_Assignment_ID = " + Colony_Assign_ID + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(Colonist_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
                        ColAss_Clear_Button.PerformClick();
                        MessageBox.Show("Record Have Been Deleted", "Colony Assignment Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ColonyAss_ColonyAssID_Search_Button_Click(object sender, EventArgs e)
        {
            string Colony_Assignment_ID = ColonyAss_ColonyAssID_ComboBox.Text;

            if (string.IsNullOrEmpty(Colony_Assignment_ID))
            {
                MessageBox.Show("Please enter a Colony Assignment ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Colony_Assignment WHERE Colony_Assignment_ID = @Colony_Assignment_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Colony_Assignment_ID", Colony_Assignment_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ColonyAss_ColonyAssID_ComboBox.Text = reader["Colony_Assignment_ID"].ToString();
                            ColonyAss_CAssID_ComboBox.Text = reader["Colonist_ID"].ToString();
                            ColonyAss_CNoAssID_ComboBox.Text = reader["Colony_Lot_No"].ToString();
                            ColonyAss_HType_ComboBox.Text = reader["House_Type"].ToString();
                            ColonyAss_CAssID_Search_Button.PerformClick();
                            ColonyAss_CNoAssID_Search_Button.PerformClick();


                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Colony Assignment ID.");
                        }
                    }
                }
            }

        }

        private void ColonyAss_CAssID_Search_Button_Click(object sender, EventArgs e)
        {
            string Colonist_ID = ColonyAss_CAssID_ComboBox.Text;
            int dependentCount = 0;

            if (string.IsNullOrEmpty(Colonist_ID))
            {
                MessageBox.Show("Please enter a Colonist ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Colonist WHERE Colonist_ID = @Colonist_ID";
                string query_fetch_Dependent = "SELECT count(*) FROM Dependent WHERE Colonist_ID = @Colonist_ID";
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

                using (SqlConnection connection1 = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
                {

                    SqlCommand command1 = new SqlCommand(query_fetch_Dependent, connection1);
                    command1.Parameters.AddWithValue("@Colonist_ID", Colonist_ID);

                    try
                    {
                        connection1.Open();
                        dependentCount = (int)command1.ExecuteScalar();

                        string message;
                        if (dependentCount == 0)
                        {
                            message = "No Dependents";
                            Colonist_ID_Finder_Label.ForeColor = Color.LimeGreen;
                        }
                        else if (dependentCount == 1)
                        {
                            message = "1 Dependent";
                            Colonist_ID_Finder_Label.ForeColor = Color.Red;
                        }
                        else
                        {
                            message = dependentCount + " Dependents";
                            Colonist_ID_Finder_Label.ForeColor = Color.Red;
                        }

                        Colonist_ID_Finder_Label.Text = message;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return;
                    }
                }
            }

        }

        private void ColonyAss_CNoAssID_Search_Button_Click(object sender, EventArgs e)
        {
            string Colony_Lot_No = ColonyAss_CNoAssID_ComboBox.Text;
            int ColonyAssignmentCount = 0;

            if (string.IsNullOrEmpty(Colony_Lot_No))
            {
                MessageBox.Show("Please enter a Colony Lot No", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query_fetch_Dependent = "SELECT count(*) FROM Colony_Assignment WHERE Colony_Lot_No = @Colony_Lot_No";
                using (SqlConnection connection1 = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
                {

                    SqlCommand command1 = new SqlCommand(query_fetch_Dependent, connection1);
                    command1.Parameters.AddWithValue("@Colony_Lot_No", Colony_Lot_No);

                    try
                    {
                        connection1.Open();
                        ColonyAssignmentCount = (int)command1.ExecuteScalar();

                        string message;
                        if (ColonyAssignmentCount == 0)
                        {
                            message = "No Colonist Assigned";
                            Colony_ID_Finder_Label.ForeColor = Color.LimeGreen;
                        }
                        else if (ColonyAssignmentCount == 1)
                        {
                            message = "1 Colonist Assigned";
                            Colony_ID_Finder_Label.ForeColor = Color.Red;
                        }
                        else
                        {
                            message = ColonyAssignmentCount + " Colonist Assigned";
                            Colony_ID_Finder_Label.ForeColor = Color.Red;
                        }

                        Colony_ID_Finder_Label.Text = message;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return;
                    }
                }
            }

        }

        private void House_Assignment_Management_Load(object sender, EventArgs e)
        {
            try
            {
                ColonyAss_CAssID_ComboBox.Focus();
                con.Open();
                SqlCommand command = new SqlCommand("Select (Colonist_ID)from Colonist", con);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Colonist_ID", typeof(int));
                table.Load(reader);
                ColonyAss_CAssID_ComboBox.ValueMember = "Colonist_ID";
                ColonyAss_CAssID_ComboBox.DataSource = table;
                con.Close();
                ColonyAss_CAssID_ComboBox.Text = "";
                //////////////////////////////////////////////
                con.Open();
                SqlCommand command3 = new SqlCommand("Select (Colony_Lot_No)from Mars_Colony", con);
                SqlDataReader reader3;
                reader3 = command3.ExecuteReader();
                DataTable table3 = new DataTable();
                table3.Columns.Add("Colony_Lot_No", typeof(int));
                table3.Load(reader3);
                ColonyAss_CNoAssID_ComboBox.ValueMember = "Colony_Lot_No";
                ColonyAss_CNoAssID_ComboBox.DataSource = table3;
                con.Close();
                ColonyAss_CNoAssID_ComboBox.Text = "";
                //////////////////////////////////////////////
                con.Open();
                SqlCommand command2 = new SqlCommand("Select (Colony_Assignment_ID)from Colony_Assignment", con);
                SqlDataReader reader2;
                reader2 = command2.ExecuteReader();
                DataTable table2 = new DataTable();
                table2.Columns.Add("Colony_Assignment_ID", typeof(int));
                table2.Load(reader2);
                ColonyAss_ColonyAssID_ComboBox.ValueMember = "Colony_Assignment_ID";
                ColonyAss_ColonyAssID_ComboBox.DataSource = table2;
                con.Close();
                ColonyAss_ColonyAssID_ComboBox.Text = "";

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

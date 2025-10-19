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
    public partial class Mars_Colony_Management : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; ");

        public Mars_Colony_Management()
        {
            InitializeComponent();
        }

        private void Colony_Clear_Button_Click(object sender, EventArgs e)
        {
            ColonyID_ComboBox.Text = "";
            Colony_Room_TextBox.Clear();
            Colony_SquareFeet_TextBox.Clear();
            Colony_Room_TextBox.Focus();

        }

        private void Colony_Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Colony_ID = ColonyID_ComboBox.Text;
                string Colony_Room = Colony_Room_TextBox.Text;
                string Colony_SquareFeet = Colony_SquareFeet_TextBox.Text;
                

                if (string.IsNullOrEmpty(Colony_ID))
                {
                    if (Colony_Room == "" || Colony_SquareFeet == "" )
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string ColonyReg_Query_insert_1 = "INSERT INTO Mars_Colony (No_of_Rooms, Square_Feet) " +
                             "VALUES('" + Colony_Room + "','" + Colony_SquareFeet + "')" + "SELECT SCOPE_IDENTITY();";
                        con.Open();
                        SqlCommand Register = new SqlCommand(ColonyReg_Query_insert_1, con);
                        int colony_ID = Convert.ToInt32(Register.ExecuteScalar());
                        con.Close();

                        ColonyID_ComboBox.Text = colony_ID.ToString();
                        string Col_ID = ColonyID_ComboBox.Text;
                        MessageBox.Show("Record Added Successfully \nRegistration No: " + Col_ID, "Register Mars Colony", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    con.Open();
                    // Enable IDENTITY_INSERT
                    string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Mars_Colony ON;";
                    using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                    {
                        enableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    //------------------------------------------
                    if (Colony_Room == "" || Colony_SquareFeet == "" )
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string ColonyReg_Query_insert_2 = "Insert into Mars_Colony (Colony_Lot_No ,No_of_Rooms, Square_Feet) " +
                             "Values('" + Colony_ID + "','" + Colony_Room + "','" + Colony_SquareFeet + "')";

                        SqlCommand Register2 = new SqlCommand(ColonyReg_Query_insert_2, con);
                        Register2.ExecuteNonQuery();

                        MessageBox.Show("Record Added SucessFully", "Register Mars Colony", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    //------------------------------------
                    // Disable IDENTITY_INSERT
                    string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Mars_Colony OFF;";
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

        private void ColonyID_Search_Button_Click(object sender, EventArgs e)
        {
            string Colony_Lot_No = ColonyID_ComboBox.Text;

            if (string.IsNullOrEmpty(Colony_Lot_No))
            {
                MessageBox.Show("Please enter a Colony Lot No.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Mars_Colony WHERE Colony_Lot_No = @Colony_Lot_No";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Colony_Lot_No", Colony_Lot_No);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ColonyID_ComboBox.Text = reader["Colony_Lot_No"].ToString();
                            Colony_Room_TextBox.Text = reader["No_of_Rooms"].ToString();
                            Colony_SquareFeet_TextBox.Text = reader["Square_Feet"].ToString();
                            

                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Colony Lot No.");
                        }
                    }
                }
            }

        }

        private void Colony_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Colony_Lot_No = ColonyID_ComboBox.Text;
                string Colony_Room = Colony_Room_TextBox.Text;
                string Colony_SquareFeet = Colony_SquareFeet_TextBox.Text;

                string Colony_Query_update = "UPDATE Mars_Colony SET " +
                      "No_of_Rooms = '" + Colony_Room + "', " +
                      "Square_Feet = '" + Colony_SquareFeet + "' " +
                      "WHERE Colony_Lot_No = '" + Colony_Lot_No + "'";
                if (string.IsNullOrEmpty(Colony_Lot_No))
                {
                    MessageBox.Show("Enter a Colonist ID to update the record", "Enter Colonist ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Colony_Room == "" || Colony_SquareFeet == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        SqlCommand Update = new SqlCommand(Colony_Query_update, con);
                        Update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated SucessFully", "Update Mars Colony", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Colony_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Colony_Lot_No = ColonyID_ComboBox.Text;
                    if (string.IsNullOrEmpty(Colony_Lot_No))
                    {
                        MessageBox.Show("Enter a Colony_Lot_No to Delete the record", "Enter Colony Lot No", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Colony_Delete_Query = "DELETE from Mars_Colony WHERE Colony_Lot_No = " + Colony_Lot_No + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(Colony_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
                        Colony_Clear_Button.PerformClick();
                        MessageBox.Show("Record Have Been Deleted", "Colony Lot No Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Mars_Colony_Management_Load(object sender, EventArgs e)
        {
            try
            {
                Colony_Room_TextBox.Focus();
                con.Open();
                SqlCommand command = new SqlCommand("Select (Colony_Lot_No)from Mars_Colony", con);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Colony_Lot_No", typeof(int));
                table.Load(reader);
                ColonyID_ComboBox.ValueMember = "Colony_Lot_No";
                ColonyID_ComboBox.DataSource = table;
                con.Close();
                ColonyID_ComboBox.Text = "";
                
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

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
    public partial class Jet_Assignment_Management : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; ");

        public Jet_Assignment_Management()
        {
            InitializeComponent();
        }

        private void JetAss_Clear_Button_Click(object sender, EventArgs e)
        {
            JetAss_JAssID_ComboBox.Text = "";
            JetAss_PilotID_ComboBox.Text = "";
            JetAss_JetID_ComboBox.Text = "";
            JetAss_PilotID_ComboBox.Focus();
        }

        private void JetAss_Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Jet_Assignment_ID = JetAss_JAssID_ComboBox.Text;
                string Pilot_ID = JetAss_PilotID_ComboBox.Text;
                string EJet_ID = JetAss_JetID_ComboBox.Text;
                
                
                if (string.IsNullOrEmpty(Jet_Assignment_ID))
                {
                    if (Pilot_ID == "" || EJet_ID == "" )
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string JetAss_Query_insert_1 = "INSERT INTO Jet_Assignment (Pilot_ID, EJet_ID) " +
                             "VALUES('" + Pilot_ID + "','" + EJet_ID + "')" + "SELECT SCOPE_IDENTITY();";
                        con.Open();
                        SqlCommand Register = new SqlCommand(JetAss_Query_insert_1, con);
                        int jetass_ID = Convert.ToInt32(Register.ExecuteScalar());
                        con.Close();

                        JetAss_JAssID_ComboBox.Text = jetass_ID.ToString();
                        string jet_ass_ID = JetAss_JAssID_ComboBox.Text;
                        MessageBox.Show("Record Added Successfully \nRegistration No: " + jet_ass_ID, "Register Jet Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    con.Open();
                    // Enable IDENTITY_INSERT
                    string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Jet_Assignment ON;";
                    using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                    {
                        enableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    //------------------------------------------
                    if (Pilot_ID == "" || EJet_ID == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string JetAss_Query_insert_2 = "Insert into Jet_Assignment (Jet_Assignment_ID ,Pilot_ID, EJet_ID) " +
                             "Values('" + Jet_Assignment_ID + "','" + Pilot_ID + "','" + EJet_ID + "')";

                        SqlCommand Register2 = new SqlCommand(JetAss_Query_insert_2, con);
                        Register2.ExecuteNonQuery();

                        MessageBox.Show("Record Added SucessFully", "Register Jet Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    //------------------------------------
                    // Disable IDENTITY_INSERT
                    string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Jet_Assignment OFF;";
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

        private void JetAss_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Jet_Assignment_ID = JetAss_JAssID_ComboBox.Text;
                string Pilot_ID = JetAss_PilotID_ComboBox.Text;
                string EJet_ID = JetAss_JetID_ComboBox.Text;

                string Jet_Ass_Query_update = "UPDATE Jet_Assignment SET " +
                      "Pilot_ID = '" + Pilot_ID + "', " +
                      "EJet_ID = '" + EJet_ID + "' " +
                      "WHERE Jet_Assignment_ID = '" + Jet_Assignment_ID + "'";
                if (string.IsNullOrEmpty(Jet_Assignment_ID))
                {
                    MessageBox.Show("Enter a Jet Assignment ID to update the record", "Enter Jet Assignment ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Pilot_ID == "" || EJet_ID == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        SqlCommand Update = new SqlCommand(Jet_Ass_Query_update, con);
                        Update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated SucessFully", "Update Jet Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void JetAss_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Jet_Assignment_ID = JetAss_JAssID_ComboBox.Text;
                    if (string.IsNullOrEmpty(Jet_Assignment_ID))
                    {
                        MessageBox.Show("Enter a Jet Assignment ID to Delete the record", "Enter Jet Assignment ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string JetAss_Delete_Query = "DELETE from Jet_Assignment WHERE Jet_Assignment_ID = " + Jet_Assignment_ID + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(JetAss_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Have Been Deleted", "Jet Assignment Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void JetAss_JetID_Search_Button_Click(object sender, EventArgs e)
        {
            string EJet_ID = JetAss_JetID_ComboBox.Text;

            if (string.IsNullOrEmpty(EJet_ID))
            {
                Jet_ID_Finder_Label.Text = "";
                MessageBox.Show("Please enter a EJet ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM EJet WHERE EJet_ID = @EJet_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EJet_ID", EJet_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Jet_ID_Finder_Label.Text = "Available";
                            Jet_ID_Finder_Label.ForeColor = Color.LimeGreen;
                        }
                        else
                        {
                            Jet_ID_Finder_Label.Text = "Not Available";
                            Jet_ID_Finder_Label.ForeColor = Color.Red;
                            MessageBox.Show("No record found for the given Jet ID.");
                        }
                    }
                }
            }

        }

        private void JetAss_PilotID_Search_Button_Click(object sender, EventArgs e)
        {
            string Pilot_ID = JetAss_PilotID_ComboBox.Text;

            if (string.IsNullOrEmpty(Pilot_ID))
            {
                MessageBox.Show("Please enter a Pilot ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Pilot WHERE Pilot_ID = @Pilot_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Pilot_ID", Pilot_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Pilot_Name_TextBox.Text = reader["First_Name"].ToString();
                            
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Pilot ID.");
                        }
                    }
                }
            }

        }

        private void JetAss_JAssID_Search_Button_Click(object sender, EventArgs e)
        {
            string Jet_Assignment_ID = JetAss_JAssID_ComboBox.Text;

            if (string.IsNullOrEmpty(Jet_Assignment_ID))
            {
                MessageBox.Show("Please enter a Jet Assignment ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Jet_Assignment WHERE Jet_Assignment_ID = @Jet_Assignment_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Jet_Assignment_ID", Jet_Assignment_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            JetAss_JAssID_ComboBox.Text = reader["Jet_Assignment_ID"].ToString();
                            JetAss_PilotID_ComboBox.Text = reader["Pilot_ID"].ToString();
                            JetAss_JetID_ComboBox.Text = reader["EJet_ID"].ToString();
                            JetAss_PilotID_Search_Button.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Jet Assignment ID.");
                        }
                    }
                }
            }

        }

        private void Jet_Assignment_Management_Load(object sender, EventArgs e)
        {
            try
            {
                JetAss_PilotID_ComboBox.Focus();
                con.Open();
                SqlCommand command = new SqlCommand("Select (Jet_Assignment_ID)from Jet_Assignment", con);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Jet_Assignment_ID", typeof(int));
                table.Load(reader);
                JetAss_JAssID_ComboBox.ValueMember = "Jet_Assignment_ID";
                JetAss_JAssID_ComboBox.DataSource = table;
                con.Close();
                JetAss_JAssID_ComboBox.Text = "";
                //////////////////////////////////////////////
                con.Open();
                SqlCommand command3 = new SqlCommand("Select (Pilot_ID)from Pilot", con);
                SqlDataReader reader3;
                reader3 = command3.ExecuteReader();
                DataTable table3 = new DataTable();
                table3.Columns.Add("Pilot_ID", typeof(int));
                table3.Load(reader3);
                JetAss_PilotID_ComboBox.ValueMember = "Pilot_ID";
                JetAss_PilotID_ComboBox.DataSource = table3;
                con.Close();
                JetAss_PilotID_ComboBox.Text = "";
                //////////////////////////////////////////////
                con.Open();
                SqlCommand command2 = new SqlCommand("Select (EJet_ID)from EJet", con);
                SqlDataReader reader2;
                reader2 = command2.ExecuteReader();
                DataTable table2 = new DataTable();
                table2.Columns.Add("EJet_ID", typeof(int));
                table2.Load(reader2);
                JetAss_JetID_ComboBox.ValueMember = "EJet_ID";
                JetAss_JetID_ComboBox.DataSource = table2;
                con.Close();
                JetAss_JetID_ComboBox.Text = "";

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

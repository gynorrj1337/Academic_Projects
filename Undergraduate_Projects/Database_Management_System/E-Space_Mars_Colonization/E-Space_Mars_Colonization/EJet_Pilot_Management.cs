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
    public partial class EJet_Pilot_Management : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; ");

        public EJet_Pilot_Management()
        {
            InitializeComponent();
        }

        private void PilotReg_Clear_Button_Click(object sender, EventArgs e)
        {
            PilotID_Reg_ComboBox.Text = "";
            FName_TextBox.Clear();
            Designation_TextBox.Clear();
            ExpHour_Textbox.Clear();
            FName_TextBox.Focus();

        }

        private void PilotReg_Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Pilot_ID = PilotID_Reg_ComboBox.Text;
                string First_Name = FName_TextBox.Text;
                string Designation = Designation_TextBox.Text;
                string ExpHour = ExpHour_Textbox.Text;
                
                if (string.IsNullOrEmpty(Pilot_ID))
                {
                    if (First_Name == "" || Designation == "" || ExpHour == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string PilotReg_Query_insert_1 = "INSERT INTO Pilot (First_Name, Experience, Designation) " +
                             "VALUES('" + First_Name + "','" + ExpHour + "','" + Designation + "')" + "SELECT SCOPE_IDENTITY();";
                        con.Open();
                        SqlCommand Register = new SqlCommand(PilotReg_Query_insert_1, con);
                        int pilot_ID = Convert.ToInt32(Register.ExecuteScalar());
                        con.Close();

                        PilotID_Reg_ComboBox.Text = pilot_ID.ToString();
                        string Pil_ID = PilotID_Reg_ComboBox.Text;
                        MessageBox.Show("Record Added Successfully \nRegistration No: " + Pil_ID, "Register Pilot", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    con.Open();
                    // Enable IDENTITY_INSERT
                    string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Pilot ON;";
                    using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                    {
                        enableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    //------------------------------------------
                    if (First_Name == "" || Designation == "" || ExpHour == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string PilReg_Query_insert_2 = "Insert into Pilot (Pilot_ID ,First_Name ,Experience, Designation) " +
                             "Values('" + Pilot_ID + "','" + First_Name + "','" + ExpHour + "','" + Designation + "')";

                        SqlCommand Register2 = new SqlCommand(PilReg_Query_insert_2, con);
                        Register2.ExecuteNonQuery();

                        MessageBox.Show("Record Added SucessFully", "Register Pilot", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    //------------------------------------
                    // Disable IDENTITY_INSERT
                    string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Pilot OFF;";
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

        private void ColReg_Search_Button_Click(object sender, EventArgs e)
        {
            string Pilot_ID = PilotID_Reg_ComboBox.Text;

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
                            PilotID_Reg_ComboBox.Text = reader["Pilot_ID"].ToString();
                            FName_TextBox.Text = reader["First_Name"].ToString();
                            Designation_TextBox.Text = reader["Designation"].ToString();
                            ExpHour_Textbox.Text = reader["Experience"].ToString();
                            

                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Pilot ID.");
                        }
                    }
                }
            }

        }

        private void EJet_Pilot_Management_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Select (Pilot_ID)from Pilot", con);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Pilot_ID", typeof(int));
                table.Load(reader);
                PilotID_Reg_ComboBox.ValueMember = "Pilot_ID";
                PilotID_Reg_ComboBox.DataSource = table;
                con.Close();
                PilotID_Reg_ComboBox.Text = "";
                
                //////////////////////////////////////////////

                con.Open();
                SqlCommand command3 = new SqlCommand("Select (Pilot_ID)from Pilot", con);
                SqlDataReader reader3;
                reader3 = command3.ExecuteReader();
                DataTable table3 = new DataTable();
                table3.Columns.Add("Pilot_ID", typeof(int));
                table3.Load(reader3);
                PilotID_Qua_ComboBox.ValueMember = "Pilot_ID";
                PilotID_Qua_ComboBox.DataSource = table3;
                con.Close();
                PilotID_Qua_ComboBox.Text = "";
                /////////////////////////////////////////////

                con.Open();
                SqlCommand command2 = new SqlCommand("Select (Pilot_Qualification_ID)from Pilot_Qualification", con);
                SqlDataReader reader2;
                reader2 = command2.ExecuteReader();
                DataTable table2 = new DataTable();
                table2.Columns.Add("Pilot_Qualification_ID", typeof(int));
                table2.Load(reader2);
                PilotID_QuaID_ComboBox.ValueMember = "Pilot_Qualification_ID";
                PilotID_QuaID_ComboBox.DataSource = table2;
                con.Close();
                PilotID_QuaID_ComboBox.Text = "";

            }
            catch (SqlException ex)
            {
                string message = "Search Error:";
                message += ex.Message;
                MessageBox.Show(message);
                con.Close();
            }
        }

        private void PilotReg_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Pilot_ID = PilotID_Reg_ComboBox.Text;
                string First_Name = FName_TextBox.Text;
                string Designation = Designation_TextBox.Text;
                string ExpHour = ExpHour_Textbox.Text;


                string Pilot_Query_update = "UPDATE Pilot SET " +
                      "First_Name = '" + First_Name + "', " +
                      "Experience = '" + ExpHour + "', " +
                      "Designation = '" + Designation + "' " +
                      "WHERE Pilot_ID = '" + Pilot_ID + "'";
                if (string.IsNullOrEmpty(Pilot_ID))
                {
                    MessageBox.Show("Enter a Pilot ID to update the record", "Enter Pilot ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (First_Name == "" || Designation == "" || ExpHour == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        SqlCommand Update = new SqlCommand(Pilot_Query_update, con);
                        Update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated SucessFully", "Update Pilot", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void PilotRegDelete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Pilot_ID = PilotID_Reg_ComboBox.Text;
                    if (string.IsNullOrEmpty(Pilot_ID))
                    {
                        MessageBox.Show("Enter a Pilot ID to Delete the record", "Enter Pilot ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Pilot_Delete_Query = "DELETE from Pilot WHERE Pilot_ID = " + Pilot_ID + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(Pilot_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
                        PilotReg_Clear_Button.PerformClick();
                        MessageBox.Show("Record Have Been Deleted", "Pilott Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        /////////////////////////////////////////////
        /////////Pilot Qualification////////////////
        ////////////////////////////////////////////
        
        private void PilotQua_Clear_Button_Click(object sender, EventArgs e)
        {
            PilotID_QuaID_ComboBox.Text = "";
            PilotID_Qua_ComboBox.Text = "";
            Pilot_Qua_Name_TextBox.Clear();
            Pilot_Qualification_TextBox.Clear();
            Pilot_Experience_TextBox.Clear();
            Pilot_Level_TextBox.Clear();
            PilotID_Qua_ComboBox.Focus();

        }

        private void PilotQua_Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Pilot_Qualification_ID = PilotID_QuaID_ComboBox.Text;
                string Qua_Pilot_ID = PilotID_Qua_ComboBox.Text;
                string Pilot_Qualification = Pilot_Qualification_TextBox.Text;
                string Pilot_Experience = Pilot_Experience_TextBox.Text;
                string Pilot_Level = Pilot_Level_TextBox.Text;
                string Pilot_Name = Pilot_Qua_Name_TextBox.Text;

                if (string.IsNullOrEmpty(Pilot_Qualification_ID))
                {
                    if (Qua_Pilot_ID == "" || Pilot_Name == "" || Pilot_Qualification == "" || Pilot_Experience == "" || Pilot_Level == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string PilotQuaReg_Query_insert_1 = "INSERT INTO Pilot_Qualification (Pilot_ID, Qualification_Description, Pilot_Experience, Pilot_Level) " +
                             "VALUES('" + Qua_Pilot_ID + "','" + Pilot_Qualification + "','" + Pilot_Experience + "','" + Pilot_Level + "')" + "SELECT SCOPE_IDENTITY();";
                        con.Open();
                        SqlCommand Register = new SqlCommand(PilotQuaReg_Query_insert_1, con);
                        int Qua_Pilo_ID = Convert.ToInt32(Register.ExecuteScalar());
                        con.Close();

                        PilotID_QuaID_ComboBox.Text = Qua_Pilo_ID.ToString();
                        string PilQua_ID = PilotID_QuaID_ComboBox.Text;
                        MessageBox.Show("Record Added Successfully \nRegistration No: " + PilQua_ID, "Register Pilot Qualification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    con.Open();
                    // Enable IDENTITY_INSERT
                    string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Pilot_Qualification ON;";
                    using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                    {
                        enableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    //------------------------------------------
                    if (Qua_Pilot_ID == "" || Pilot_Name == "" || Pilot_Qualification == "" || Pilot_Experience == "" || Pilot_Level == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string PilotQuaReg_Query_insert_2 = "Insert into Pilot_Qualification (Pilot_Qualification_ID, Pilot_ID, Qualification_Description, Pilot_Experience, Pilot_Level) " +
                             "Values('" + Pilot_Qualification_ID + "','" + Qua_Pilot_ID + "','" + Pilot_Qualification + "','" + Pilot_Experience + "','" + Pilot_Level + "')";

                        SqlCommand Register2 = new SqlCommand(PilotQuaReg_Query_insert_2, con);
                        Register2.ExecuteNonQuery();

                        MessageBox.Show("Record Added SucessFully", "Register Pilot Qualification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    //------------------------------------
                    // Disable IDENTITY_INSERT
                    string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Pilot_Qualification OFF;";
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

        private void Pilot_QuaID_Search_Button_Click(object sender, EventArgs e)
        {
            string Pilot_Qualification_ID = PilotID_QuaID_ComboBox.Text;

            if (string.IsNullOrEmpty(Pilot_Qualification_ID))
            {
                MessageBox.Show("Please enter a Pilot Qualification ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Pilot_Qualification WHERE Pilot_Qualification_ID = @Pilot_Qualification_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Pilot_Qualification_ID", Pilot_Qualification_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            PilotID_QuaID_ComboBox.Text = reader["Pilot_Qualification_ID"].ToString();
                            PilotID_Qua_ComboBox.Text = reader["Pilot_ID"].ToString();
                            Pilot_Qualification_TextBox.Text = reader["Qualification_Description"].ToString();
                            Pilot_Experience_TextBox.Text = reader["Pilot_Experience"].ToString();
                            Pilot_Level_TextBox.Text = reader["Pilot_Level"].ToString();
                            PilotID_PQua_Search_Button.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Pilot Qualification ID.");
                        }
                    }
                }
            }

        }

        private void PilotID_PQua_Search_Button_Click(object sender, EventArgs e)
        {
            string Pilot_ID = PilotID_Qua_ComboBox.Text;

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
                            Pilot_Qua_Name_TextBox.Text = reader["First_Name"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Pilot ID.");
                        }
                    }
                }
            }

        }

        private void PilotQua_Update_Button_Click(object sender, EventArgs e)
        {

            try
            {
                string Pilot_Qualification_ID = PilotID_QuaID_ComboBox.Text;
                string Qua_Pilot_ID = PilotID_Qua_ComboBox.Text;
                string Pilot_Qualification = Pilot_Qualification_TextBox.Text;
                string Pilot_Experience = Pilot_Experience_TextBox.Text;
                string Pilot_Level = Pilot_Level_TextBox.Text;
                string Pilot_Name = Pilot_Qua_Name_TextBox.Text;


                string Pilot_Query_update = "UPDATE Pilot_Qualification SET " +
                      "Pilot_ID = '" + Qua_Pilot_ID + "', " +
                      "Qualification_Description = '" + Pilot_Qualification + "', " +
                      "Pilot_Experience = '" + Pilot_Experience + "', " +
                      "Pilot_Level = '" + Pilot_Level + "'";


                if (string.IsNullOrEmpty(Pilot_Qualification_ID))
                {
                    MessageBox.Show("Enter a Pilot Qualification ID to update the record", "Enter Pilot ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Qua_Pilot_ID == "" || Pilot_Name == "" || Pilot_Qualification == "" || Pilot_Experience == "" || Pilot_Level == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        SqlCommand Update = new SqlCommand(Pilot_Query_update, con);
                        Update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated SucessFully", "Update Pilot", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void PilotQua_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Pilot_Qualification_ID = PilotID_QuaID_ComboBox.Text;
                    if (string.IsNullOrEmpty(Pilot_Qualification_ID))
                    {
                        MessageBox.Show("Enter a Pilot Qualification ID to Delete the record", "Enter Pilot Qualification ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Pilot_Qualification_Delete_Query = "DELETE from Pilot_Qualification WHERE Pilot_Qualification_ID = " + Pilot_Qualification_ID + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(Pilot_Qualification_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
                        PilotQua_Clear_Button.PerformClick();
                        MessageBox.Show("Record Have Been Deleted", "Pilot Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


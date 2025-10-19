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
    public partial class FeedBack_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; ");

        public FeedBack_Form()
        {
            InitializeComponent();
            Tester_Type_ComboBox.SelectedIndexChanged += Tester_Type_ComboBox_SelectedIndexChanged;
        }

        private void Tester_Type_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tester_Type_ComboBox.Text == "Developer")
            {
                Developer_Only_GroupBox.Visible = true;
                label8.Location = new System.Drawing.Point(13, 495);
                FeedBack_Clear_Button.Location = new System.Drawing.Point(25, 577);
                FeedBack_Delete_Button.Location = new System.Drawing.Point(140, 577);
                FeedBack_Update_Button.Location = new System.Drawing.Point(766, 577);
                FeedBack_Register_Button.Location = new System.Drawing.Point(880, 577);
                Q10_TextBox.Location = new System.Drawing.Point(23, 515);
                Developer_Only_GroupBox.Location = new System.Drawing.Point(15, 320);
            }
            else
            {
                Developer_Only_GroupBox.Visible = false;
                label8.Location = new System.Drawing.Point(13, 325);
                FeedBack_Clear_Button.Location = new System.Drawing.Point(25, 407);
                FeedBack_Delete_Button.Location = new System.Drawing.Point(140, 407);
                FeedBack_Update_Button.Location = new System.Drawing.Point(766, 407);
                FeedBack_Register_Button.Location = new System.Drawing.Point(880, 407);
                Q10_TextBox.Location = new System.Drawing.Point(23, 345);
                

            }
        }

        private void FeedBack_Clear_Button_Click(object sender, EventArgs e)
        {
            TesterID_ComboBox.Text = "";
            Tester_Name_TextBox.Clear();
            Tester_Type_ComboBox.Text = "";
            Q1_ComboBox.Text = "";
            Q2_ComboBox.Text = "";
            Q3_ComboBox.Text = "";
            Q4_ComboBox.Text = "";
            Q5_ComboBox.Text = "";
            Q6_ComboBox.Text = "";
            Q7_ComboBox.Text = "";
            Q8_ComboBox.Text = "";
            Q9_ComboBox.Text = "";
            Q10_TextBox.Text = "";
            Tester_Name_TextBox.Focus();
        }

        private void FeedBack_Register_Button_Click(object sender, EventArgs e)
        {
            if (Tester_Type_ComboBox.Text == "Developer")
            {
                try
                {
                    string Tester_ID = TesterID_ComboBox.Text;
                    string Tester_Name = Tester_Name_TextBox.Text;
                    string Tester_Type = Tester_Type_ComboBox.Text;
                    string Q1 = Q1_ComboBox.Text;
                    string Q2 = Q2_ComboBox.Text;
                    string Q3 = Q3_ComboBox.Text;
                    string Q4 = Q4_ComboBox.Text;
                    string Q5 = Q5_ComboBox.Text;
                    string Q6 = Q6_ComboBox.Text;
                    string Q7 = Q7_ComboBox.Text;
                    string Q8 = Q8_ComboBox.Text;
                    string Q9 = Q9_ComboBox.Text;
                    string Q10 = Q10_TextBox.Text;

                    if (string.IsNullOrEmpty(Tester_ID))
                    {
                        if (Tester_Type == "" || Q1 == "" || Q2 == "" || Q3 == "" || Q4 == "" || Q5 == "" || Q6 == "" || Q7 == "" || Q8 == "" || Q9 == "" || Q10 == "")
                        {
                            MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string FeedBack_Query_insert_1 = "INSERT INTO Tester (Tester_Name, Tester_Type, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10) " +
                                 "VALUES('" + Tester_Name + "','" + Tester_Type + "','" + Q1 + "','" + Q2 + "','" + Q3 + "','" + Q4 + "','" + Q5 + "','" + Q6 + "','" + Q7 + "','" + Q8 + "','" + Q9 + "','" + Q10 + "')" + "SELECT SCOPE_IDENTITY();";
                            con.Open();
                            SqlCommand Register = new SqlCommand(FeedBack_Query_insert_1, con);
                            int tester_ID = Convert.ToInt32(Register.ExecuteScalar());
                            con.Close();

                            TesterID_ComboBox.Text = tester_ID.ToString();
                            string Tes_ID = TesterID_ComboBox.Text;
                            MessageBox.Show("Record Added Successfully \nRegistration No: " + Tes_ID, "Add Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        con.Open();
                        // Enable IDENTITY_INSERT
                        string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Tester ON;";
                        using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                        {
                            enableIdentityInsertCommand.ExecuteNonQuery();
                        }
                        //------------------------------------------
                        if (Tester_Type == "" || Q1 == "" || Q2 == "" || Q3 == "" || Q4 == "" || Q5 == "" || Q6 == "" || Q7 == "" || Q8 == "" || Q9 == "" || Q10 == "")
                        {
                            MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string Tester_Query_insert_2 = "Insert into Tester (Tester_ID ,Tester_Name, Tester_Type, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10) " +
                                 "Values('" + Tester_ID + "','" + Tester_Name + "','" + Tester_Type + "','" + Q1 + "','" + Q2 + "','" + Q3 + "','" + Q4 + "','" + Q5 + "','" + Q6 + "','" + Q7 + "','" + Q8 + "','" + Q9 + "','" + Q10 + "')";

                            SqlCommand Register2 = new SqlCommand(Tester_Query_insert_2, con);
                            Register2.ExecuteNonQuery();

                            MessageBox.Show("Record Added SucessFully", "Add Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                        //------------------------------------
                        // Disable IDENTITY_INSERT
                        string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Tester OFF;";
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
            else if (Tester_Type_ComboBox.Text == "Non-Technical")
            {
                try
                {
                    string Tester_ID = TesterID_ComboBox.Text;
                    string Tester_Name = Tester_Name_TextBox.Text;
                    string Tester_Type = Tester_Type_ComboBox.Text;
                    string Q1 = Q1_ComboBox.Text;
                    string Q2 = Q2_ComboBox.Text;
                    string Q3 = Q3_ComboBox.Text;
                    string Q4 = Q4_ComboBox.Text;
                    string Q5 = Q5_ComboBox.Text;
                    string Q6 = Q6_ComboBox.Text;
                    string Q7 = Q7_ComboBox.Text;
                    string Q8 = Q8_ComboBox.Text;
                    string Q9 = Q9_ComboBox.Text;
                    string Q10 = Q10_TextBox.Text;

                    if (string.IsNullOrEmpty(Tester_ID))
                    {
                        if (Tester_Type == "" || Q1 == "" || Q2 == "" || Q3 == "" || Q4 == "" || Q5 == "" || Q6 == "" || Q10 == "")
                        {
                            MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string FeedBack_Query_insert_1 = "INSERT INTO Tester (Tester_Name, Tester_Type, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10) " +
                                 "VALUES('" + Tester_Name + "','" + Tester_Type + "','" + Q1 + "','" + Q2 + "','" + Q3 + "','" + Q4 + "','" + Q5 + "','" + Q6 + "','" + Q7 + "','" + Q8 + "','" + Q9 + "','" + Q10 + "')" + "SELECT SCOPE_IDENTITY();";
                            con.Open();
                            SqlCommand Register = new SqlCommand(FeedBack_Query_insert_1, con);
                            int tester_ID = Convert.ToInt32(Register.ExecuteScalar());
                            con.Close();

                            TesterID_ComboBox.Text = tester_ID.ToString();
                            string Tes_ID = TesterID_ComboBox.Text;
                            MessageBox.Show("Record Added Successfully \nRegistration No: " + Tes_ID, "Add Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        con.Open();
                        // Enable IDENTITY_INSERT
                        string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Tester ON;";
                        using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                        {
                            enableIdentityInsertCommand.ExecuteNonQuery();
                        }
                        //------------------------------------------
                        if (Tester_Type == "" || Q1 == "" || Q2 == "" || Q3 == "" || Q4 == "" || Q5 == "" || Q6 == "" || Q10 == "")
                        {
                            MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string Tester_Query_insert_2 = "Insert into Tester (Tester_ID ,Tester_Name, Tester_Type, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10) " +
                                 "Values('" + Tester_ID + "','" + Tester_Name + "','" + Tester_Type + "','" + Q1 + "','" + Q2 + "','" + Q3 + "','" + Q4 + "','" + Q5 + "','" + Q6 + "','" + Q7 + "','" + Q8 + "','" + Q9 + "','" + Q10 + "')";

                            SqlCommand Register2 = new SqlCommand(Tester_Query_insert_2, con);
                            Register2.ExecuteNonQuery();

                            MessageBox.Show("Record Added SucessFully", "Add Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                        //------------------------------------
                        // Disable IDENTITY_INSERT
                        string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Tester OFF;";
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
            else
            {
                MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void FeedBack_Update_Button_Click(object sender, EventArgs e)
        {
            if (Tester_Type_ComboBox.Text == "Developer")
            {
                try
                {
                    string Tester_ID = TesterID_ComboBox.Text;
                    string Tester_Name = Tester_Name_TextBox.Text;
                    string Tester_Type = Tester_Type_ComboBox.Text;
                    string Q1 = Q1_ComboBox.Text;
                    string Q2 = Q2_ComboBox.Text;
                    string Q3 = Q3_ComboBox.Text;
                    string Q4 = Q4_ComboBox.Text;
                    string Q5 = Q5_ComboBox.Text;
                    string Q6 = Q6_ComboBox.Text;
                    string Q7 = Q7_ComboBox.Text;
                    string Q8 = Q8_ComboBox.Text;
                    string Q9 = Q9_ComboBox.Text;
                    string Q10 = Q10_TextBox.Text;

                    string Tester_Query_update = "UPDATE Tester SET " +
                          "Tester_Name = '" + Tester_Name + "', " +
                          "Tester_Type = '" + Tester_Type + "', " +
                          "Q1 = '" + Q1 + "', " +
                          "Q2 = '" + Q2 + "', " +
                          "Q3 = '" + Q3 + "', " +
                          "Q4 = '" + Q4 + "', " +
                          "Q5 = '" + Q5 + "', " +
                          "Q6 = '" + Q6 + "', " +
                          "Q7 = '" + Q7 + "', " +
                          "Q8 = '" + Q8 + "', " +
                          "Q9 = '" + Q9 + "', " +
                          "Q10 = '" + Q10 + "' " +
                          "WHERE Tester_ID = '" + Tester_ID + "'";
                    if (string.IsNullOrEmpty(Tester_ID))
                    {
                        MessageBox.Show("Enter a Tester ID to update the record", "Enter Tester ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (Tester_Type == "" || Q1 == "" || Q2 == "" || Q3 == "" || Q4 == "" || Q5 == "" || Q6 == "" || Q7 == "" || Q8 == "" || Q9 == "" || Q10 == "")
                        {
                            MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            con.Open();
                            SqlCommand Update = new SqlCommand(Tester_Query_update, con);
                            Update.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record Updated SucessFully", "Update Tester", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else if (Tester_Type_ComboBox.Text == "Non-Technical")
            {
                try
                {
                    string Tester_ID = TesterID_ComboBox.Text;
                    string Tester_Name = Tester_Name_TextBox.Text;
                    string Tester_Type = Tester_Type_ComboBox.Text;
                    string Q1 = Q1_ComboBox.Text;
                    string Q2 = Q2_ComboBox.Text;
                    string Q3 = Q3_ComboBox.Text;
                    string Q4 = Q4_ComboBox.Text;
                    string Q5 = Q5_ComboBox.Text;
                    string Q6 = Q6_ComboBox.Text;
                    string Q7 = Q7_ComboBox.Text;
                    string Q8 = Q8_ComboBox.Text;
                    string Q9 = Q9_ComboBox.Text;
                    string Q10 = Q10_TextBox.Text;

                    string Tester_Query_update = "UPDATE Tester SET " +
                          "Tester_Name = '" + Tester_Name + "', " +
                          "Tester_Type = '" + Tester_Type + "', " +
                          "Q1 = '" + Q1 + "', " +
                          "Q2 = '" + Q2 + "', " +
                          "Q3 = '" + Q3 + "', " +
                          "Q4 = '" + Q4 + "', " +
                          "Q5 = '" + Q5 + "', " +
                          "Q6 = '" + Q6 + "', " +
                          "Q7 = '" + Q7 + "', " +
                          "Q8 = '" + Q8 + "', " +
                          "Q9 = '" + Q9 + "', " +
                          "Q10 = '" + Q10 + "' " +
                          "WHERE Tester_ID = '" + Tester_ID + "'";
                    if (string.IsNullOrEmpty(Tester_ID))
                    {
                        MessageBox.Show("Enter a Tester ID to update the record", "Enter Tester ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (Tester_Type == "" || Q1 == "" || Q2 == "" || Q3 == "" || Q4 == "" || Q5 == "" || Q6 == "" || Q10 == "")
                        {
                            MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            con.Open();
                            SqlCommand Update = new SqlCommand(Tester_Query_update, con);
                            Update.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record Updated SucessFully", "Update Tester", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Tester_Search_Button_Click(object sender, EventArgs e)
        {
            string Tester_ID = TesterID_ComboBox.Text;

            if (string.IsNullOrEmpty(Tester_ID))
            {
                MessageBox.Show("Please enter a Tester ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Tester WHERE Tester_ID = @Tester_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Tester_ID", Tester_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TesterID_ComboBox.Text = reader["Tester_ID"].ToString();
                            Tester_Name_TextBox.Text = reader["Tester_Name"].ToString();
                            Tester_Type_ComboBox.Text = reader["Tester_Type"].ToString();
                            Q1_ComboBox.Text = reader["Q1"].ToString();
                            Q2_ComboBox.Text = reader["Q2"].ToString();
                            Q3_ComboBox.Text = reader["Q3"].ToString();
                            Q4_ComboBox.Text = reader["Q4"].ToString();
                            Q5_ComboBox.Text = reader["Q5"].ToString();
                            Q6_ComboBox.Text = reader["Q6"].ToString();
                            Q7_ComboBox.Text = reader["Q7"].ToString();
                            Q8_ComboBox.Text = reader["Q8"].ToString();
                            Q9_ComboBox.Text = reader["Q9"].ToString();
                            Q10_TextBox.Text = reader["Q10"].ToString();


                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Tester ID.");
                        }
                    }
                }
            }


        }

        private void FeedBack_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Tester_ID = TesterID_ComboBox.Text;
                    if (string.IsNullOrEmpty(Tester_ID))
                    {
                        MessageBox.Show("Enter a Tester ID to Delete the record", "Enter Tester ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Tester_Delete_Query = "DELETE from Tester WHERE Tester_ID = " + Tester_ID + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(Tester_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
                        FeedBack_Clear_Button.PerformClick();
                        MessageBox.Show("Record Have Been Deleted", "Tester Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FeedBack_Form_Load(object sender, EventArgs e)
        {
            Developer_Only_GroupBox.Visible = false;
            label8.Location = new System.Drawing.Point(13, 325);
            FeedBack_Clear_Button.Location = new System.Drawing.Point(25, 407);
            FeedBack_Delete_Button.Location = new System.Drawing.Point(140, 407);
            FeedBack_Update_Button.Location = new System.Drawing.Point(766, 407);
            FeedBack_Register_Button.Location = new System.Drawing.Point(880, 407);
            Q10_TextBox.Location = new System.Drawing.Point(23, 345);

            try
            {
                Tester_Name_TextBox.Focus();
                con.Open();
                SqlCommand command = new SqlCommand("Select (Tester_ID)from Tester", con);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Tester_ID", typeof(int));
                table.Load(reader);
                TesterID_ComboBox.ValueMember = "Tester_ID";
                TesterID_ComboBox.DataSource = table;
                con.Close();
                TesterID_ComboBox.Text = "";
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

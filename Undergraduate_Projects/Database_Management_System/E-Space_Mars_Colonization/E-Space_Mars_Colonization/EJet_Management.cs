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
    public partial class EJet_Management : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; ");

        public EJet_Management()
        {
            InitializeComponent();
        }

        private void EJet_Clear_Button_Click(object sender, EventArgs e)
        {
            EJetID_Reg_ComboBox.Text = "";
            EJet_PassSeat_TextBox.Clear();
            DateTime This_Day = DateTime.Today;
            EJet_MadeYear_Picker.Text = This_Day.ToString();
            EJet_Weight_TextBox.Clear();
            Jet_Type_ComboBox.Text = "";
            Power_Source_ComboBox.Text = "";
            Nuclear_Engine_Power_Textbox.Clear();
            EJet_PassSeat_TextBox.Focus();
        }

        private void EJet_Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string EJet_ID = EJetID_Reg_ComboBox.Text;
                string Pass_Seat = EJet_PassSeat_TextBox.Text;
                EJet_MadeYear_Picker.Format = DateTimePickerFormat.Custom;
                EJet_MadeYear_Picker.CustomFormat = "yyyy/MM/dd";
                string MadeYear = EJet_MadeYear_Picker.Text;
                string EJet_Weight = EJet_Weight_TextBox.Text;
                string EJet_Type = Jet_Type_ComboBox.Text;
                string Power_Source = Power_Source_ComboBox.Text;
                string Nuclear_Engine = Nuclear_Engine_Power_Textbox.Text;

                if (string.IsNullOrEmpty(EJet_ID))
                {
                    if (Pass_Seat == "" || MadeYear == "" || EJet_Weight == "" || EJet_Type == "" || Power_Source == "" || Nuclear_Engine == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string EJetReg_Query_insert_1 = "INSERT INTO EJet (Passenger_Seats, EJet_Type, Made_Year, Weight, Nuclear_Engine_Power, Power_Source) " +
                             "VALUES('" + Pass_Seat + "','" + EJet_Type + "','" + MadeYear + "','" + EJet_Weight + "','" + Nuclear_Engine + "','" + Power_Source + "')" + "SELECT SCOPE_IDENTITY();";
                        con.Open();
                        SqlCommand Register = new SqlCommand(EJetReg_Query_insert_1, con);
                        int ejet_ID = Convert.ToInt32(Register.ExecuteScalar());
                        con.Close();

                        EJetID_Reg_ComboBox.Text = ejet_ID.ToString();
                        string jet_ID = EJetID_Reg_ComboBox.Text;
                        MessageBox.Show("Record Added Successfully \nRegistration No: " + jet_ID, "Register EJet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    con.Open();
                    // Enable IDENTITY_INSERT
                    string enableIdentityInsertQuery = $"SET IDENTITY_INSERT EJet ON;";
                    using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                    {
                        enableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    //------------------------------------------
                    if (Pass_Seat == "" || MadeYear == "" || EJet_Weight == "" || EJet_Type == "" || Power_Source == "" || Nuclear_Engine == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string EJetReg_Query_insert_2 = "Insert into EJet (EJet_ID ,Passenger_Seats, EJet_Type, Made_Year, Weight, Nuclear_Engine_Power, Power_Source) " +
                             "Values('" + EJet_ID + "','" + Pass_Seat + "','" + EJet_Type + "','" + MadeYear + "','" + EJet_Weight + "','" + Nuclear_Engine + "','" + Power_Source + "')";

                        SqlCommand Register2 = new SqlCommand(EJetReg_Query_insert_2, con);
                        Register2.ExecuteNonQuery();

                        MessageBox.Show("Record Added SucessFully", "Register EJet", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    //------------------------------------
                    // Disable IDENTITY_INSERT
                    string disableIdentityInsertQuery = $"SET IDENTITY_INSERT EJet OFF;";
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

        private void EJet_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string EJet_ID = EJetID_Reg_ComboBox.Text;
                string Pass_Seat = EJet_PassSeat_TextBox.Text;
                EJet_MadeYear_Picker.Format = DateTimePickerFormat.Custom;
                EJet_MadeYear_Picker.CustomFormat = "yyyy/MM/dd";
                string MadeYear = EJet_MadeYear_Picker.Text;
                string EJet_Weight = EJet_Weight_TextBox.Text;
                string EJet_Type = Jet_Type_ComboBox.Text;
                string Power_Source = Power_Source_ComboBox.Text;
                string Nuclear_Engine = Nuclear_Engine_Power_Textbox.Text;


                string EJet_Query_update = "UPDATE EJet SET " +
                      "Passenger_Seats = '" + Pass_Seat + "', " +
                      "EJet_Type = '" + EJet_Type + "', " +
                      "Made_Year = '" + MadeYear + "', " +
                      "Weight = '" + EJet_Weight + "', " +
                      "Nuclear_Engine_Power = '" + Nuclear_Engine + "', " +
                      "Power_Source = '" + Power_Source + "' " +
                      "WHERE EJet_ID = '" + EJet_ID + "'";
                if (string.IsNullOrEmpty(EJet_ID))
                {
                    MessageBox.Show("Enter a EJet ID to update the record", "Enter EJet ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Pass_Seat == "" || MadeYear == "" || EJet_Weight == "" || EJet_Type == "" || Power_Source == "" || Nuclear_Engine == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        SqlCommand Update = new SqlCommand(EJet_Query_update, con);
                        Update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated SucessFully", "Update EJet", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void EJet_Search_Button_Click(object sender, EventArgs e)
        {
            string EJet_ID = EJetID_Reg_ComboBox.Text;

            if (string.IsNullOrEmpty(EJet_ID))
            {
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
                            EJetID_Reg_ComboBox.Text = reader["EJet_ID"].ToString();
                            EJet_PassSeat_TextBox.Text = reader["Passenger_Seats"].ToString();
                            Jet_Type_ComboBox.Text = reader["EJet_Type"].ToString();
                            EJet_MadeYear_Picker.Text = reader["Made_Year"].ToString();
                            EJet_MadeYear_Picker.Format = DateTimePickerFormat.Custom;
                            EJet_MadeYear_Picker.CustomFormat = "yyyy/MM/dd";
                            EJet_MadeYear_Picker.Text = reader["Made_Year"].ToString();
                            EJet_Weight_TextBox.Text = reader["Weight"].ToString();
                            Nuclear_Engine_Power_Textbox.Text = reader["Nuclear_Engine_Power"].ToString();
                            Power_Source_ComboBox.Text = reader["Power_Source"].ToString();
                            


                        }
                        else
                        {
                            MessageBox.Show("No record found for the given EJet ID.");
                        }
                    }
                }
            }

        }

        private void EJet_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string EJet_ID = EJetID_Reg_ComboBox.Text;
                    if (string.IsNullOrEmpty(EJet_ID))
                    {
                        MessageBox.Show("Enter a EJet ID to Delete the record", "Enter EJet ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string EJet_Delete_Query = "DELETE from EJet WHERE EJet_ID = " + EJet_ID + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(EJet_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
                        EJet_Clear_Button.PerformClick();
                        MessageBox.Show("Record Have Been Deleted", "EJet Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void EJet_Management_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Select (EJet_ID) from EJet", con);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("EJet_ID", typeof(int));
                table.Load(reader);
                EJetID_Reg_ComboBox.ValueMember = "EJet_ID";
                EJetID_Reg_ComboBox.DataSource = table;
                con.Close();
                EJetID_Reg_ComboBox.Text = "";
                

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

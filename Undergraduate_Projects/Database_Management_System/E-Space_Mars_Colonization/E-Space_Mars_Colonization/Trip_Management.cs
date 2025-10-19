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
    public partial class Trip_Management : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; ");

        public Trip_Management()
        {
            InitializeComponent();
        }

        private void TripReg_Clear_Button_Click(object sender, EventArgs e)
        {
            TripID_Reg_ComboBox.Text = "";
            Trip_EJetID_ComboBox.Text = "";
            DateTime This_Day = DateTime.Today;
            Trip_LaunchDate_Picker.Text = This_Day.ToString();
            Trip_ReturnDate_Picker.Text = This_Day.ToString();
            Trip_EJetID_ComboBox.Focus();

        }

        private void TripReg_Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Trip_ID = TripID_Reg_ComboBox.Text;
                string EJet_ID = Trip_EJetID_ComboBox.Text;
                Trip_LaunchDate_Picker.Format = DateTimePickerFormat.Custom;
                Trip_LaunchDate_Picker.CustomFormat = "yyyy/MM/dd";
                string Launch_Date = Trip_LaunchDate_Picker.Text;
                Trip_ReturnDate_Picker.Format = DateTimePickerFormat.Custom;
                Trip_ReturnDate_Picker.CustomFormat = "yyyy/MM/dd";
                string Return_Date = Trip_ReturnDate_Picker.Text;

                string LaunchDate_Correction = Launch_Date;
                LaunchDate_Correction = LaunchDate_Correction.Replace("/", "");
                int LaunchDate = int.Parse(LaunchDate_Correction);

                string ReturnDate_Correction = Return_Date;
                ReturnDate_Correction = ReturnDate_Correction.Replace("/", "");
                int ReturnDate = int.Parse(ReturnDate_Correction);

                int Today_Date = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                if (LaunchDate < Today_Date || Today_Date > ReturnDate)
                {
                    MessageBox.Show("The date cannot be in the past for Launch Date and Return Date", "Enter Correct Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (LaunchDate > ReturnDate)
                {
                    MessageBox.Show("Launch Date Should be Before Return Date", "Enter Correct Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {

                    if (string.IsNullOrEmpty(Trip_ID))
                    {
                        if (EJet_ID == "" || Launch_Date == "" || Return_Date == "")
                        {
                            MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string TripReg_Query_insert_1 = "INSERT INTO Trip (EJet_ID, Launch_Date, Return_Date) " +
                                 "VALUES('" + EJet_ID + "','" + Launch_Date + "','" + Return_Date + "')" + "SELECT SCOPE_IDENTITY();";
                            con.Open();
                            SqlCommand Register = new SqlCommand(TripReg_Query_insert_1, con);
                            int trip_ID = Convert.ToInt32(Register.ExecuteScalar());
                            con.Close();

                            TripID_Reg_ComboBox.Text = trip_ID.ToString();
                            string Tri_ID = TripID_Reg_ComboBox.Text;
                            MessageBox.Show("Record Added Successfully \nRegistration No: " + Tri_ID, "Register Trip", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        con.Open();
                        // Enable IDENTITY_INSERT
                        string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Trip ON;";
                        using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                        {
                            enableIdentityInsertCommand.ExecuteNonQuery();
                        }
                        //------------------------------------------
                        if (EJet_ID == "" || Launch_Date == "" || Return_Date == "")
                        {
                            MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string TripReg_Query_insert_2 = "Insert into Trip (Trip_ID ,EJet_ID, Launch_Date, Return_Date) " +
                                 "Values('" + Trip_ID + "','" + EJet_ID + "','" + Launch_Date + "','" + Return_Date + "')";

                            SqlCommand Register2 = new SqlCommand(TripReg_Query_insert_2, con);
                            Register2.ExecuteNonQuery();

                            MessageBox.Show("Record Added SucessFully", "Register Trip", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                        //------------------------------------
                        // Disable IDENTITY_INSERT
                        string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Trip OFF;";
                        using (SqlCommand disableIdentityInsertCommand = new SqlCommand(disableIdentityInsertQuery, con))
                        {
                            disableIdentityInsertCommand.ExecuteNonQuery();
                        }
                        con.Close();
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

        private void Trip_TripReg_Search_Button_Click(object sender, EventArgs e)
        {
            string Trip_ID = TripID_Reg_ComboBox.Text;

            if (string.IsNullOrEmpty(Trip_ID))
            {
                MessageBox.Show("Please enter a Trip ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Trip WHERE Trip_ID = @Trip_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Trip_ID", Trip_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TripID_Reg_ComboBox.Text = reader["Trip_ID"].ToString();
                            Trip_EJetID_ComboBox.Text = reader["EJet_ID"].ToString();
                            Trip_LaunchDate_Picker.Text = reader["Launch_Date"].ToString();
                            Trip_ReturnDate_Picker.Text = reader["Return_Date"].ToString();
                            

                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Trip ID.");
                        }
                    }
                }
            }

        }

        private void TripReg_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Trip_ID = TripID_Reg_ComboBox.Text;
                string EJet_ID = Trip_EJetID_ComboBox.Text;
                Trip_LaunchDate_Picker.Format = DateTimePickerFormat.Custom;
                Trip_LaunchDate_Picker.CustomFormat = "yyyy/MM/dd";
                string Launch_Date = Trip_LaunchDate_Picker.Text;
                Trip_ReturnDate_Picker.Format = DateTimePickerFormat.Custom;
                Trip_ReturnDate_Picker.CustomFormat = "yyyy/MM/dd";
                string Return_Date = Trip_ReturnDate_Picker.Text;


                string Trip_Query_update = "UPDATE Trip SET " +
                      "EJet_ID = '" + EJet_ID + "', " +
                      "Launch_Date = '" + Launch_Date + "', " +
                      "Return_Date = '" + Return_Date + "' " +
                      "WHERE Trip_ID = '" + Trip_ID + "'";


                string LaunchDate_Correction = Launch_Date;
                LaunchDate_Correction = LaunchDate_Correction.Replace("/", "");
                int LaunchDate = int.Parse(LaunchDate_Correction);


                string ReturnDate_Correction = Return_Date;
                ReturnDate_Correction = ReturnDate_Correction.Replace("/", "");
                int ReturnDate = int.Parse(ReturnDate_Correction);

                int Today_Date = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                if (LaunchDate < Today_Date || Today_Date > ReturnDate)
                {
                    MessageBox.Show("The date cannot be in the past for Launch Date and Return Date", "Enter Correct Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (LaunchDate > ReturnDate)
                {
                    MessageBox.Show("Launch Date Should be Before Return Date", "Enter Correct Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    if (string.IsNullOrEmpty(Trip_ID))
                    {
                        MessageBox.Show("Enter a Trip ID to update the record", "Enter Trip ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (EJet_ID == "" || Launch_Date == "" || Return_Date == "")
                        {
                            MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            con.Open();
                            SqlCommand Update = new SqlCommand(Trip_Query_update, con);
                            Update.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record Updated SucessFully", "Update Trip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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

        private void TripRegDelete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Trip_ID = TripID_Reg_ComboBox.Text;
                    if (string.IsNullOrEmpty(Trip_ID))
                    {
                        MessageBox.Show("Enter a Trip ID to Delete the record", "Enter Trip ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Trip_Delete_Query = "DELETE from Trip WHERE Trip_ID = " + Trip_ID + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(Trip_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
                        TripReg_Clear_Button.PerformClick();
                        MessageBox.Show("Record Have Been Deleted", "Trip Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Trip_Management_Load(object sender, EventArgs e)
        {
            try
            {
                Trip_EJetID_ComboBox.Focus();
                con.Open();
                SqlCommand command = new SqlCommand("Select (Trip_ID)from Trip", con);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Trip_ID", typeof(int));
                table.Load(reader);
                TripID_Reg_ComboBox.ValueMember = "Trip_ID";
                TripID_Reg_ComboBox.DataSource = table;
                con.Close();
                TripID_Reg_ComboBox.Text = "";
                //////////////////////////////////////////////
                con.Open();
                SqlCommand command2 = new SqlCommand("Select (EJet_ID)from EJet", con);
                SqlDataReader reader2;
                reader2 = command2.ExecuteReader();
                DataTable table2 = new DataTable();
                table2.Columns.Add("EJet_ID", typeof(int));
                table2.Load(reader2);
                Trip_EJetID_ComboBox.ValueMember = "EJet_ID";
                Trip_EJetID_ComboBox.DataSource = table2;
                con.Close();
                Trip_EJetID_ComboBox.Text = "";
                //////////////////////////////////////////////
                con.Open();
                SqlCommand command3 = new SqlCommand("Select (Trip_Passenger_ID)from Trip_Passenger", con);
                SqlDataReader reader3;
                reader3 = command3.ExecuteReader();
                DataTable table3 = new DataTable();
                table3.Columns.Add("Trip_Passenger_ID", typeof(int));
                table3.Load(reader3);
                TripPass_TripPassID_ComboBox.ValueMember = "Trip_Passenger_ID";
                TripPass_TripPassID_ComboBox.DataSource = table3;
                con.Close();
                TripPass_TripPassID_ComboBox.Text = "";
                //////////////////////////////////////////////
                con.Open();
                SqlCommand command4 = new SqlCommand("Select (Trip_ID)from Trip", con);
                SqlDataReader reader4;
                reader4 = command4.ExecuteReader();
                DataTable table4 = new DataTable();
                table4.Columns.Add("Trip_ID", typeof(int));
                table4.Load(reader4);
                TripPass_TripID_ComboBox.ValueMember = "Trip_ID";
                TripPass_TripID_ComboBox.DataSource = table4;
                con.Close();
                TripPass_TripID_ComboBox.Text = "";
                //////////////////////////////////////////////
                con.Open();
                SqlCommand command5 = new SqlCommand("Select (Colonist_ID) from Colonist", con);
                SqlDataReader reader5;
                reader5 = command5.ExecuteReader();
                DataTable table5 = new DataTable();
                table5.Columns.Add("Colonist_ID", typeof(int));
                table5.Load(reader5);
                TripPass_ColonistID_ComboBox.ValueMember = "Colonist_ID";
                TripPass_ColonistID_ComboBox.DataSource = table5;
                con.Close();
                TripPass_ColonistID_ComboBox.Text = "";

            }
            catch (SqlException ex)
            {
                string message = "Search Error:";
                message += ex.Message;
                MessageBox.Show(message);
                con.Close();
            }

        }
        ///Trip Passenger/
        
        private void TripPass_Clear_Button_Click(object sender, EventArgs e)
        {
            TripPass_TripPassID_ComboBox.Text = "";
            TripPass_TripID_ComboBox.Text = "";
            TripPass_ColonistID_ComboBox.Text = "";
            Trip_ID_Finder_Label.Text = "";
            Colonist_Name_TextBox.Clear();
            TripPass_TripID_ComboBox.Focus();
        }

        private void TripPass_Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Trip_Passenger_ID = TripPass_TripPassID_ComboBox.Text;
                string Trip_ID = TripPass_TripID_ComboBox.Text;
                string Colonist_ID = TripPass_ColonistID_ComboBox.Text;
                string Colonist_Name = Colonist_Name_TextBox.Text;

                if (string.IsNullOrEmpty(Trip_Passenger_ID))
                {
                    if (Trip_ID == "" || Colonist_ID == "" || Colonist_Name == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string TripPassengerReg_Query_insert_1 = "INSERT INTO Trip_Passenger (Trip_ID, Colonist_ID) " +
                             "VALUES('" + Trip_ID + "','"+ Colonist_ID +"')" + "SELECT SCOPE_IDENTITY();";
                        con.Open();
                        SqlCommand Register = new SqlCommand(TripPassengerReg_Query_insert_1, con);
                        int Tri_Pass_ID = Convert.ToInt32(Register.ExecuteScalar());
                        con.Close();

                        TripPass_TripPassID_ComboBox.Text = Tri_Pass_ID.ToString();
                        string TriPass_ID = TripPass_TripPassID_ComboBox.Text;
                        MessageBox.Show("Record Added Successfully \nRegistration No: " + TriPass_ID, "Register Trip Passenger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    con.Open();
                    // Enable IDENTITY_INSERT
                    string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Trip_Passenger ON;";
                    using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                    {
                        enableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    //------------------------------------------
                    if (Trip_ID == "" || Colonist_ID == "" || Colonist_Name == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string TripPassengerReg_Query_insert_2 = "Insert into Trip_Passenger (Trip_Passenger_ID,Trip_ID, Colonist_ID) " +
                             "Values('" + Trip_Passenger_ID + "','" + Trip_ID + "','" + Colonist_ID + "')";

                        SqlCommand Register2 = new SqlCommand(TripPassengerReg_Query_insert_2, con);
                        Register2.ExecuteNonQuery();

                        MessageBox.Show("Record Added SucessFully", "Register Trip Passenger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    //------------------------------------
                    // Disable IDENTITY_INSERT
                    string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Trip_Passenger OFF;";
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

        private void TripPass_ColonistID_Search_Button_Click(object sender, EventArgs e)
        {
            string Colonist_ID = TripPass_ColonistID_ComboBox.Text;

            if (string.IsNullOrEmpty(Colonist_ID))
            {
                MessageBox.Show("Please enter a Colonist ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Colonist WHERE Colonist_ID = @Colonist_ID";
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
            }

        }

        private void TripPass_TripID_Search_Button_Click(object sender, EventArgs e)
        {
            string Trip_ID = TripPass_TripID_ComboBox.Text;

            if (string.IsNullOrEmpty(Trip_ID))
            {
                Trip_ID_Finder_Label.Text = "";
                MessageBox.Show("Please enter a Trip ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Trip WHERE Trip_ID = @Trip_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Trip_ID", Trip_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Trip_ID_Finder_Label.Text = "Available";
                            Trip_ID_Finder_Label.ForeColor = Color.LimeGreen;
                        }
                        else
                        {
                            Trip_ID_Finder_Label.Text = "Not Available";
                            Trip_ID_Finder_Label.ForeColor = Color.Red;
                            MessageBox.Show("No record found for the given Trip ID.");
                        }
                    }
                }
            }

        }

        private void TripPass_TripPassID_Search_Button_Click(object sender, EventArgs e)
        {
            string Trip_Passenger_ID = TripPass_TripPassID_ComboBox.Text;

            if (string.IsNullOrEmpty(Trip_Passenger_ID))
            {
                MessageBox.Show("Please enter a Trip Passenger ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Trip_Passenger WHERE Trip_Passenger_ID = @Trip_Passenger_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Trip_Passenger_ID", Trip_Passenger_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TripPass_TripPassID_ComboBox.Text = reader["Trip_Passenger_ID"].ToString();
                            TripPass_TripID_ComboBox.Text = reader["Trip_ID"].ToString();
                            TripPass_ColonistID_ComboBox.Text = reader["Colonist_ID"].ToString();
                            TripPass_ColonistID_Search_Button.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Trip Passenger ID.");
                        }
                    }
                }
            }

        }

        private void TripPass_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Trip_Passenger_ID = TripPass_TripPassID_ComboBox.Text;
                    if (string.IsNullOrEmpty(Trip_Passenger_ID))
                    {
                        MessageBox.Show("Enter a Trip Passenger ID to Delete the record", "Enter Colonist Qualification ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Trip_Passenger_Delete_Query = "DELETE from Trip_Passenger WHERE Trip_Passenger_ID = " + Trip_Passenger_ID + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(Trip_Passenger_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Have Been Deleted", "Passenger Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void TripPass_Update_Button_Click(object sender, EventArgs e)
        {

            try
            {
                string Trip_Passenger_ID = TripPass_TripPassID_ComboBox.Text;
                string Trip_ID = TripPass_TripID_ComboBox.Text;
                string Colonist_ID = TripPass_ColonistID_ComboBox.Text;
                string Colonist_Name = Colonist_Name_TextBox.Text;

                string TripPassenger_Query_update = "UPDATE Trip_Passenger SET " +
                      "Trip_ID = '" + Trip_ID + "', " +
                      "Colonist_ID = '" + Colonist_ID + "'";


                if (string.IsNullOrEmpty(Trip_Passenger_ID))
                {
                    MessageBox.Show("Enter a Trip Passenger ID to update the record", "Enter Colonist ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Trip_ID == "" || Colonist_ID == "" || Colonist_Name == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        SqlCommand Update = new SqlCommand(TripPassenger_Query_update, con);
                        Update.ExecuteNonQuery();
                        con.Close();
                        
                        MessageBox.Show("Record Updated SucessFully", "Update Trip Passenger", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace E_Space_Mars_Colonization
{
    public partial class Colonist_Management : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; ");

        public Colonist_Management()
        {
            InitializeComponent();
        }

        private void ColoReg_Clear_Button_Click(object sender, EventArgs e)
        {
            ColonistID_Reg_ComboBox.Text = "";
            FName_TextBox.Clear();
            MName_TextBox.Clear();
            LName_TextBox.Clear();
            DateTime This_Day = DateTime.Today;
            DOB_Picker.Text = This_Day.ToString();
            Male_RBtn.Checked = false;
            Female_RBtn.Checked = false;
            CStatus_ComboBox.Text = "";
            Address_TextBox.Clear();
            ContactNo_Textbox.Clear();
            Family_Member_Count_TextBox.Clear();
            FName_TextBox.Focus();
        }

        private void ColoReg_Register_Button_Click(object sender, EventArgs e)
        {
        try { 
            string Colonist_ID = ColonistID_Reg_ComboBox.Text;
            string First_Name = FName_TextBox.Text;
            string Middle_Name = MName_TextBox.Text;
            string Last_Name = LName_TextBox.Text;
            DOB_Picker.Format = DateTimePickerFormat.Custom;
            DOB_Picker.CustomFormat = "yyyy/MM/dd";
            string Date_Of_Birth = DOB_Picker.Text;
            string Gender;
            if (Male_RBtn.Checked)
            {
                Gender = "Male";
            }
            else if (Female_RBtn.Checked)
            {
                Gender = "Female";
            }
            else
            {
                Gender = "";
            }
            string Civil_Status = CStatus_ComboBox.Text;
            string Earth_Address = Address_TextBox.Text;
            string Contact_No = ContactNo_Textbox.Text;
            string Family_Members_Count = Family_Member_Count_TextBox.Text;

            if (string.IsNullOrEmpty(Colonist_ID))
            {
                if (First_Name == "" || Last_Name == "" || Date_Of_Birth == "" || Civil_Status == "" || Gender == "" || Earth_Address == "" || Contact_No == "" || Family_Members_Count == "")
                {
                    MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string ColReg_Query_insert_1 = "INSERT INTO Colonist (First_Name, Middle_Name, Last_Name, Date_Of_Birth, Gender, Earth_Address, Contact_No, Family_Members_Count, Civil_Status) " +
                         "VALUES('" + First_Name + "','" + Middle_Name + "','" + Last_Name + "','" + Date_Of_Birth + "','" + Gender + "','" + Earth_Address + "','" + Contact_No + "','" + Family_Members_Count + "','" + Civil_Status + "')" + "SELECT SCOPE_IDENTITY();";
                    con.Open();
                    SqlCommand Register = new SqlCommand(ColReg_Query_insert_1, con);
                    int colonist_ID = Convert.ToInt32(Register.ExecuteScalar());
                    con.Close();

                    ColonistID_Reg_ComboBox.Text = colonist_ID.ToString();
                    string Col_ID = ColonistID_Reg_ComboBox.Text;
                    MessageBox.Show("Record Added Successfully \nRegistration No: " + Col_ID, "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                con.Open();
                // Enable IDENTITY_INSERT
                string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Colonist ON;";
                using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                {
                    enableIdentityInsertCommand.ExecuteNonQuery();
                }
                //------------------------------------------
                if (First_Name == "" || Last_Name == "" || Date_Of_Birth == "" || Civil_Status == "" || Gender == "" || Earth_Address == "" || Contact_No == "" || Family_Members_Count == "")
                {
                    MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string ColReg_Query_insert_2 = "Insert into Colonist (Colonist_ID ,First_Name, Middle_Name, Last_Name, Date_Of_Birth, Gender, Earth_Address, Contact_No, Family_Members_Count, Civil_Status) " +
                         "Values('"+ Colonist_ID +"','" + First_Name + "','" + Middle_Name + "','" + Last_Name + "','" + Date_Of_Birth + "','" + Gender + "','" + Earth_Address + "','" + Contact_No + "','" + Family_Members_Count + "','" + Civil_Status + "')";

                    SqlCommand Register2 = new SqlCommand(ColReg_Query_insert_2, con);
                    Register2.ExecuteNonQuery();

                    MessageBox.Show("Record Added SucessFully", "Register Colonist", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                //------------------------------------
                // Disable IDENTITY_INSERT
                string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Colonist OFF;";
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

        private void ColoReg_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Colonist_ID = ColonistID_Reg_ComboBox.Text;
                string First_Name = FName_TextBox.Text;
                string Middle_Name = MName_TextBox.Text;
                string Last_Name = LName_TextBox.Text;
                DOB_Picker.Format = DateTimePickerFormat.Custom;
                DOB_Picker.CustomFormat = "yyyy/MM/dd";
                string Date_Of_Birth = DOB_Picker.Text;
                string Gender;
                if (Male_RBtn.Checked)
                {
                    Gender = "Male";
                }
                else if (Female_RBtn.Checked)
                {
                    Gender = "Female";
                }
                else
                {
                    Gender = "";
                }
                string Civil_Status = CStatus_ComboBox.Text;
                string Earth_Address = Address_TextBox.Text;
                string Contact_No = ContactNo_Textbox.Text;
                string Family_Members_Count = Family_Member_Count_TextBox.Text;


                string Colonist_Query_update = "UPDATE Colonist SET " +
                      "First_Name = '" + First_Name + "', " +
                      "Middle_Name = '" + Middle_Name + "', " +
                      "Last_Name = '" + Last_Name + "', " +
                      "Date_Of_Birth = '" + Date_Of_Birth + "', " +
                      "Gender = '" + Gender + "', " +
                      "Earth_Address = '" + Earth_Address + "', " +
                      "Contact_No = '" + Contact_No + "', " +
                      "Civil_Status = '" + Civil_Status + "', " +
                      "Family_Members_Count = '" + Family_Members_Count + "' "+
                      "WHERE Colonist_ID = '" + Colonist_ID + "'";
                if (string.IsNullOrEmpty(Colonist_ID))
                {
                    MessageBox.Show("Enter a Colonist ID to update the record", "Enter Colonist ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (First_Name == "" || Last_Name == "" || Date_Of_Birth == "" || Civil_Status == "" || Gender == "" || Earth_Address == "" || Contact_No == "" || Family_Members_Count == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        SqlCommand Update = new SqlCommand(Colonist_Query_update, con);
                        Update.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated SucessFully", "Update Colonist", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ColReg_Search_Button_Click(object sender, EventArgs e)
        {
            string Colonist_ID = ColonistID_Reg_ComboBox.Text;

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
                            ColonistID_Reg_ComboBox.Text = reader["Colonist_ID"].ToString();
                            FName_TextBox.Text = reader["First_Name"].ToString();
                            MName_TextBox.Text = reader["Middle_Name"].ToString();
                            LName_TextBox.Text = reader["Last_Name"].ToString();
                            DOB_Picker.Format = DateTimePickerFormat.Custom;
                            DOB_Picker.CustomFormat = "yyyy/MM/dd";
                            DOB_Picker.Text = reader["Date_Of_Birth"].ToString();
                            if (reader["Gender"].ToString() == "Male")
                            {
                                Male_RBtn.Checked = true;
                            }
                            else
                            {
                                Female_RBtn.Checked = true;
                            }

                            Address_TextBox.Text = reader["Earth_Address"].ToString();
                            CStatus_ComboBox.Text = reader["Civil_Status"].ToString();
                            ContactNo_Textbox.Text = reader["Contact_No"].ToString();
                            Family_Member_Count_TextBox.Text = reader["Family_Members_Count"].ToString();
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Colonist ID.");
                        }
                    }
                }
            }

        }

        private void ColoRegDelete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Colonist_ID = ColonistID_Reg_ComboBox.Text;
                    if (string.IsNullOrEmpty(Colonist_ID))
                    {
                        MessageBox.Show("Enter a Colonist ID to Delete the record", "Enter Colonist ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Colonist_Delete_Query = "DELETE from Colonist WHERE Colonist_ID = " + Colonist_ID + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(Colonist_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Have Been Deleted", "Colonist Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Colonist_Management_Load(object sender, EventArgs e)
        {
            try
            {
                FName_TextBox.Focus();
                con.Open();
                SqlCommand command = new SqlCommand("Select (Colonist_ID)from Colonist", con);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Columns.Add("Colonist_ID", typeof(int));
                table.Load(reader);
                ColonistID_Reg_ComboBox.ValueMember = "Colonist_ID";
                ColonistID_Reg_ComboBox.DataSource = table;
                con.Close();
                ColonistID_Reg_ComboBox.Text = "";
                //////////////////////////////////////////////
                con.Open();
                SqlCommand command3 = new SqlCommand("Select (Colonist_ID)from Colonist", con);
                SqlDataReader reader3;
                reader3 = command3.ExecuteReader();
                DataTable table3 = new DataTable();
                table3.Columns.Add("Colonist_ID", typeof(int));
                table3.Load(reader3);
                ColonistID_Qua_ComboBox.ValueMember = "Colonist_ID";
                ColonistID_Qua_ComboBox.DataSource = table3;
                con.Close();
                ColonistID_Qua_ComboBox.Text = "";
                //////////////////////////////////////////////
                con.Open();
                SqlCommand command2 = new SqlCommand("Select (Colonist_Qualification_ID)from Colonist_Qualification", con);
                SqlDataReader reader2;
                reader2 = command2.ExecuteReader();
                DataTable table2 = new DataTable();
                table2.Columns.Add("Colonist_Qualification_ID", typeof(int));
                table2.Load(reader2);
                ColonistID_QuaID_ComboBox.ValueMember = "Colonist_Qualification_ID";
                ColonistID_QuaID_ComboBox.DataSource = table2;
                con.Close();
                ColonistID_QuaID_ComboBox.Text = "";
               
            }
            catch (SqlException ex)
            {
                string message = "Search Error:";
                message += ex.Message;
                MessageBox.Show(message);
                con.Close();
            }

        }

        //Colonist_Qualification

        private void ColoQua_Clear_Button_Click(object sender, EventArgs e)
        {
            ColonistID_QuaID_ComboBox.Text = "";
            ColonistID_Qua_ComboBox.Text = "";
            CName_Qualification_TextBox.Clear();
            CName_Experience_TextBox.Clear();
            CName_Level_TextBox.Clear();
            CName_Qua_Name_TextBox.Clear();
            ColonistID_Qua_ComboBox.Focus();
        }

        private void ColoQua_Register_Button_Click(object sender, EventArgs e)
        {
            try {
                string Colonist_Qualification_ID = ColonistID_QuaID_ComboBox.Text;
                string Qua_Colonist_ID = ColonistID_Qua_ComboBox.Text;
                string Colonist_Qualification = CName_Qualification_TextBox.Text;
                string Colonist_Experience = CName_Experience_TextBox.Text;
                string Colonist_Level = CName_Level_TextBox.Text;
                string Colonist_Name = CName_Qua_Name_TextBox.Text;

                if (string.IsNullOrEmpty(Colonist_Qualification_ID))
                {
                    if (Qua_Colonist_ID == "" || Colonist_Name ==""|| Colonist_Qualification == "" || Colonist_Experience == "" || Colonist_Level == "" )
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string ColQuaReg_Query_insert_1 = "INSERT INTO Colonist_Qualification (Colonist_ID, Qualification_Description, Colonist_Experience, Colonist_Level) " +
                             "VALUES('" + Qua_Colonist_ID + "','" + Colonist_Qualification + "','" + Colonist_Experience + "','" + Colonist_Level + "')" + "SELECT SCOPE_IDENTITY();";
                        con.Open();
                        SqlCommand Register = new SqlCommand(ColQuaReg_Query_insert_1, con);
                        int Qua_Colo_ID = Convert.ToInt32(Register.ExecuteScalar());
                        con.Close();

                        ColonistID_QuaID_ComboBox.Text = Qua_Colo_ID.ToString();
                        string ColQua_ID = ColonistID_QuaID_ComboBox.Text;
                        MessageBox.Show("Record Added Successfully \nRegistration No: " + ColQua_ID, "Register Colonist Qualification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    con.Open();
                    // Enable IDENTITY_INSERT
                    string enableIdentityInsertQuery = $"SET IDENTITY_INSERT Colonist_Qualification ON;";
                    using (SqlCommand enableIdentityInsertCommand = new SqlCommand(enableIdentityInsertQuery, con))
                    {
                        enableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    //------------------------------------------
                    if (Qua_Colonist_ID == "" || Colonist_Name == "" || Colonist_Qualification == "" || Colonist_Experience == "" || Colonist_Level == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string ColQuaReg_Query_insert_2 = "Insert into Colonist_Qualification (Colonist_Qualification_ID,Colonist_ID, Qualification_Description, Colonist_Experience, Colonist_Level) " +
                             "Values('"+ Colonist_Qualification_ID + "','" + Qua_Colonist_ID + "','" + Colonist_Qualification + "','" + Colonist_Experience + "','" + Colonist_Level + "')";

                        SqlCommand Register2 = new SqlCommand(ColQuaReg_Query_insert_2, con);
                        Register2.ExecuteNonQuery();

                        MessageBox.Show("Record Added SucessFully", "Register Colonist Qualification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    //------------------------------------
                    // Disable IDENTITY_INSERT
                    string disableIdentityInsertQuery = $"SET IDENTITY_INSERT Colonist_Qualification OFF;";
                    using (SqlCommand disableIdentityInsertCommand = new SqlCommand(disableIdentityInsertQuery, con))
                    {
                        disableIdentityInsertCommand.ExecuteNonQuery();
                    }
                    con.Close();
                }


            }
            catch(SqlException ex)
            {
                string message = "Insert Error:";
                message += ex.Message;
                MessageBox.Show(message);
                con.Close();
            }
        }

        private void Colonist_CQua_Search_Button_Click(object sender, EventArgs e)
        {
            string Colonist_ID = ColonistID_Qua_ComboBox.Text;

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
                            CName_Qua_Name_TextBox.Text = reader["First_Name"].ToString();                            
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Colonist ID.");
                        }
                    }
                }
            }

        }

        private void ColoQua_Update_Button_Click(object sender, EventArgs e)
        {

            try
            {
                string Colonist_Qualification_ID = ColonistID_QuaID_ComboBox.Text;
                string Qua_Colonist_ID = ColonistID_Qua_ComboBox.Text;
                string Colonist_Qualification = CName_Qualification_TextBox.Text;
                string Colonist_Experience = CName_Experience_TextBox.Text;
                string Colonist_Level = CName_Level_TextBox.Text;
                string Colonist_Name = CName_Qua_Name_TextBox.Text;


                string Colonist_Query_update = "UPDATE Colonist_Qualification SET " +
                      "Colonist_ID = '" + Qua_Colonist_ID + "', " +
                      "Qualification_Description = '" + Colonist_Qualification + "', " +
                      "Colonist_Experience = '" + Colonist_Experience + "', " +
                      "Colonist_Level = '" + Colonist_Level + "'";


                if (string.IsNullOrEmpty(Colonist_Qualification_ID))
                {
                    MessageBox.Show("Enter a Colonist Qualification ID to update the record", "Enter Colonist ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Qua_Colonist_ID == "" || Colonist_Name == "" || Colonist_Qualification == "" || Colonist_Experience == "" || Colonist_Level == "")
                    {
                        MessageBox.Show("Enter All The Mandatory Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        SqlCommand Update = new SqlCommand(Colonist_Query_update, con);
                        Update.ExecuteNonQuery();
                        con.Close();
                        //Colonist_CQua_Search_Button.PerformClick();
                        MessageBox.Show("Record Updated SucessFully", "Update Colonist Qualification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CQuaID_Search_Button_Click(object sender, EventArgs e)
        {
            string Colonist_Qualification_ID = ColonistID_QuaID_ComboBox.Text;

            if (string.IsNullOrEmpty(Colonist_Qualification_ID))
            {
                MessageBox.Show("Please enter a Colonist Qualification ID.", "Search Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
            {
                connection.Open();

                string query = "SELECT * FROM Colonist_Qualification WHERE Colonist_Qualification_ID = @Colonist_Qualification_ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Colonist_Qualification_ID", Colonist_Qualification_ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ColonistID_QuaID_ComboBox.Text = reader["Colonist_Qualification_ID"].ToString();
                            ColonistID_Qua_ComboBox.Text = reader["Colonist_ID"].ToString();
                            CName_Qualification_TextBox.Text = reader["Qualification_Description"].ToString();
                            CName_Experience_TextBox.Text = reader["Colonist_Experience"].ToString();
                            CName_Level_TextBox.Text = reader["Colonist_Level"].ToString();
                            Colonist_CQua_Search_Button.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("No record found for the given Colonist Qualification ID.");
                        }
                    }
                }
            }

        }

        private void ColoQua_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are You Sure You Need To Delete This Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string Colonist_Qualification_ID = ColonistID_QuaID_ComboBox.Text;
                    if (string.IsNullOrEmpty(Colonist_Qualification_ID))
                    {
                        MessageBox.Show("Enter a Colonist Qualification ID to Delete the record", "Enter Colonist Qualification ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string Colonist_Qualification_Delete_Query = "DELETE from Colonist_Qualification WHERE Colonist_Qualification_ID = " + Colonist_Qualification_ID + " ";
                        con.Open();
                        SqlCommand Command = new SqlCommand(Colonist_Qualification_Delete_Query, con);
                        Command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Have Been Deleted", "Colonist Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

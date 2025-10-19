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
    public partial class AddMember_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; ");

        public AddMember_Form()
        {
            InitializeComponent();
        }

        private void Clear_Label_Click(object sender, EventArgs e)
        {

            FirstName_TextBox.Clear();
            LastName_TextBox.Clear();
            Designation_Textbox.Clear();
            UserName_Textbox.Clear();
            Password_Textbox.Clear();
            FirstName_TextBox.Focus();

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string First_Name = FirstName_TextBox.Text;
            string Last_Name = LastName_TextBox.Text;
            string Designation = Designation_Textbox.Text;
            string User_Name = UserName_Textbox.Text;
            string Password = Password_Textbox.Text;
            if (First_Name == "" || Last_Name == "" ||Designation ==""|| User_Name == "" || Password == "")
            {
                MessageBox.Show("Enter All The Details", "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string Query_Add = "Insert into Add_Member ( First_Name, Last_Name, Designation, User_Name , Password)" +
                "Values('" + First_Name + "','" + Last_Name + "','"+ Designation +"','" + User_Name + "','" + Password + "')";
                con.Open();
                SqlCommand Add = new SqlCommand(Query_Add, con);
                Add.ExecuteNonQuery();
                MessageBox.Show("Record Added SucessFully", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }


        }
    }
}

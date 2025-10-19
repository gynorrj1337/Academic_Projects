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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace E_Space_Mars_Colonization
{
    public partial class Login_Form : Form
    {
        public static string UserName;
        public static string Time;
        public static string Hour;

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Clear_Label_Click(object sender, EventArgs e)
        {
            UserName_TextBox.Clear();
            Password_Textbox.Clear();
            UserName_TextBox.Focus();
        }

        private void Hide_Button_Click(object sender, EventArgs e)
        {
            Password_Textbox.UseSystemPasswordChar = true;
            Show_Button.BringToFront();
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            Password_Textbox.UseSystemPasswordChar = false;
            Hide_Button.BringToFront();
        }

        private void SignIn_Button_Click(object sender, EventArgs e)
        {

            string Entered_Display_Name = UserName_TextBox.Text;
            string Entered_Password = Password_Textbox.Text;
            string connectionString = @"Data Source= Code-Maestro; Initial Catalog = Mars_Colonization; Integrated Security=True;";
            SqlConnection Connect = new SqlConnection(connectionString);
            Connect.Open();
            string search_query = "Select * from Add_Member where  User_Name COLLATE SQL_Latin1_General_CP1_CS_AS = '" + Entered_Display_Name + "' and Password COLLATE SQL_Latin1_General_CP1_CS_AS= '" + Entered_Password + "'";
            SqlCommand Fetch = new SqlCommand(search_query, Connect);
            SqlDataReader row = Fetch.ExecuteReader();

            if (row.HasRows)
            {
                //To send user name to DashBoard_Form
                UserName = UserName_TextBox.Text;
                DateTime CTime = DateTime.Now;
                Time = CTime.ToString("HH:mm:ss");
                Hour = CTime.ToString("HH");
                this.Hide();
                DashBoard_Form Main_Page = new DashBoard_Form();
                Main_Page.Show();


                //

            }
            else
            {
                MessageBox.Show("Invalid Login Credentials, \nPlease Try Again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

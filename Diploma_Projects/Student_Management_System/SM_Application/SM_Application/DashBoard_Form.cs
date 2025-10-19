using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM_Application
{
    public partial class DashBoard_Form : Form
    {
        public DashBoard_Form()
        {
            InitializeComponent();


            
            if (int.Parse(Login_Form.Hour) >= 5 && int.Parse(Login_Form.Hour) <12) 
            {
                UserGreeting_Label.Text = "Good Morning! It's nice meet you "+  Login_Form.UserName;
            }
            else if (int.Parse(Login_Form.Hour) >= 12 && int.Parse(Login_Form.Hour) < 16)
            {
                UserGreeting_Label.Text = "Good Afternoon! It's nice meet you " + Login_Form.UserName;
            }
            else if (int.Parse(Login_Form.Hour) > 16 && int.Parse(Login_Form.Hour) < 19)
            {
                UserGreeting_Label.Text = "Good Evening! It's nice meet you " + Login_Form.UserName;
            }
            else
            {
                UserGreeting_Label.Text = "         Hi! It's nice meet you " + Login_Form.UserName;
            }

            Accessed_Label.Text = "Last time you Logged in " + Login_Form.Time;
        }

        private void UserGreeting_Label_Click(object sender, EventArgs e)
        {

        }

        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            Login_Form SignUp_Page = new Login_Form();
            DashBoard DashBoard_Page = new DashBoard();
            
            DashBoard_Page.Close();
            this.Close();
            SignUp_Page.Show();
        }
    }
}

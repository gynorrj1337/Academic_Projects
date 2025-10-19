using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Space_Mars_Colonization
{
    public partial class DashBoard_Profile_Form : Form
    {
        public DashBoard_Profile_Form()
        {
            InitializeComponent();




            if (int.Parse(Login_Form.Hour) >= 5 && int.Parse(Login_Form.Hour) < 12)
            {
                UserGreeting_Label.Text = "Good Morning! It's nice meet you " + Login_Form.UserName;
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

    }

    
    
}

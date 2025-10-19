using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Lanka_Toys_Admin
{
    public partial class DashBoard_Profile_Form : Form
    {
        public DashBoard_Profile_Form()
        {
            InitializeComponent();
            //To move the border
            //Form_Border.MouseDown += (sender, e) => { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } };

            if (int.Parse(Login_Form.Hour) >= 5 && int.Parse(Login_Form.Hour) < 12)
            {
                lbl_AdminGreeting.Text = "Good Morning! It's nice meet you " + Login_Form.AdminName;
            }
            else if (int.Parse(Login_Form.Hour) >= 12 && int.Parse(Login_Form.Hour) < 16)
            {
                lbl_AdminGreeting.Text = "Good Afternoon! It's nice meet you " + Login_Form.AdminName;
            }
            else if (int.Parse(Login_Form.Hour) > 16 && int.Parse(Login_Form.Hour) < 19)
            {
                lbl_AdminGreeting.Text = "Good Evening! It's nice meet you " + Login_Form.AdminName;
            }
            else
            {
                lbl_AdminGreeting.Text = "         Hi! It's nice meet you " + Login_Form.AdminName;
            }

            lbl_AccessedTime.Text = "Last time you Logged in " + Login_Form.Time;

        }
    }
}

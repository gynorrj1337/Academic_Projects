using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Space_Mars_Colonization
{
    public partial class DashBoard_Form : Form
    {

        //To Control Windows State
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        static extern bool ReleaseCapture();
        // ------
        public DashBoard_Form()
        {
            InitializeComponent();
            //To move the border
            Form_Border.MouseDown += (sender, e) => { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } };

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

        private void Close_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AddMember_Button_Click(object sender, EventArgs e)
        {
            AddMember_Form AddMember = new AddMember_Form();
            AddMember.Show();

        }

        private void SignOut_Button_Click(object sender, EventArgs e)
        {
            Login_Form SignUp_Page = new Login_Form();

            var result = MessageBox.Show("Are you sure, Do you really need to Sign Out....?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                SignUp_Page.Show();
            }

        }

        private void Dashoard_Button_Click(object sender, EventArgs e)
        {
            this.Form_Loader.Controls.Clear();
            DashBoard_Profile_Form DashBoard_Profile_Form_Vrb = new DashBoard_Profile_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DashBoard_Profile_Form_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Form_Loader.Controls.Add(DashBoard_Profile_Form_Vrb);
            DashBoard_Profile_Form_Vrb.Show();
        }

        private void Management_Menu_Button_Click(object sender, EventArgs e)
        {
            this.Form_Loader.Controls.Clear();
            Management_Form Management_Form_Vrb = new Management_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Management_Form_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Form_Loader.Controls.Add(Management_Form_Vrb);
            Management_Form_Vrb.Show();

        }

        private void Report_Menu_Button_Click(object sender, EventArgs e)
        {
            this.Form_Loader.Controls.Clear();
            Report_Form Report_Form_Vrb = new Report_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Report_Form_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Form_Loader.Controls.Add(Report_Form_Vrb);
            Report_Form_Vrb.Show();

        }

        private void Feedback_Button_Click(object sender, EventArgs e)
        {
            this.Form_Loader.Controls.Clear();
            FeedBack_Form FeedBack_Form_Vrb = new FeedBack_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FeedBack_Form_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Form_Loader.Controls.Add(FeedBack_Form_Vrb);
            FeedBack_Form_Vrb.Show();

        }
    }
}

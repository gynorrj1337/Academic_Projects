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

namespace SM_Application
{
    public partial class DashBoard : Form
    {
        //To Control Windows State
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        static extern bool ReleaseCapture();
        // ------

        public DashBoard()
        {
            InitializeComponent();
            //To move the border
            Form_Border.MouseDown += (sender, e) => { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } };

            this.Form_Loader.Controls.Clear();
            DashBoard_Form DashBoard_Form_Vrb = new DashBoard_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DashBoard_Form_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Form_Loader.Controls.Add(DashBoard_Form_Vrb);
            DashBoard_Form_Vrb.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void StudentMenu_Button_Click_1(object sender, EventArgs e)
        {
            this.Form_Loader.Controls.Clear();
            StudentMenu StudentMenu_Vrb = new StudentMenu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            StudentMenu_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Form_Loader.Controls.Add(StudentMenu_Vrb);
            StudentMenu_Vrb.Show();
        }

        private void SettingsMenu_Button_Click(object sender, EventArgs e)
        {

        }

        private void Form_Border_Click(object sender, EventArgs e)
        {
            
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        

        private void Dashoard_Button_Click_1(object sender, EventArgs e)
        {
            this.Form_Loader.Controls.Clear();
            DashBoard_Form DashBoard_Form_Vrb = new DashBoard_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            DashBoard_Form_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.Form_Loader.Controls.Add(DashBoard_Form_Vrb);
            DashBoard_Form_Vrb.Show();
            
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

        private void AddMember_Button_Click(object sender, EventArgs e)
        {
            AddMember_Form AddMember = new AddMember_Form();
            AddMember.Show();
        }
    }   
}

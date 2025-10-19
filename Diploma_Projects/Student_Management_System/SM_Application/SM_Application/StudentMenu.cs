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
    public partial class StudentMenu : Form
    {
        public StudentMenu()
        {
            InitializeComponent();
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            Registration_Button.Visible = false;
            Search_Button.Visible = false;
            this.Student_Loader.Controls.Clear();
            Registration_Form Registration_Form_New = new Registration_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Registration_Form_New.FormBorderStyle = FormBorderStyle.None;
            this.Student_Loader.Controls.Add(Registration_Form_New);
            Registration_Form_New.Show();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Registration_Button.Visible = false;
            Search_Button.Visible = false;
            this.Student_Loader.Controls.Clear();
            Search_Form Search_Form_New = new Search_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Search_Form_New.FormBorderStyle = FormBorderStyle.None;
            this.Student_Loader.Controls.Add(Search_Form_New);
            Search_Form_New.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Lanka_Toys_Employee
{
    public partial class Report_Form : Form
    {
        public Report_Form()
        {
            InitializeComponent();
        }

        private void Btn_LeaveReport_Click(object sender, EventArgs e)
        {

            this.Pnl_Management_Form.Controls.Clear();
            Leave_Status_Report_Form Leave_Report_Form_New = new Leave_Status_Report_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Leave_Report_Form_New.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_Management_Form.Controls.Add(Leave_Report_Form_New);
            Leave_Report_Form_New.Show();



        }

        private void Btn_LeaveHistory_Click(object sender, EventArgs e)
        {

            this.Pnl_Management_Form.Controls.Clear();
            Leave_History_Form Leave_History_Form_New = new Leave_History_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Leave_History_Form_New.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_Management_Form.Controls.Add(Leave_History_Form_New);
            Leave_History_Form_New.Show();



        }
    }
}

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
    public partial class Leave_Management_Form : Form
    {
        public Leave_Management_Form()
        {
            InitializeComponent();
        }

        //the Add Leave button click event
        private void Btn_AddLeave_Click(object sender, EventArgs e)
        {
            this.Management_Form_Panel.Controls.Clear(); // Clear current controls in the panel
            Add_Leave_Form Add_Leave_Form_New = new Add_Leave_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; // Create a new add leave form
            Add_Leave_Form_New.FormBorderStyle = FormBorderStyle.None; // Set form border style
            this.Management_Form_Panel.Controls.Add(Add_Leave_Form_New); // Add the new form to the panel
            Add_Leave_Form_New.Show(); // Show the new form
        }

        //the Leave Status button click event
        private void Btn_LeaveStatus_Click(object sender, EventArgs e)
        {
            this.Management_Form_Panel.Controls.Clear(); // Clear current controls in the panel
            Leave_Status_Form Leave_Status_Form_New = new Leave_Status_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; // Create a new leave status form 
            Leave_Status_Form_New.FormBorderStyle = FormBorderStyle.None; // Set form border style
            this.Management_Form_Panel.Controls.Add(Leave_Status_Form_New); // Add the new form to the panel
            Leave_Status_Form_New.Show(); // Show the new form
        }

        //the Leave History button click event
        private void Btn_LeaveHistory_Click(object sender, EventArgs e)
        {
            this.Management_Form_Panel.Controls.Clear(); // Clear current controls in the panel
            Leave_History_Form Leave_History_Form_New = new Leave_History_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; // Create a new leave history form
            Leave_History_Form_New.FormBorderStyle = FormBorderStyle.None; // Set form border style
            this.Management_Form_Panel.Controls.Add(Leave_History_Form_New); // Add the new form to the panel
            Leave_History_Form_New.Show(); // Show the new form
        }
    }
}

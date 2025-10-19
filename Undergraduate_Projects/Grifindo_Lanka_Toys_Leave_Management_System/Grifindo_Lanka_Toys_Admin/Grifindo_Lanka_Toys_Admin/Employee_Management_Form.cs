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
    public partial class Employee_Management_Form : Form
    {
        public Employee_Management_Form()
        {
            InitializeComponent();
            
        }

        //Clear Button to Hide Contents
        private void Clear_Button() 
        {
            Btn_RegisterEmployee.Visible = false;  // Hide the Register Employee button
            Btn_LeavePolicy.Visible = false;  // Hide the Leave Policy button
            Btn_Roster.Visible = false;  // Hide the Roster button
            Btn_LeaveApproval.Visible = false;  // Hide the Leave Approval button

        }

        // Register Employee button click
        private void Btn_RegisterEmployee_Click(object sender, EventArgs e)
        {
            // Clear the current controls in the Management Form Panel
            this.Management_Form_Panel.Controls.Clear();
            // Create a new object for Register Employee form and set its properties   // Fill the panel with the form // Set as non-top-level form (so it can be embedded in the panel)  // Set the form to be on top within its container
            Register_Employee_Form Register_Employee_Form_New = new Register_Employee_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            // Remove the form's border
            Register_Employee_Form_New.FormBorderStyle = FormBorderStyle.None;
            // Add the Register Employee form to the panel
            this.Management_Form_Panel.Controls.Add(Register_Employee_Form_New);
            // Display the Register Employee form within the panel
            Register_Employee_Form_New.Show();


        }

        //the Leave Policy button click Event
        private void Btn_LeavePolicy_Click(object sender, EventArgs e)
        {
            // Clear the current controls in the Management Form Panel
            this.Management_Form_Panel.Controls.Clear();
            // Create a new instance of the Leave Policy form and set its properties    // Fill the panel with the form // Set as non-top-level form (so it can be embedded in the panel)  // Set the form to be on top within its container
            Leave_Policy_Form Leave_Policy_Form_New = new Leave_Policy_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            // Remove the form's border
            Leave_Policy_Form_New.FormBorderStyle = FormBorderStyle.None;
            // Add the Leave Policy form to the panel
            this.Management_Form_Panel.Controls.Add(Leave_Policy_Form_New);
            // Display the Leave Policy form within the panel
            Leave_Policy_Form_New.Show();
        }

        //the Roster button click Event
        private void Btn_Roster_Click(object sender, EventArgs e)
        {
            // Clear the current controls in the Management Form Panel
            this.Management_Form_Panel.Controls.Clear();
            // Create a new instance of the Roster form and set its properties    // Fill the panel with the form // Set as non-top-level form (so it can be embedded in the panel)  // Set the form to be on top within its container
            Roster_Form Roster_Form_New = new Roster_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            // Remove the form's border
            Roster_Form_New.FormBorderStyle = FormBorderStyle.None;
            // Add the Roster form to the panel
            this.Management_Form_Panel.Controls.Add(Roster_Form_New);
            // Display the Roster form within the panel
            Roster_Form_New.Show();


        }

        //the Leave Approval button click event
        private void Btn_LeaveApproval_Click(object sender, EventArgs e)
        {
            // Clear the current controls in the Management Form Panel
            this.Management_Form_Panel.Controls.Clear();
            // Create a new instance of the Leave Approval form and set its properties    // Fill the panel with the form // Set as non-top-level form (so it can be embedded in the panel)  // Set the form to be on top within its container
            Leave_Approval_Form Leave_Approval_Form_New = new Leave_Approval_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            // Remove the form's border
            Leave_Approval_Form_New.FormBorderStyle = FormBorderStyle.None;
            // Add the Leave Approval form to the panel
            this.Management_Form_Panel.Controls.Add(Leave_Approval_Form_New);
            // Display the Leave Approval form within the panel
            Leave_Approval_Form_New.Show();

        }

        private void Management_Label_Click(object sender, EventArgs e)
        {

        }

        private void Management_Form_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


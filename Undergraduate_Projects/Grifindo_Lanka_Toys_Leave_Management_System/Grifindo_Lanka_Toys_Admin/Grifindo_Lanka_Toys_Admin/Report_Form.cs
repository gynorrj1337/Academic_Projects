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
    public partial class Report_Form : Form
    {
        public Report_Form()
        {
            InitializeComponent();
        }

        //for the LeaveEmployee button
        private void Btn_LeaveEmployee_Click(object sender, EventArgs e)
        {
            this.Pnl_Management_Form.Controls.Clear(); // Clear existing controls from the panel
            // Create a new object of Employee_Leave_Report_Form  // Fill the panel with the form   // Set the form as not top-level    // Make Sure the form is displayed above others 
            Employee_Leave_Report_Form Employee_Leave_Report_Form_New = new Employee_Leave_Report_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Employee_Leave_Report_Form_New.FormBorderStyle = FormBorderStyle.None; // Remove the form's border
            this.Pnl_Management_Form.Controls.Add(Employee_Leave_Report_Form_New); // Add the new form to the panel
            Employee_Leave_Report_Form_New.Show(); // Display the new form

        }
    }
}

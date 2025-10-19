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
    public partial class Management_Form : Form
    {
        public Management_Form()
        {
            InitializeComponent();
        }

        //the Leave button click event
        private void Btn_Leave_Click(object sender, EventArgs e)
        {
            this.Pnl_Management_Form.Controls.Clear(); // Clear current controls in the panel
            Leave_Management_Form Employee_Management_Form_New = new Leave_Management_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; // Create a new leave management form
            Employee_Management_Form_New.FormBorderStyle = FormBorderStyle.None; // Set form border style
            this.Pnl_Management_Form.Controls.Add(Employee_Management_Form_New); // Add the new form to the panel
            Employee_Management_Form_New.Show(); // Show the new form

        }
    }
}

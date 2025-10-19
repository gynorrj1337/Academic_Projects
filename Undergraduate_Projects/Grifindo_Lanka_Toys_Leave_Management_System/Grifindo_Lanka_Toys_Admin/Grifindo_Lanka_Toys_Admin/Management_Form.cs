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
    public partial class Management_Form : Form
    {
        public Management_Form()
        {
            InitializeComponent();
        }

        // for the Employee button click
        private void Btn_Employee_Click(object sender, EventArgs e)
        {
            // Clear any existing controls from the management panel
            this.Pnl_Management_Form.Controls.Clear();
            // Create a new instance of the Employee Management form and set its properties          // Fill the panel with the form // Set as non-top-level form (so it can be embedded in the panel)  // Set the form to be on top within its container
            Employee_Management_Form Employee_Management_Form_New = new Employee_Management_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            // Remove the form's border
            Employee_Management_Form_New.FormBorderStyle = FormBorderStyle.None;
            // Add the Employee Management form to the panel
            this.Pnl_Management_Form.Controls.Add(Employee_Management_Form_New);
            // Display the Employee Management form within the panel
            Employee_Management_Form_New.Show();

        }

        private void Management_Label_Click(object sender, EventArgs e)
        {

        }

        private void Pnl_Management_Form_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

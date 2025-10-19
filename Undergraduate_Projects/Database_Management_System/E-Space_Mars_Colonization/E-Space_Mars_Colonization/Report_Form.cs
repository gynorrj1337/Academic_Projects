using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Space_Mars_Colonization
{
    public partial class Report_Form : Form
    {
        public Report_Form()
        {
            InitializeComponent();
        }

        private void Colonist_Report_Button_Click(object sender, EventArgs e)
        {
            Colonist_Report_Button.Visible = false;
            Colony_Report_Button.Visible = false;
            Jet_Report_Button.Visible = false;
            Job_Report_Button.Visible = false;
            Trip_Report_Button.Visible = false;

            this.Report_Form_Panel.Controls.Clear();
            Colonist_Report Colonist_Report_New = new Colonist_Report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Colonist_Report_New.FormBorderStyle = FormBorderStyle.None;
            this.Report_Form_Panel.Controls.Add(Colonist_Report_New);
            Colonist_Report_New.Show();

        }

        private void Colony_Report_Button_Click(object sender, EventArgs e)
        {
            Colonist_Report_Button.Visible = false;
            Colony_Report_Button.Visible = false;
            Jet_Report_Button.Visible = false;
            Job_Report_Button.Visible = false;
            Trip_Report_Button.Visible = false;

            this.Report_Form_Panel.Controls.Clear();
            Colony_Report Colony_Report_New = new Colony_Report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Colony_Report_New.FormBorderStyle = FormBorderStyle.None;
            this.Report_Form_Panel.Controls.Add(Colony_Report_New);
            Colony_Report_New.Show();


        }

        private void Jet_Report_Button_Click(object sender, EventArgs e)
        {
            Colonist_Report_Button.Visible = false;
            Colony_Report_Button.Visible = false;
            Jet_Report_Button.Visible = false;
            Job_Report_Button.Visible = false;
            Trip_Report_Button.Visible = false;

            this.Report_Form_Panel.Controls.Clear();
            Jet_Report Jet_Report_New = new Jet_Report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Jet_Report_New.FormBorderStyle = FormBorderStyle.None;
            this.Report_Form_Panel.Controls.Add(Jet_Report_New);
            Jet_Report_New.Show();
        }

        private void Job_Report_Button_Click(object sender, EventArgs e)
        {
            Colonist_Report_Button.Visible = false;
            Colony_Report_Button.Visible = false;
            Jet_Report_Button.Visible = false;
            Job_Report_Button.Visible = false;
            Trip_Report_Button.Visible = false;

            this.Report_Form_Panel.Controls.Clear();
            Job_Report Job_Report_New = new Job_Report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Job_Report_New.FormBorderStyle = FormBorderStyle.None;
            this.Report_Form_Panel.Controls.Add(Job_Report_New);
            Job_Report_New.Show();
        }

        private void Trip_Report_Button_Click(object sender, EventArgs e)
        {
            Colonist_Report_Button.Visible = false;
            Colony_Report_Button.Visible = false;
            Jet_Report_Button.Visible = false;
            Job_Report_Button.Visible = false;
            Trip_Report_Button.Visible = false;

            this.Report_Form_Panel.Controls.Clear();
            Trip_Report Trip_Report_New = new Trip_Report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Trip_Report_New.FormBorderStyle = FormBorderStyle.None;
            this.Report_Form_Panel.Controls.Add(Trip_Report_New);
            Trip_Report_New.Show();


        }
    }
}

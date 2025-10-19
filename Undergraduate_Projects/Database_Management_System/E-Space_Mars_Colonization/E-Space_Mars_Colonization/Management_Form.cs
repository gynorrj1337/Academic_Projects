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
    public partial class Management_Form : Form
    {
        public Management_Form()
        {
            InitializeComponent();
        }

        private void Colonist_Button_Click(object sender, EventArgs e)
        {
            Colonist_Button.Visible = false;
            Dependent_Button.Visible = false;
            EJet_Button.Visible = false;
            EJet_Pilot_Button.Visible = false;
            Trip_Button.Visible = false;
            Mars_Colony_Button.Visible = false;
            Job_Button.Visible = false;
            Colonist_Job_Button.Visible = false;
            Jet_Assignment_Button.Visible = false;
            Colony_Assignment_Button.Visible = false;

            this.Management_Form_Panel.Controls.Clear();
            Colonist_Management Colonist_Management_New = new Colonist_Management() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Colonist_Management_New.FormBorderStyle = FormBorderStyle.None;
            this.Management_Form_Panel.Controls.Add(Colonist_Management_New);
            Colonist_Management_New.Show();

        }

        private void Dependent_Button_Click(object sender, EventArgs e)
        {
            Colonist_Button.Visible = false;
            Dependent_Button.Visible = false;
            EJet_Button.Visible = false;
            EJet_Pilot_Button.Visible = false;
            Trip_Button.Visible = false;
            Mars_Colony_Button.Visible = false;
            Job_Button.Visible = false;
            Colonist_Job_Button.Visible = false;
            Jet_Assignment_Button.Visible = false;
            Colony_Assignment_Button.Visible = false;

            this.Management_Form_Panel.Controls.Clear();
            Dependent_Management Dependent_Management_New = new Dependent_Management() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Dependent_Management_New.FormBorderStyle = FormBorderStyle.None;
            this.Management_Form_Panel.Controls.Add(Dependent_Management_New);
            Dependent_Management_New.Show();

        }

        private void EJet_Button_Click(object sender, EventArgs e)
        {
            Colonist_Button.Visible = false;
            Dependent_Button.Visible = false;
            EJet_Button.Visible = false;
            EJet_Pilot_Button.Visible = false;
            Trip_Button.Visible = false;
            Mars_Colony_Button.Visible = false;
            Job_Button.Visible = false;
            Colonist_Job_Button.Visible = false;
            Jet_Assignment_Button.Visible = false;
            Colony_Assignment_Button.Visible = false;

            this.Management_Form_Panel.Controls.Clear();
            EJet_Management EJet_Management_New = new EJet_Management() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            EJet_Management_New.FormBorderStyle = FormBorderStyle.None;
            this.Management_Form_Panel.Controls.Add(EJet_Management_New);
            EJet_Management_New.Show();

        }

        private void EJet_Pilot_Button_Click(object sender, EventArgs e)
        {
            Colonist_Button.Visible = false;
            Dependent_Button.Visible = false;
            EJet_Button.Visible = false;
            EJet_Pilot_Button.Visible = false;
            Trip_Button.Visible = false;
            Mars_Colony_Button.Visible = false;
            Job_Button.Visible = false;
            Colonist_Job_Button.Visible = false;
            Jet_Assignment_Button.Visible = false;
            Colony_Assignment_Button.Visible = false;

            this.Management_Form_Panel.Controls.Clear();
            EJet_Pilot_Management EJet_Pilot_Management_New = new EJet_Pilot_Management() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            EJet_Pilot_Management_New.FormBorderStyle = FormBorderStyle.None;
            this.Management_Form_Panel.Controls.Add(EJet_Pilot_Management_New);
            EJet_Pilot_Management_New.Show();

        }

        private void Trip_Button_Click(object sender, EventArgs e)
        {
            Colonist_Button.Visible = false;
            Dependent_Button.Visible = false;
            EJet_Button.Visible = false;
            EJet_Pilot_Button.Visible = false;
            Trip_Button.Visible = false;
            Mars_Colony_Button.Visible = false;
            Job_Button.Visible = false;
            Colonist_Job_Button.Visible = false;
            Jet_Assignment_Button.Visible = false;
            Colony_Assignment_Button.Visible = false;

            this.Management_Form_Panel.Controls.Clear();
            Trip_Management Trip_Management_New = new Trip_Management() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Trip_Management_New.FormBorderStyle = FormBorderStyle.None;
            this.Management_Form_Panel.Controls.Add(Trip_Management_New);
            Trip_Management_New.Show();

        }

        private void Mars_Colony_Button_Click(object sender, EventArgs e)
        {
            Colonist_Button.Visible = false;
            Dependent_Button.Visible = false;
            EJet_Button.Visible = false;
            EJet_Pilot_Button.Visible = false;
            Trip_Button.Visible = false;
            Mars_Colony_Button.Visible = false;
            Job_Button.Visible = false;
            Colonist_Job_Button.Visible = false;
            Jet_Assignment_Button.Visible = false;
            Colony_Assignment_Button.Visible = false;

            this.Management_Form_Panel.Controls.Clear();
            Mars_Colony_Management Mars_Colony_Management_New = new Mars_Colony_Management() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Mars_Colony_Management_New.FormBorderStyle = FormBorderStyle.None;
            this.Management_Form_Panel.Controls.Add(Mars_Colony_Management_New);
            Mars_Colony_Management_New.Show();

        }

        private void Job_Button_Click(object sender, EventArgs e)
        {
            Colonist_Button.Visible = false;
            Dependent_Button.Visible = false;
            EJet_Button.Visible = false;
            EJet_Pilot_Button.Visible = false;
            Trip_Button.Visible = false;
            Mars_Colony_Button.Visible = false;
            Job_Button.Visible = false;
            Colonist_Job_Button.Visible = false;
            Jet_Assignment_Button.Visible = false;
            Colony_Assignment_Button.Visible = false;

            this.Management_Form_Panel.Controls.Clear();
            Job_Management Job_Management_New = new Job_Management() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Job_Management_New.FormBorderStyle = FormBorderStyle.None;
            this.Management_Form_Panel.Controls.Add(Job_Management_New);
            Job_Management_New.Show();

        }

        private void Colonist_Job_Button_Click(object sender, EventArgs e)
        {
            Colonist_Button.Visible = false;
            Dependent_Button.Visible = false;
            EJet_Button.Visible = false;
            EJet_Pilot_Button.Visible = false;
            Trip_Button.Visible = false;
            Mars_Colony_Button.Visible = false;
            Job_Button.Visible = false;
            Colonist_Job_Button.Visible = false;
            Jet_Assignment_Button.Visible = false;
            Colony_Assignment_Button.Visible = false;

            this.Management_Form_Panel.Controls.Clear();
            Colonist_Job_Management Colonist_Job_Management_New = new Colonist_Job_Management() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Colonist_Job_Management_New.FormBorderStyle = FormBorderStyle.None;
            this.Management_Form_Panel.Controls.Add(Colonist_Job_Management_New);
            Colonist_Job_Management_New.Show();

        }

        private void Jet_Assignment_Button_Click(object sender, EventArgs e)
        {
            Colonist_Button.Visible = false;
            Dependent_Button.Visible = false;
            EJet_Button.Visible = false;
            EJet_Pilot_Button.Visible = false;
            Trip_Button.Visible = false;
            Mars_Colony_Button.Visible = false;
            Job_Button.Visible = false;
            Colonist_Job_Button.Visible = false;
            Jet_Assignment_Button.Visible = false;
            Colony_Assignment_Button.Visible = false;

            this.Management_Form_Panel.Controls.Clear();
            Jet_Assignment_Management Jet_Assignment_Management_New = new Jet_Assignment_Management() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Jet_Assignment_Management_New.FormBorderStyle = FormBorderStyle.None;
            this.Management_Form_Panel.Controls.Add(Jet_Assignment_Management_New);
            Jet_Assignment_Management_New.Show();

        }

        private void Job_Assignment_Button_Click(object sender, EventArgs e)
        {
            Colonist_Button.Visible = false;
            Dependent_Button.Visible = false;
            EJet_Button.Visible = false;
            EJet_Pilot_Button.Visible = false;
            Trip_Button.Visible = false;
            Mars_Colony_Button.Visible = false;
            Job_Button.Visible = false;
            Colonist_Job_Button.Visible = false;
            Jet_Assignment_Button.Visible = false;
            Colony_Assignment_Button.Visible = false;

            this.Management_Form_Panel.Controls.Clear();
            Job_Management Job_Management_New = new Job_Management() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Job_Management_New.FormBorderStyle = FormBorderStyle.None;
            this.Management_Form_Panel.Controls.Add(Job_Management_New);
            Job_Management_New.Show();

        }

        private void Colony_Assignment_Button_Click(object sender, EventArgs e)
        {
            Colonist_Button.Visible = false;
            Dependent_Button.Visible = false;
            EJet_Button.Visible = false;
            EJet_Pilot_Button.Visible = false;
            Trip_Button.Visible = false;
            Mars_Colony_Button.Visible = false;
            Job_Button.Visible = false;
            Colonist_Job_Button.Visible = false;
            Jet_Assignment_Button.Visible = false;
            Colony_Assignment_Button.Visible = false;

            this.Management_Form_Panel.Controls.Clear();
            House_Assignment_Management House_Assignment_Management_New = new House_Assignment_Management() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            House_Assignment_Management_New.FormBorderStyle = FormBorderStyle.None;
            this.Management_Form_Panel.Controls.Add(House_Assignment_Management_New);
            House_Assignment_Management_New.Show();


        }
    }
}

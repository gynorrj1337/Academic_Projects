using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Space_Mars_Colonization
{
    public partial class Job_Report : Form
    {
        public Job_Report()
        {
            InitializeComponent();
        }

        private void Display_Button_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; "))
                {
                    sqlCon.Open();

                    // Prepare SQL query and data adapter
                    SqlDataAdapter sqlDa = new SqlDataAdapter(@"
                    SELECT 
                    Colonist.Colonist_ID, 
                    Colonist.First_Name AS Colonist_FirstName, 
                    Colonist.Middle_Name AS Colonist_MiddleName, 
                    Colonist.Last_Name AS Colonist_LastName, 
                    Colonist.Date_Of_Birth AS Colonist_DateOfBirth, 
                    Job.Job_Title AS Job_Assigned, 
                    Job.Job_Qualification, 
                    Job.Job_Type, 
                    Job.Job_Salary
                FROM 
                    Colonist
                JOIN 
                    Colonist_Job ON Colonist.Colonist_ID = Colonist_Job.Colonist_ID
                JOIN 
                    Job ON Colonist_Job.Job_ID = Job.Job_ID", sqlCon);


                    DataTable dtbl = new DataTable(); 
                    sqlDa.Fill(dtbl); 


                    Job_DGV.DataSource = dtbl; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }

        }

    }
    
}

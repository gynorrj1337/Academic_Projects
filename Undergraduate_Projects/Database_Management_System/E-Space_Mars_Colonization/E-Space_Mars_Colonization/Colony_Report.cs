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
    public partial class Colony_Report : Form
    {
        public Colony_Report()
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
                    Mars_Colony.Colony_Lot_No, 
                    Mars_Colony.No_of_Rooms AS Number_of_Rooms, 
                    Mars_Colony.Square_Feet, 
                    Colony_Assignment.Colonist_ID, 
                    Colonist.First_Name AS Colonist_FirstName, 
                    Colonist.Middle_Name AS Colonist_MiddleName, 
                    Colonist.Last_Name AS Colonist_LastName, 
                    (
                        SELECT STUFF((
                            SELECT ', ' + CAST(Dependent.DependentID AS VARCHAR(10))
                            FROM Dependent
                            WHERE Dependent.Colonist_ID = Colony_Assignment.Colonist_ID
                            FOR XML PATH('')
                        ), 1, 2, '')
                    ) AS Dependent_IDs,
                    (
                        SELECT STUFF((
                            SELECT ', ' + Dependent.First_Name
                            FROM Dependent
                            WHERE Dependent.Colonist_ID = Colony_Assignment.Colonist_ID
                            FOR XML PATH('')
                        ), 1, 2, '')
                    ) AS Dependent_Names
                FROM 
                    Mars_Colony
                JOIN 
                    Colony_Assignment ON Mars_Colony.Colony_Lot_No = Colony_Assignment.Colony_Lot_No
                JOIN 
                    Colonist ON Colony_Assignment.Colonist_ID = Colonist.Colonist_ID", sqlCon);

                    DataTable dtbl = new DataTable(); 
                    sqlDa.Fill(dtbl); 


                    Colony_DGV.DataSource = dtbl; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }

        }
    }
}

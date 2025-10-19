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
    public partial class Colonist_Report : Form
    {
        public Colonist_Report()
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

                   
                    SqlDataAdapter sqlDa = new SqlDataAdapter(@"
                    SELECT 
                    Colonist.Colonist_ID, 
                    Colonist.First_Name AS Colonist_FirstName, 
                    Colonist.Middle_Name AS Colonist_MiddleName, 
                    Colonist.Last_Name AS Colonist_LastName, 
                    Colonist.Date_Of_Birth AS Colonist_DateOfBirth, 
                    Colonist.Earth_Address, 
                    Colonist.Civil_Status, 
                    (
                        SELECT STUFF((
                            SELECT ', ' + Colonist_Qualification.Qualification_Description
                            FROM Colonist_Qualification
                            WHERE Colonist_Qualification.Colonist_ID = Colonist.Colonist_ID
                            FOR XML PATH('')
                        ), 1, 2, '') AS Colonist_Qualification
                    ) AS Colonist_Qualification,
                    Colonist.Family_Members_Count,
                    (
                        SELECT STUFF((
                            SELECT ', ' + CAST(Dependent.DependentID AS VARCHAR(MAX))
                            FROM Dependent
                            WHERE Dependent.Colonist_ID = Colonist.Colonist_ID
                            FOR XML PATH('')
                        ), 1, 2, '') AS Dependent_IDs
                    ) AS Dependent_IDs,
                    (
                        SELECT STUFF((
                            SELECT ', ' + Dependent.First_Name
                            FROM Dependent
                            WHERE Dependent.Colonist_ID = Colonist.Colonist_ID
                            FOR XML PATH('')
                        ), 1, 2, '') AS Dependent_FirstNames
                    ) AS Dependent_FirstNames,
                    (
                        SELECT STUFF((
                            SELECT ', ' + Dependent.Last_Name
                            FROM Dependent
                            WHERE Dependent.Colonist_ID = Colonist.Colonist_ID
                            FOR XML PATH('')
                        ), 1, 2, '') AS Dependent_LastNames
                    ) AS Dependent_LastNames,
                    (
                        SELECT STUFF((
                            SELECT ', ' + CONVERT(VARCHAR, Dependent.Date_Of_Birth, 101)
                            FROM Dependent
                            WHERE Dependent.Colonist_ID = Colonist.Colonist_ID
                            FOR XML PATH('')
                        ), 1, 2, '') AS Dependent_DateOfBirth
                    ) AS Dependent_DateOfBirth,
                    (
                        SELECT STUFF((
                            SELECT ', ' + Dependent.Gender
                            FROM Dependent
                            WHERE Dependent.Colonist_ID = Colonist.Colonist_ID
                            FOR XML PATH('')
                        ), 1, 2, '') AS Dependent_Gender
                    ) AS Dependent_Gender,
                    (
                        SELECT STUFF((
                            SELECT ', ' + Dependent.Relationship_to_Colonist
                            FROM Dependent
                            WHERE Dependent.Colonist_ID = Colonist.Colonist_ID
                            FOR XML PATH('')
                        ), 1, 2, '') AS Relationship_to_Colonist
                    ) AS Relationship_to_Colonist
                FROM 
                    Colonist", sqlCon);

                    DataTable dtbl = new DataTable(); 
                    sqlDa.Fill(dtbl); 


                    Colonist_DGV.DataSource = dtbl; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }

        

    }
    }
}

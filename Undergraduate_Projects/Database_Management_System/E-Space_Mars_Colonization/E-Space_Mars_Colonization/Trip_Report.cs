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
    public partial class Trip_Report : Form
    {
        public Trip_Report()
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
                    Trip.Trip_ID, 
                    EJet.EJet_ID AS Jet_ID, 
                    Trip.Launch_Date, 
                    Trip.Return_Date, 
                    Trip_Passenger.Colonist_ID, 
                    Colonist.First_Name AS Colonist_FirstName, 
                    Colonist.Middle_Name AS Colonist_MiddleName, 
                    Colonist.Last_Name AS Colonist_LastName, 
                    Colonist.Date_Of_Birth AS Colonist_DateOfBirth, 
                    (
                        SELECT STUFF((
                            SELECT ', ' + Dependent.First_Name
                            FROM Dependent
                            WHERE Dependent.Colonist_ID = Trip_Passenger.Colonist_ID
                            FOR XML PATH('')
                        ), 1, 2, '') 
                    ) AS Dependent_Names
                FROM 
                    Trip
                JOIN 
                    Trip_Passenger ON Trip.Trip_ID = Trip_Passenger.Trip_ID
                JOIN 
                    Colonist ON Trip_Passenger.Colonist_ID = Colonist.Colonist_ID
                LEFT JOIN 
                    EJet ON Trip.EJet_ID = EJet.EJet_ID", sqlCon);


                    DataTable dtbl = new DataTable(); 
                    sqlDa.Fill(dtbl); 


                    Trip_DGV.DataSource = dtbl; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }

}


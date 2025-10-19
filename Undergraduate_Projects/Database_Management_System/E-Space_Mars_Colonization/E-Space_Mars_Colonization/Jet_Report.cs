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
    public partial class Jet_Report : Form
    {
        SqlConnection connectionString = new SqlConnection(@"Data Source=Code-Maestro;Initial Catalog=Mars_Colonization;Integrated Security=True; ");

        public Jet_Report()
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
                        EJet.EJet_ID, 
                        EJet.Passenger_Seats, 
                        EJet.EJet_Type, 
                        EJet.Made_Year, 
                        EJet.Weight, 
                        EJet.Power_Source, 
                        Jet_Assignment.Pilot_ID, 
                        Pilot.First_Name + ' ' + Pilot.Designation AS Pilot_Name
                    FROM 
                        EJet
                    LEFT JOIN 
                        Jet_Assignment ON EJet.EJet_ID = Jet_Assignment.EJet_ID
                    LEFT JOIN 
                        Pilot ON Jet_Assignment.Pilot_ID = Pilot.Pilot_ID;", sqlCon);

                    DataTable dtbl = new DataTable(); 
                    sqlDa.Fill(dtbl); 

                    
                    EJet_DGV.DataSource = dtbl; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }

        }
    }
}

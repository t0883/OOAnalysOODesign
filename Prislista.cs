using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAnalysOODesign
{
    public partial class Prislista : Form
    {
        MySqlConnection conn;

        int ZonApris;
        int ZonBpris;
        int ZonCpris;


        public Prislista()
        {
            InitializeComponent();

            //Skapa en MySQL connection objekt
            string server = "localhost";
            string database = "bussappDB";
            string user = "root";
            string password = "EttSuperHemligtLösenord123!";

            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";

            conn = new MySqlConnection(connString);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Hämtar prisen från databasen

            getPriceFromDB();
        }

        private void getPriceFromDB()
        {
            string sqlQuery = "SELECT * FROM bussappdb.pristabell;";

            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            try
            {
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ZonApris = reader.GetInt32(1);
                    ZonBpris = reader.GetInt32(2);
                    ZonCpris = reader.GetInt32(3);

                    lblZonApris.Text = $"{ZonApris} kr";
                    lblZonBpris.Text = $"{ZonBpris} kr";
                    lblZonCpris.Text = $"{ZonCpris} kr";

                    lblZonABpris.Text = $"{(ZonApris + ZonBpris)} kr";
                    lblZonBCpris.Text = $"{(ZonBpris + ZonCpris)} kr";
                    lblZonACpris.Text = $"{(ZonApris + ZonCpris)} kr";


                }

                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}

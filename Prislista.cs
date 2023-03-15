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

            Database database = new Database();

            conn = database.GetConnection();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Hämtar prisen från databasen

            getPriceFromDB();
        }

        private void getPriceFromDB()
        {
            Database database = new Database();

            string sqlQuery = "SELECT * FROM bussappdb.pristabell;";


            try
            {

                database.OpenConnection();

                MySqlConnection conn = database.GetConnection();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

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

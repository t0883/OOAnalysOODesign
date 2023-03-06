using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAnalysOODesign
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        private ComboBox[] comboBoxes;

        int ZonA;
        int ZonB;
        int ZonC;

        public Form1()
        {
            InitializeComponent();

            //Skapa en MySQL connection objekt
            string server = "localhost";
            string database = "bussappDB";
            string user = "root";
            string password = "!Phuglife9835";

            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";

            conn = new MySqlConnection(connString);

            comboBoxes = new ComboBox[] { cbHållplats1, cbHållplats2 };
        }

        private void tidtabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }

        private void biljettprisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
        }

        private void loggaInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.Show();
        }

        private void regitreraKontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            form5.Show();
        }

        private void getStopsfromDB()
        {
            string sqlQuery = "SELECT * FROM bussappdb.hållplatser;";

            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

            try
            {
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                
                    while (reader.Read())
                    {
                        cbHållplats1.Items.Add((string)reader["Hållplatsnamn"]);
                        cbHållplats2.Items.Add((string)reader["Hållplatsnamn"]);

                        string hållplatsnamn = reader.GetString(1);
                        string hållplatszon = reader.GetString(2);


                        Hållplats.hållplatser.Add(new Hållplats(hållplatsnamn, hållplatszon));

                        //MessageBox.Show($"{hållplatsnamn} {hållplatszon}");
                    }

                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
                    ZonA = reader.GetInt32(1);
                    ZonB = reader.GetInt32(2);
                    ZonC = reader.GetInt32(3);

                    lblZonAPris.Text = $"{ZonA} kr";
                    lblZonBPris.Text = $"{ZonB} kr";
                    lblZonCPris.Text = $"{ZonC} kr";

                }
                
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getStopsfromDB();
            getPriceFromDB();
        }

        private void cbHållplats1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStartHållplats.Text = cbHållplats1.SelectedItem.ToString();
            lblStartHållplats.Show();

            foreach (Hållplats hållplater in Hållplats.hållplatser)
            {
                if(hållplater.hållplatsNamn == lblStartHållplats.Text)
                {
                    lblStartZon.Text = hållplater.hållplatsZon;

                    if (lblStartZon.Text == "A")
                    {
                        lblZonPrisStart.Text = ZonA.ToString();
                    }
                    if (lblStartZon.Text == "B")
                    {
                        lblZonPrisStart.Text = ZonB.ToString();
                    }
                    if (lblStartZon.Text == "C")
                    {
                        lblZonPrisStart.Text = ZonC.ToString();
                    }
                }
            }

            lblStartZonfast.Show();
            lblStartZon.Show();
            lblStartPris.Show();
            lblZonPrisStart.Show();

        }

        private void cbHållplats2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSlutHållplats.Text = cbHållplats2.SelectedItem.ToString();
            lblSlutHållplats.Show();

            foreach (Hållplats hållplatser in Hållplats.hållplatser)
            {
                if (hållplatser.hållplatsNamn == lblSlutHållplats.Text)
                {
                    lblSlutZon.Text = hållplatser.hållplatsZon;

                    if(lblSlutZon.Text == "A")
                    {
                        lblZonPrisSlut.Text = ZonA.ToString();
                    }
                    if (lblSlutZon.Text == "B")
                    {
                        lblZonPrisSlut.Text = ZonB.ToString();
                    }
                    if (lblSlutZon.Text == "C")
                    {
                        lblZonPrisSlut.Text = ZonC.ToString();
                    }
                }
            }

            lblSlutZonfast.Show();
            lblSlutZon.Show();
            lblSlutPris.Show();
            lblZonPrisSlut.Show();


        }
    }
}

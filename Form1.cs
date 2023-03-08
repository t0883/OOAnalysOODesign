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
            string password = "";

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
                        string pris = ZonA.ToString();

                        lblZonPrisStart.Text = $"{pris}";
                    }
                    if (lblStartZon.Text == "B")
                    {
                        string pris = ZonB.ToString();

                        lblZonPrisStart.Text = $"{pris}";
                    }
                    if (lblStartZon.Text == "C")
                    {
                        string pris = ZonC.ToString();

                        lblZonPrisStart.Text = $"{pris}";
                    }
                }
            }

            lblStartZonfast.Show();
            lblStartZon.Show();
            lblStartPris.Show();
            lblZonPrisStart.Show();
            lblStartValuta.Show();

            checkOut();

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
                        string pris = ZonA.ToString();

                        lblZonPrisSlut.Text = $"{pris}";

                    }
                    if (lblSlutZon.Text == "B")
                    {
                        string pris = ZonB.ToString();

                        lblZonPrisSlut.Text = $"{pris}";
                    }
                    if (lblSlutZon.Text == "C")
                    {
                        string pris = ZonC.ToString();

                        lblZonPrisSlut.Text = $"{pris}";
                    }
                }
            }

            lblSlutZonfast.Show();
            lblSlutZon.Show();
            lblSlutPris.Show();
            lblZonPrisSlut.Show();
            lblSlutValuta.Show();

            checkOut();

        }

        private void checkOut()
        {
            if (lblSlutPris.Visible == true && lblStartPris.Visible == true)
            {
                int pris1 = Convert.ToInt32(lblZonPrisStart.Text);
                int pris2 = Convert.ToInt32(lblZonPrisSlut.Text);

                if(pris1 == pris2)
                {
                    lblTotalPris.Text = $"{pris1}";
                }
                else { lblTotalPris.Text = $"{pris1 + pris2}"; }

                


                btnKöp.Show();
                lblBiljettpris.Show();
                lblTotalPris.Show();
                lblTotalValuta.Show();
            }
        }

        private void btnKöp_Click(object sender, EventArgs e)
        {

            string pris = lblTotalPris.Text;
            MessageBox.Show($"Köpet har genomförts. {pris} kr har dragits från ditt konto.");
        }
    }
}

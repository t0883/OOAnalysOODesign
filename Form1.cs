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
            string password = "EttSuperHemligtLösenord123!";

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
            // Denna metoden hämtar alla stoppen från databasen.

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

                        // Lägger in alla hållplatser tillsammans med hållplatsenszon i en lista i klassen Hållplats
                        Hållplats.hållplatser.Add(new Hållplats(hållplatsnamn, hållplatszon));

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

            // Denna metoden hämtar priset för hållplatserna och stoppar in det i ett par labels.

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
            // När applikationen startar så exekveras dessa metoderna som hämtar stoppen och prisen från databasen.

            getStopsfromDB();
            getPriceFromDB();
        }

        private void cbHållplats1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Använder combobox för att välja hållplats. Den uppdateras efter varje val och det valda värdet uppdateras in i en label för förtydligande.

            if(cbHållplats1.SelectedItem== null) { return; }

            lblStartHållplats.Text = cbHållplats1.SelectedItem.ToString();
            lblStartHållplats.Show();

            // Använder en foreach loop för att hämta hållplatsens zon och lägger det värdet i en label.
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

            // Visar ett par labels till
            lblStartZonfast.Show();
            lblStartZon.Show();
            lblStartPris.Show();
            lblZonPrisStart.Show();
            lblStartValuta.Show();

            // Kallar på checkOut metoden.
            checkOut();

        }

        private void cbHållplats2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Använder combobox för att välja hållplats. Den uppdateras efter varje val och det valda värdet uppdateras in i en label för förtydligande.

            if (cbHållplats2.SelectedItem == null) { return; }

            lblSlutHållplats.Text = cbHållplats2.SelectedItem.ToString();
            lblSlutHållplats.Show();

            // Använder en foreach loop för att hämta hållplatsens zon och lägger det värdet i en label.
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

            // Visar ett par labels till
            lblSlutZonfast.Show();
            lblSlutZon.Show();
            lblSlutPris.Show();
            lblZonPrisSlut.Show();
            lblSlutValuta.Show();

            // Kallar på checkOut metoden. 
            checkOut();

        }

        private void checkOut()
        {
            // Detta är checkout metoden som kollar priset för den valda resan. 
            

            if (lblSlutPris.Visible == true && lblStartPris.Visible == true)
            {
                // Konverterar priset för resan till int så att det kan läggas ihop.

                int pris1 = Convert.ToInt32(lblZonPrisStart.Text);
                int pris2 = Convert.ToInt32(lblZonPrisSlut.Text);

                if(pris1 == pris2)
                {
                    // Om resan är inom samma zon så ska man bara betala för resan inom zonen. 

                    lblTotalPris.Text = $"{pris1}";

                    // Tar bort dessa labels för att förhindra missförstånd för användaren. 
                    lblSlutZonfast.Visible = false;
                    lblSlutZon.Visible = false;
                    lblSlutPris.Visible = false;
                    lblZonPrisSlut.Visible = false;
                    lblSlutValuta.Visible = false;
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
            // Knapp för att bekräfta köpet. 
            string pris = lblTotalPris.Text;
            DialogResult result1 = MessageBox.Show($"Vill du köpa en biljett för {pris} kr?", "", MessageBoxButtons.YesNo);

            if(result1 == DialogResult.No) 
            {
                cbHållplats1.SelectedItem = null;
                cbHållplats2.SelectedItem = null;

                btnKöp.Hide();
                lblBiljettpris.Hide();
                lblTotalPris.Hide();
                lblTotalValuta.Hide();
                lblSlutZonfast.Hide();
                lblSlutZon.Hide();
                lblSlutPris.Hide();
                lblZonPrisSlut.Hide();
                lblSlutValuta.Hide();
                lblStartZonfast.Hide();
                lblStartZon.Hide();
                lblStartPris.Hide();
                lblZonPrisStart.Hide();
                lblStartValuta.Hide();
                lblSlutHållplats.Hide();
                lblStartHållplats.Hide();
            }

            if (result1 == DialogResult.Yes)
            {
                cbHållplats1.SelectedItem = null;
                cbHållplats2.SelectedItem = null;

                btnKöp.Hide();
                lblBiljettpris.Hide();
                lblTotalPris.Hide();
                lblTotalValuta.Hide();
                lblSlutZonfast.Hide();
                lblSlutZon.Hide();
                lblSlutPris.Hide();
                lblZonPrisSlut.Hide();
                lblSlutValuta.Hide();
                lblStartZonfast.Hide();
                lblStartZon.Hide();
                lblStartPris.Hide();
                lblZonPrisStart.Hide();
                lblStartValuta.Hide();
                lblSlutHållplats.Hide();
                lblStartHållplats.Hide();
            }

        }

        
        private void uppdateraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // En metod för att kunna uppdatera utan att starta om applikationen ifall något skulle ändras i databasen.

            cbHållplats1.Items.Clear();
            cbHållplats2.Items.Clear();
            getStopsfromDB();
            getPriceFromDB();
        }
    }
}

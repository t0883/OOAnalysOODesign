using Microsoft.VisualBasic;
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
    public partial class Huvudmeny : Form
    {
        
        private ComboBox[] comboBoxes;

        int ZonA;
        int ZonB;
        int ZonC;

        public Huvudmeny()
        {
            InitializeComponent();
            
            comboBoxes = new ComboBox[] { cbHållplats1, cbHållplats2 };
        }

        private void tidtabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tidtabell tidtabell = new Tidtabell();

            tidtabell.Show();
        }

        private void biljettprisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prislista prislista = new Prislista();

            prislista.Show();
        }

        private void loggaInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggaIn loggaIn = new LoggaIn();

            loggaIn.Show();
        }

        private void regitreraKontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistreraKonto registreraKonto = new RegistreraKonto();

            registreraKonto.Show();
        }

        private void GetStopsfromDB()
        {
            // Denna metoden hämtar alla stoppen från databasen.

            Database database = new Database();

            string sqlQuery = "SELECT * FROM bussappdb.hållplatser;";

            try
            {
                database.OpenConnection();

                MySqlConnection conn = database.GetConnection();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

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

                database.CloseConnection();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }



        private void GetPriceFromDB()
        {

            Database database = new Database();

            // Denna metoden hämtar priset för hållplatserna och stoppar in det i ett par labels.

            string sqlQuery = "SELECT * FROM bussappdb.pristabell;";

            try
            {

                database.OpenConnection();

                MySqlConnection conn = database.GetConnection();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

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
                
                database.CloseConnection();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // När applikationen startar så exekveras dessa metoderna som hämtar stoppen och prisen från databasen.

            GetStopsfromDB();
            GetPriceFromDB();
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
            DialogResult result1 = MessageBox.Show($"Vill du köpa en biljett för {pris} kr för en resa från {lblStartHållplats.Text} till {lblSlutHållplats.Text}?", "", MessageBoxButtons.YesNo);

            if(result1 == DialogResult.No) 
            {
                cbHållplats1.SelectedItem = null;
                cbHållplats2.SelectedItem = null;

                hideLabels();
            }

            if (result1 == DialogResult.Yes)
            {
                string email = Interaction.InputBox("Vänligen fyll i din epostadress här:", "Bekräfta köp");

                if(email != "")
                {
                    MessageBox.Show("Tack för ditt köp! Din biljett kommer snart till din epost adress!");
                }

                cbHållplats1.SelectedItem = null;
                cbHållplats2.SelectedItem = null;

                hideLabels();
            }

        }

        
        private void uppdateraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // En metod för att kunna uppdatera utan att starta om applikationen ifall något skulle ändras i databasen.

            cbHållplats1.Items.Clear();
            cbHållplats2.Items.Clear();
            GetStopsfromDB();
            GetPriceFromDB();
        }

        private void hideLabels()
        {
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
}

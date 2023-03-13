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

    public partial class Form4 : Form
    {

        TextBox[] txtBoxes;
        public Form4()
        {
            InitializeComponent();

            txtBoxes = new TextBox[] { txtAnvändarnamn, txtLösenord };
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            //Validerar så att det finns något i textfälten.

            bool valid = true;

            // Loopar igenom textfälten för att kolla inputen från användaren.
            foreach (TextBox box in txtBoxes)
            {
                box.Text = box.Text.Trim();

                if (box.Text == "")
                {
                    valid = false;

                    box.BackColor = Color.Red;

                }
            }

            // Om valid inte är true så kommer användaren informeras om att fylla i ett korrekt användarnamn och lösenord samt att metoden för btnLoggaIn_Click avslutas.
            if (!valid)
            {
                MessageBox.Show("Vänligen fyll i ett korrekt användarnamn och lösenord!");
                return;
            }

            // Om valid är true så informeras användaren och boxarna töms från sitt innehåll och ändrar färgen till vit.
            MessageBox.Show("Du är nu inloggad.");

            foreach (TextBox box in txtBoxes)
            {
                box.Clear();
                box.BackColor = Color.White;
            }
        }
    }
}

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
            bool valid = true;

            foreach (TextBox box in txtBoxes)
            {
                box.Text = box.Text.Trim();

                if (box.Text == "")
                {
                    valid = false;

                    box.BackColor = Color.Red;

                }
            }

            if (!valid)
            {
                MessageBox.Show("Vänligen fyll i ett korrekt användarnamn och lösenord!");
                return;
            }
            MessageBox.Show("Du är nu inloggad.");


            foreach (TextBox box in txtBoxes)
            {
                box.Clear();
                box.BackColor = Color.White;
            }
        }
    }
}

﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnRegistreraHär_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ditt konto har registrerats.");
            txtSkapaAnvändarnamn.Clear();
            txtSkapaLösenord.Clear();
        }
    }
}

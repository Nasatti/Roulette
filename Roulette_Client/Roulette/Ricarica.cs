﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette
{
    public partial class Ricarica : Form
    {
        Client client;
        public Ricarica(Client c)
        {
            InitializeComponent();
            client = c;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            text_ricarica.Text = trackBar.Value.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            client.ricarica(text_ricarica.Text);
            this.Close();
        }

        private void text_ricarica_ValueChanged(object sender, EventArgs e)
        {
            if (float.Parse(text_ricarica.Text) <= 500)
                trackBar.Value = int.Parse(text_ricarica.Text);
            else
            {
                MessageBox.Show("Importo massimo permesso è di 500");
                text_ricarica.Text = "1";
            }
        }
    }
}

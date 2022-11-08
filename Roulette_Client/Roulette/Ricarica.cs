using System;
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

        private void text_ricarica_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(text_ricarica.Text) <= 100)
                trackBar.Value = int.Parse(text_ricarica.Text);
            else
            {
                MessageBox.Show("Importo massimo permesso è di 100");
                text_ricarica.Text = "1";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.ricarica(text_ricarica.Text);
            this.Close();
        }


    }
}

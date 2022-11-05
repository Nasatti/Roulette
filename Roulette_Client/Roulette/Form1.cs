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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel_fish1.BackColor = Color.Red;
            panel_fish5.BackColor = Color.Transparent;
            panel_fish10.BackColor = Color.Transparent;
            panel_fish25.BackColor = Color.Transparent;
            panel_fish50.BackColor = Color.Transparent;
            panel_fish100.BackColor = Color.Transparent;
        }

        private void fish5_Click(object sender, EventArgs e)
        {
            panel_fish5.BackColor = Color.Red;
            panel_fish1.BackColor = Color.Transparent;
            panel_fish10.BackColor = Color.Transparent;
            panel_fish25.BackColor = Color.Transparent;
            panel_fish50.BackColor = Color.Transparent;
            panel_fish100.BackColor = Color.Transparent;
        }

        private void fish10_Click(object sender, EventArgs e)
        {
            panel_fish10.BackColor = Color.Red;
            panel_fish1.BackColor = Color.Transparent;
            panel_fish5.BackColor = Color.Transparent;
            panel_fish25.BackColor = Color.Transparent;
            panel_fish50.BackColor = Color.Transparent;
            panel_fish100.BackColor = Color.Transparent;
        }

        private void fish25_Click(object sender, EventArgs e)
        {
            panel_fish25.BackColor = Color.Red;
            panel_fish1.BackColor = Color.Transparent;
            panel_fish5.BackColor = Color.Transparent;
            panel_fish10.BackColor = Color.Transparent;
            panel_fish50.BackColor = Color.Transparent;
            panel_fish100.BackColor = Color.Transparent;
        }

        private void fish50_Click(object sender, EventArgs e)
        {
            panel_fish50.BackColor = Color.Red;
            panel_fish1.BackColor = Color.Transparent;
            panel_fish5.BackColor = Color.Transparent;
            panel_fish10.BackColor = Color.Transparent;
            panel_fish25.BackColor = Color.Transparent;
            panel_fish100.BackColor = Color.Transparent;
        }

        private void fish100_Click(object sender, EventArgs e)
        {
            panel_fish100.BackColor = Color.Red;
            panel_fish1.BackColor = Color.Transparent;
            panel_fish5.BackColor = Color.Transparent;
            panel_fish10.BackColor = Color.Transparent;
            panel_fish25.BackColor = Color.Transparent;
            panel_fish50.BackColor = Color.Transparent;
        }
    }
}

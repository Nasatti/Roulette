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
        int nfish = 0;
        public Client()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            nfish = 0;
            panel_fish1.BackColor = Color.LimeGreen;
            panel_fish5.BackColor = Color.Transparent;
            panel_fish10.BackColor = Color.Transparent;
            panel_fish25.BackColor = Color.Transparent;
            panel_fish50.BackColor = Color.Transparent;
            panel_fish100.BackColor = Color.Transparent;
        }

        private void fish5_Click(object sender, EventArgs e)
        {
            nfish = 1;
            panel_fish5.BackColor = Color.LimeGreen;
            panel_fish1.BackColor = Color.Transparent;
            panel_fish10.BackColor = Color.Transparent;
            panel_fish25.BackColor = Color.Transparent;
            panel_fish50.BackColor = Color.Transparent;
            panel_fish100.BackColor = Color.Transparent;
        }

        private void fish10_Click(object sender, EventArgs e)
        {
            nfish = 2;
            panel_fish10.BackColor = Color.LimeGreen;
            panel_fish1.BackColor = Color.Transparent;
            panel_fish5.BackColor = Color.Transparent;
            panel_fish25.BackColor = Color.Transparent;
            panel_fish50.BackColor = Color.Transparent;
            panel_fish100.BackColor = Color.Transparent;
        }

        private void fish25_Click(object sender, EventArgs e)
        {
            nfish = 3;
            panel_fish25.BackColor = Color.LimeGreen;
            panel_fish1.BackColor = Color.Transparent;
            panel_fish5.BackColor = Color.Transparent;
            panel_fish10.BackColor = Color.Transparent;
            panel_fish50.BackColor = Color.Transparent;
            panel_fish100.BackColor = Color.Transparent;
        }

        private void fish50_Click(object sender, EventArgs e)
        {
            nfish = 4;
            panel_fish50.BackColor = Color.LimeGreen;
            panel_fish1.BackColor = Color.Transparent;
            panel_fish5.BackColor = Color.Transparent;
            panel_fish10.BackColor = Color.Transparent;
            panel_fish25.BackColor = Color.Transparent;
            panel_fish100.BackColor = Color.Transparent;
        }

        private void fish100_Click(object sender, EventArgs e)
        {
            nfish = 5;
            panel_fish100.BackColor = Color.LimeGreen;
            panel_fish1.BackColor = Color.Transparent;
            panel_fish5.BackColor = Color.Transparent;
            panel_fish10.BackColor = Color.Transparent;
            panel_fish25.BackColor = Color.Transparent;
            panel_fish50.BackColor = Color.Transparent;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (b3.Image == null)
            {
                b3.Image = fish.Images[nfish];
                b3.Text = "";
            }
            else
            {
                b3.Image = null;
                b3.Text = "3";
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (b0.Image == null)
            {
                b0.Image = fish.Images[nfish];
                b0.Text = "";
            }
            else
            {
                b0.Image = null;
                b0.Text = "0";
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }
    }
}

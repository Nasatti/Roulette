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
        private void Button_Fish(Button b, string s)
        {
            if (b.Image == null)
            {
                b.Image = fish.Images[nfish];
                b.Text = "";
            }
            else
            {
                b.Image = null;
                b.Text = s;
            }
        }
        private void Client_Load(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
        }
        private void b0_Click(object sender, EventArgs e)
        {
            Button_Fish(b0, "0");
        }
        private void b1_Click(object sender, EventArgs e)
        {
            Button_Fish(b1, "1");
        }
        private void b2_Click(object sender, EventArgs e)
        {
            Button_Fish(b2, "2");
        }
        private void b3_Click(object sender, EventArgs e)
        {
            Button_Fish(b3, "3");
        }
        private void b4_Click(object sender, EventArgs e)
        {
            Button_Fish(b4, "4");
        }
        private void b5_Click(object sender, EventArgs e)
        {
            Button_Fish(b5, "5");
        }
        private void b6_Click(object sender, EventArgs e)
        {
            Button_Fish(b6, "6");
        }
        private void b7_Click(object sender, EventArgs e)
        {
            Button_Fish(b7, "7");
        }
        private void b8_Click(object sender, EventArgs e)
        {
            Button_Fish(b8, "8");
        }
        private void b9_Click(object sender, EventArgs e)
        {
            Button_Fish(b9, "9");
        }
        private void b10_Click(object sender, EventArgs e)
        {
            Button_Fish(b10, "10");
        }
        private void b11_Click(object sender, EventArgs e)
        {
            Button_Fish(b11, "11");
        }
        private void b12_Click(object sender, EventArgs e)
        {
            Button_Fish(b12, "12");
        }
        private void b13_Click(object sender, EventArgs e)
        {
            Button_Fish(b13, "13");
        }
        private void b14_Click(object sender, EventArgs e)
        {
            Button_Fish(b14, "14");
        }
        private void b15_Click(object sender, EventArgs e)
        {
            Button_Fish(b15, "15");
        }
        private void b16_Click(object sender, EventArgs e)
        {
            Button_Fish(b16, "16");
        }
        private void b17_Click(object sender, EventArgs e)
        {
            Button_Fish(b17, "17");
        }
        private void b18_Click(object sender, EventArgs e)
        {
            Button_Fish(b18, "18");
        }
        private void b19_Click(object sender, EventArgs e)
        {
            Button_Fish(b19, "19");
        }
        private void b20_Click(object sender, EventArgs e)
        {
            Button_Fish(b20, "20");
        }
        private void b21_Click(object sender, EventArgs e)
        {
            Button_Fish(b21, "21");
        }
        private void b22_Click(object sender, EventArgs e)
        {
            Button_Fish(b22, "22");
        }
        private void b23_Click(object sender, EventArgs e)
        {
            Button_Fish(b23, "23");
        }
        private void b24_Click(object sender, EventArgs e)
        {
            Button_Fish(b24, "24");
        }
        private void b25_Click(object sender, EventArgs e)
        {
            Button_Fish(b25, "25");
        }
        private void b26_Click(object sender, EventArgs e)
        {
            Button_Fish(b26, "26");
        }
        private void b27_Click(object sender, EventArgs e)
        {
            Button_Fish(b27, "27");
        }
        private void b28_Click(object sender, EventArgs e)
        {
            Button_Fish(b28, "28");
        }
        private void b29_Click(object sender, EventArgs e)
        {
            Button_Fish(b29, "29");
        }
        private void b30_Click(object sender, EventArgs e)
        {
            Button_Fish(b30, "30");
        }
        private void b31_Click(object sender, EventArgs e)
        {
            Button_Fish(b31, "31");
        }
        private void b32_Click(object sender, EventArgs e)
        {
            Button_Fish(b32, "32");
        }
        private void b33_Click(object sender, EventArgs e)
        {
            Button_Fish(b33, "33");
        }
        private void b34_Click(object sender, EventArgs e)
        {
            Button_Fish(b34, "34");
        }
        private void b35_Click(object sender, EventArgs e)
        {
            Button_Fish(b35, "35");
        }
        private void b36_Click(object sender, EventArgs e)
        {
            Button_Fish(b36, "36");
        }
        private void b1st12_Click(object sender, EventArgs e)
        {
            Button_Fish(b1st12, "1st12");
        }
        private void b2nd12_Click(object sender, EventArgs e)
        {
            Button_Fish(b2nd12, "2nd12");
        }
        private void b3rd12_Click(object sender, EventArgs e)
        {
            Button_Fish(b3rd12, "3rt12");
        }
        private void b1to18_Click(object sender, EventArgs e)
        {
            Button_Fish(b1to18, "1to18");
        }
        private void beven_Click(object sender, EventArgs e)
        {
            Button_Fish(beven, "EVEN");
        }
        private void bred_Click(object sender, EventArgs e)
        {
            Button_Fish(bred, "RED");
        }
        private void bblack_Click(object sender, EventArgs e)
        {
            Button_Fish(bblack, "BLACK");
        }
        private void bodd_Click(object sender, EventArgs e)
        {
            Button_Fish(bodd, "ODD");
        }
        private void b19to36_Click(object sender, EventArgs e)
        {
            Button_Fish(b19to36, "19to36");
        }
        private void bfila1_Click(object sender, EventArgs e)
        {
            Button_Fish(bfila1, "2to1");
        }
        private void bfila2_Click(object sender, EventArgs e)
        {
            Button_Fish(bfila2, "2to1");
        }
        private void bfila3_Click(object sender, EventArgs e)
        {
            Button_Fish(bfila3, "2to1");
        }
    }
}

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

        private void b1_Click(object sender, EventArgs e)
        {
            if (b1.Image == null)
            {
                b1.Image = fish.Images[nfish];
                b1.Text = "";
            }
            else
            {
                b1.Image = null;
                b1.Text = "1";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (b2.Image == null)
            {
                b2.Image = fish.Images[nfish];
                b2.Text = "";
            }
            else
            {
                b2.Image = null;
                b2.Text = "2";
            }
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

        private void b4_Click(object sender, EventArgs e)
        {
            if (b4.Image == null)
            {
                b4.Image = fish.Images[nfish];
                b4.Text = "";
            }
            else
            {
                b4.Image = null;
                b4.Text = "4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (b5.Image == null)
            {
                b5.Image = fish.Images[nfish];
                b5.Text = "";
            }
            else
            {
                b5.Image = null;
                b5.Text = "5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (b6.Image == null)
            {
                b6.Image = fish.Images[nfish];
                b6.Text = "";
            }
            else
            {
                b6.Image = null;
                b6.Text = "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (b7.Image == null)
            {
                b7.Image = fish.Images[nfish];
                b7.Text = "";
            }
            else
            {
                b7.Image = null;
                b7.Text = "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (b8.Image == null)
            {
                b8.Image = fish.Images[nfish];
                b8.Text = "";
            }
            else
            {
                b8.Image = null;
                b8.Text = "8";
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (b9.Image == null)
            {
                b9.Image = fish.Images[nfish];
                b9.Text = "";
            }
            else
            {
                b9.Image = null;
                b9.Text = "9";
            }
        }

        private void b10_Click(object sender, EventArgs e)
        {
            if (b10.Image == null)
            {
                b10.Image = fish.Images[nfish];
                b10.Text = "";
            }
            else
            {
                b10.Image = null;
                b10.Text = "10";
            }
        }

        private void b11_Click(object sender, EventArgs e)
        {
            if (b11.Image == null)
            {
                b11.Image = fish.Images[nfish];
                b11.Text = "";
            }
            else
            {
                b11.Image = null;
                b11.Text = "11";
            }
        }

        private void b12_Click(object sender, EventArgs e)
        {
            if (b12.Image == null)
            {
                b12.Image = fish.Images[nfish];
                b12.Text = "";
            }
            else
            {
                b12.Image = null;
                b12.Text = "12";
            }
        }

        private void b13_Click(object sender, EventArgs e)
        {
            if (b13.Image == null)
            {
                b13.Image = fish.Images[nfish];
                b13.Text = "";
            }
            else
            {
                b13.Image = null;
                b13.Text = "13";
            }
        }

        private void b14_Click(object sender, EventArgs e)
        {
            if (b14.Image == null)
            {
                b14.Image = fish.Images[nfish];
                b14.Text = "";
            }
            else
            {
                b14.Image = null;
                b14.Text = "14";
            }
        }

        private void b15_Click(object sender, EventArgs e)
        {
            if (b15.Image == null)
            {
                b15.Image = fish.Images[nfish];
                b15.Text = "";
            }
            else
            {
                b15.Image = null;
                b15.Text = "15";
            }
        }

        private void b16_Click(object sender, EventArgs e)
        {
            if (b16.Image == null)
            {
                b16.Image = fish.Images[nfish];
                b16.Text = "";
            }
            else
            {
                b16.Image = null;
                b16.Text = "16";
            }
        }

        private void b17_Click(object sender, EventArgs e)
        {
            if (b17.Image == null)
            {
                b17.Image = fish.Images[nfish];
                b17.Text = "";
            }
            else
            {
                b17.Image = null;
                b17.Text = "17";
            }
        }

        private void b18_Click(object sender, EventArgs e)
        {
            if (b18.Image == null)
            {
                b18.Image = fish.Images[nfish];
                b18.Text = "";
            }
            else
            {
                b18.Image = null;
                b18.Text = "18";
            }
        }

        private void b19_Click(object sender, EventArgs e)
        {
            if (b19.Image == null)
            {
                b19.Image = fish.Images[nfish];
                b19.Text = "";
            }
            else
            {
                b19.Image = null;
                b19.Text = "19";
            }
        }

        private void b20_Click(object sender, EventArgs e)
        {
            if (b20.Image == null)
            {
                b20.Image = fish.Images[nfish];
                b20.Text = "";
            }
            else
            {
                b20.Image = null;
                b20.Text = "20";
            }
        }

        private void b21_Click(object sender, EventArgs e)
        {
            if (b21.Image == null)
            {
                b21.Image = fish.Images[nfish];
                b21.Text = "";
            }
            else
            {
                b21.Image = null;
                b21.Text = "21";
            }
        }

        private void b22_Click(object sender, EventArgs e)
        {
            if (b22.Image == null)
            {
                b22.Image = fish.Images[nfish];
                b22.Text = "";
            }
            else
            {
                b22.Image = null;
                b22.Text = "22";
            }
        }

        private void b23_Click(object sender, EventArgs e)
        {
            if (b23.Image == null)
            {
                b23.Image = fish.Images[nfish];
                b23.Text = "";
            }
            else
            {
                b23.Image = null;
                b23.Text = "23";
            }
        }

        private void b24_Click(object sender, EventArgs e)
        {
            if (b24.Image == null)
            {
                b24.Image = fish.Images[nfish];
                b24.Text = "";
            }
            else
            {
                b24.Image = null;
                b24.Text = "24";
            }
        }

        private void b25_Click(object sender, EventArgs e)
        {
            if (b25.Image == null)
            {
                b25.Image = fish.Images[nfish];
                b25.Text = "";
            }
            else
            {
                b25.Image = null;
                b25.Text = "25";
            }
        }

        private void b26_Click(object sender, EventArgs e)
        {
            if (b26.Image == null)
            {
                b26.Image = fish.Images[nfish];
                b26.Text = "";
            }
            else
            {
                b26.Image = null;
                b26.Text = "26";
            }
        }

        private void b27_Click(object sender, EventArgs e)
        {
            if (b27.Image == null)
            {
                b27.Image = fish.Images[nfish];
                b27.Text = "";
            }
            else
            {
                b27.Image = null;
                b27.Text = "27";
            }
        }

        private void b28_Click(object sender, EventArgs e)
        {
            if (b28.Image == null)
            {
                b28.Image = fish.Images[nfish];
                b28.Text = "";
            }
            else
            {
                b28.Image = null;
                b28.Text = "28";
            }
        }

        private void b29_Click(object sender, EventArgs e)
        {
            if (b29.Image == null)
            {
                b29.Image = fish.Images[nfish];
                b29.Text = "";
            }
            else
            {
                b29.Image = null;
                b29.Text = "29";
            }
        }

        private void b30_Click(object sender, EventArgs e)
        {
            if (b30.Image == null)
            {
                b30.Image = fish.Images[nfish];
                b30.Text = "";
            }
            else
            {
                b30.Image = null;
                b30.Text = "30";
            }
        }

        private void b31_Click(object sender, EventArgs e)
        {
            if (b31.Image == null)
            {
                b31.Image = fish.Images[nfish];
                b31.Text = "";
            }
            else
            {
                b31.Image = null;
                b31.Text = "31";
            }
        }

        private void b32_Click(object sender, EventArgs e)
        {
            if (b32.Image == null)
            {
                b32.Image = fish.Images[nfish];
                b32.Text = "";
            }
            else
            {
                b32.Image = null;
                b32.Text = "32";
            }
        }

        private void b33_Click(object sender, EventArgs e)
        {
            if (b33.Image == null)
            {
                b33.Image = fish.Images[nfish];
                b33.Text = "";
            }
            else
            {
                b33.Image = null;
                b33.Text = "33";
            }
        }

        private void b34_Click(object sender, EventArgs e)
        {
            if (b34.Image == null)
            {
                b34.Image = fish.Images[nfish];
                b34.Text = "";
            }
            else
            {
                b34.Image = null;
                b34.Text = "34";
            }
        }

        private void b35_Click(object sender, EventArgs e)
        {
            if (b35.Image == null)
            {
                b35.Image = fish.Images[nfish];
                b35.Text = "";
            }
            else
            {
                b35.Image = null;
                b35.Text = "35";
            }
        }

        private void b36_Click(object sender, EventArgs e)
        {
            if (b36.Image == null)
            {
                b36.Image = fish.Images[nfish];
                b36.Text = "";
            }
            else
            {
                b36.Image = null;
                b36.Text = "36";
            }
        }

        private void b1st12_Click(object sender, EventArgs e)
        {
            if (b1st12.Image == null)
            {
                b1st12.Image = fish.Images[nfish];
                b1st12.Text = "";
            }
            else
            {
                b1st12.Image = null;
                b1st12.Text = "1st12";
            }
        }

        private void b2nd12_Click(object sender, EventArgs e)
        {
            if (b2nd12.Image == null)
            {
                b2nd12.Image = fish.Images[nfish];
                b2nd12.Text = "";
            }
            else
            {
                b2nd12.Image = null;
                b2nd12.Text = "1st12";
            }
        }

        private void b3rd12_Click(object sender, EventArgs e)
        {
            if (b3rd12.Image == null)
            {
                b3rd12.Image = fish.Images[nfish];
                b3rd12.Text = "";
            }
            else
            {
                b3rd12.Image = null;
                b3rd12.Text = "1st12";
            }
        }

        private void b1to18_Click(object sender, EventArgs e)
        {
            if (b1to18.Image == null)
            {
                b1to18.Image = fish.Images[nfish];
                b1to18.Text = "";
            }
            else
            {
                b1to18.Image = null;
                b1to18.Text = "1st12";
            }
        }

        private void beven_Click(object sender, EventArgs e)
        {
            if (beven.Image == null)
            {
                beven.Image = fish.Images[nfish];
                beven.Text = "";
            }
            else
            {
                beven.Image = null;
                beven.Text = "1st12";
            }
        }

        private void bred_Click(object sender, EventArgs e)
        {
            if (bred.Image == null)
            {
                bred.Image = fish.Images[nfish];
                bred.Text = "";
            }
            else
            {
                bred.Image = null;
                bred.Text = "1st12";
            }
        }

        private void bblack_Click(object sender, EventArgs e)
        {
            if (bblack.Image == null)
            {
                bblack.Image = fish.Images[nfish];
                bblack.Text = "";
            }
            else
            {
                bblack.Image = null;
                bblack.Text = "1st12";
            }
        }

        private void bodd_Click(object sender, EventArgs e)
        {
            if (bodd.Image == null)
            {
                bodd.Image = fish.Images[nfish];
                bodd.Text = "";
            }
            else
            {
                bodd.Image = null;
                bodd.Text = "1st12";
            }
        }

        private void b19to36_Click(object sender, EventArgs e)
        {
            if (b19to36.Image == null)
            {
                b19to36.Image = fish.Images[nfish];
                b19to36.Text = "";
            }
            else
            {
                b19to36.Image = null;
                b19to36.Text = "1st12";
            }
        }

        private void bfila1_Click(object sender, EventArgs e)
        {
            if (bfila1.Image == null)
            {
                bfila1.Image = fish.Images[nfish];
                bfila1.Text = "";
            }
            else
            {
                bfila1.Image = null;
                bfila1.Text = "1st12";
            }
        }

        private void bfila2_Click(object sender, EventArgs e)
        {
            if (bfila2.Image == null)
            {
                bfila2.Image = fish.Images[nfish];
                bfila2.Text = "";
            }
            else//h2S
            {
                bfila2.Image = null;
                bfila2.Text = "1st12";
            }
        }
    }
}

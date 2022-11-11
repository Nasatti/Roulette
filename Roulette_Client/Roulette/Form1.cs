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
        int f;
        Button[] button;
        public Client()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (controllo(1))
            {
                f = 1;
                nfish = 0;
                panel_fish1.BackColor = Color.LimeGreen;
                panel_fish5.BackColor = Color.Transparent;
                panel_fish10.BackColor = Color.Transparent;
                panel_fish25.BackColor = Color.Transparent;
                panel_fish50.BackColor = Color.Transparent;
                panel_fish100.BackColor = Color.Transparent;
            }
            else
                MessageBox.Show("Conto insufficiente");
        }
        private void fish5_Click(object sender, EventArgs e)
        {
            if (controllo(5))
            {
                f = 5;
                nfish = 1;
                panel_fish5.BackColor = Color.LimeGreen;
                panel_fish1.BackColor = Color.Transparent;
                panel_fish10.BackColor = Color.Transparent;
                panel_fish25.BackColor = Color.Transparent;
                panel_fish50.BackColor = Color.Transparent;
                panel_fish100.BackColor = Color.Transparent;
            }
            else
                MessageBox.Show("Conto insufficiente");
        }
        private void fish10_Click(object sender, EventArgs e)
        {
            if (controllo(10))
            {
                f = 10;
                nfish = 2;
                panel_fish10.BackColor = Color.LimeGreen;
                panel_fish1.BackColor = Color.Transparent;
                panel_fish5.BackColor = Color.Transparent;
                panel_fish25.BackColor = Color.Transparent;
                panel_fish50.BackColor = Color.Transparent;
                panel_fish100.BackColor = Color.Transparent;
            }
            else
                MessageBox.Show("Conto insufficiente");
        }
        private void fish25_Click(object sender, EventArgs e)
        {
            if (controllo(25))
            {
                f = 25;
                nfish = 3;
                panel_fish25.BackColor = Color.LimeGreen;
                panel_fish1.BackColor = Color.Transparent;
                panel_fish5.BackColor = Color.Transparent;
                panel_fish10.BackColor = Color.Transparent;
                panel_fish50.BackColor = Color.Transparent;
                panel_fish100.BackColor = Color.Transparent;
            }
            else
                MessageBox.Show("Conto insufficiente");
        }
        private void fish50_Click(object sender, EventArgs e)
        {
            if (controllo(50))
            {
                f = 50;
                nfish = 4;
                panel_fish50.BackColor = Color.LimeGreen;
                panel_fish1.BackColor = Color.Transparent;
                panel_fish5.BackColor = Color.Transparent;
                panel_fish10.BackColor = Color.Transparent;
                panel_fish25.BackColor = Color.Transparent;
                panel_fish100.BackColor = Color.Transparent;
            }
            else
                MessageBox.Show("Conto insufficiente");
        }
        private void fish100_Click(object sender, EventArgs e)
        {
            if (controllo(100))
            {
                f = 100;
                nfish = 5;
                panel_fish100.BackColor = Color.LimeGreen;
                panel_fish1.BackColor = Color.Transparent;
                panel_fish5.BackColor = Color.Transparent;
                panel_fish10.BackColor = Color.Transparent;
                panel_fish25.BackColor = Color.Transparent;
                panel_fish50.BackColor = Color.Transparent;
            }
            else
                MessageBox.Show("Conto insufficiente");
        }
        private bool controllo(int num)
        {
            try
            {
                string[] s = label_ricarica.Text.Split(',');
                int n = int.Parse(s[0]);
                if (n >= num)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        private void Button_Fish(Button b, string s, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            switch (me.Button)
            {
                case MouseButtons.Left:
                    string[] str;
                    int n;
                    if (b.Image == null)
                    {
                        str = label_ricarica.Text.Split(',');
                        n = int.Parse(str[0]);
                        if (n >= f)
                        {
                            b.Image = fish.Images[nfish];
                            b.Text = "";
                            n -= f;
                            label_ricarica.Text = n.ToString() + ",00€";
                        }
                        else
                            MessageBox.Show("Conto insufficiente");
                    }
                    break;
                case MouseButtons.Right:
                    b.Image = null;
                    b.Text = s;
                    break;
            }
            

        }
        private void Client_Load(object sender, EventArgs e)
        {
            nfish = 0;
            f = 1;
        }
        public void ricarica(string s)
        {
            string[] ss = label_ricarica.Text.Split(',');
            int n1 = int.Parse(ss[0]);
            int n2 = int.Parse(s);
            int r = n1 + n2;
            label_ricarica.Text = r.ToString() + ",00€";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ricarica r = new Ricarica(this);
            r.Show();
        }


        private void b0_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b0, "0", e);
        }

        private void b1_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b1, "1", e);
        }

        private void b2_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b2, "2", e);
        }

        private void b3_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b3, "3", e);
        }

        private void b4_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b4, "4", e);
        }

        private void b5_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b5, "5", e);
        }

        private void b6_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b6, "6", e);
        }

        private void b7_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b7, "7", e);
        }

        private void b8_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b8, "8", e);
        }

        private void b9_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b9, "9", e);
        }

        private void b10_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b10, "10", e);
        }

        private void b11_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b11, "11", e);
        }

        private void b12_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b12, "12", e);
        }

        private void b13_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b13, "13", e);
        }

        private void b14_Click(object sender, EventArgs e)
        {
            Button_Fish(b14, "14", e);
        }

        private void b15_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b15, "15", e);
        }

        private void b16_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b16, "16", e);
        }

        private void b17_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b17, "17", e);
        }

        private void b18_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b18, "18", e);
        }

        private void b19_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b19, "19", e);
        }

        private void b20_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b20, "20", e);
        }

        private void b21_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b21, "21", e);
        }

        private void b22_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b22, "22", e);
        }

        private void b23_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b23, "23", e);
        }

        private void b24_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b24, "24", e);
        }

        private void b25_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b25, "25", e);
        }

        private void b26_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b26, "26", e);
        }

        private void b27_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b27, "27", e);
        }

        private void b28_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b28, "28", e);
        }

        private void b29_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b29, "29", e);
        }

        private void b30_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b30, "30", e);
        }
    }
}
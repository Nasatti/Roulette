using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace Roulette_server
{


    public partial class Server : Form
    {
        Image img;
        Random r = new Random();
        float angle;
        int i = 0;
        Roulette roulette = new Roulette();
        Bitmap bmp;
        public Server()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        private void timer_palla_Tick(object sender, EventArgs e)
        {
            angle = angle % 359.973f;
            angle += 9.729f;
            Invalidate();

            i++;
            Random r = new Random();
            if (i >= r.Next(30,50))
            {
                if (timer_palla.Interval <= r.Next(100, 200))
                {
                    timer_palla.Interval += r.Next(0, 5);
                }
                else if (timer_palla.Interval <= r.Next(500, 700))
                {
                    timer_palla.Interval += r.Next(30, 70);
                }
                else
                {
                    timer_palla.Enabled = false;
                    timer_avvio.Enabled = true;
                    int n = (int)angleToNumber(angle);
                    if (roulette.number[n].color == "green")
                    {
                        p_number.Image = color.Images[2];
                        num.BackColor = Color.LimeGreen;
                    }
                    else if (roulette.number[n].color == "red")
                    {
                        p_number.Image = color.Images[0];
                        num.BackColor = Color.Red;
                    }
                    else if (roulette.number[n].color == "black")
                    {
                        p_number.Image = color.Images[1];
                        num.BackColor = Color.Black;
                    }
                    num.Text = roulette.number[n].n.ToString();
                    p_number.Visible = true;
                    num.Visible = true;
                }
            }
        }


        private void Server_Load(object sender, EventArgs e)
        {
            img = Image.FromFile(@"../../img/palla.png");
            int n = r.Next(0, 36);
            angle = n * 9.729f;
            bmp = new Bitmap(img.Width, img.Height);
        }


        private void Server_Paint(object sender, PaintEventArgs e)
        { 
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Transparent);
            g.TranslateTransform(bmp.Width/2, bmp.Height/2);
            g.RotateTransform(angle);
            g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
            g.InterpolationMode=InterpolationMode.HighQualityBicubic;

            g.DrawImage(img, 0, 0);
            e.Graphics.TranslateTransform(this.Width / 2, this.Width / 2);
            e.Graphics.DrawImage(bmp, -bmp.Width / 2 - 9, -bmp.Height / 2);
        }

        private void Server_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void timer_velocità_Tick(object sender, EventArgs e)
        {
            int n = r.Next(0, 37);
            angle = n * 9.729f;
            timer_palla.Interval = 50;
            timer_palla.Enabled = true;
            timer_avvio.Enabled = false;
            p_number.Visible = false;
            num.Visible = false;
        }
        private double angleToNumber(float angle)
        {
            double a = angle;
            double n;
            n = a / 9.729;
            return Math.Truncate(n);
        }
    }
}

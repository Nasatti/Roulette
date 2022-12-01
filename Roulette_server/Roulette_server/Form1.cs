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
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Roulette_server
{

    //odd dispari   even pari
    public partial class Server : Form
    {
        Image img;
        Random r = new Random();
        float angle;
        int i = 0;
        Roulette roulette = new Roulette();
        Bitmap bmp;
        List<string> risultato = new List<string>();
        Thread t;
        bool stato = false; bool inizio = true; bool avvia = true;
        int count = 20;
        int[] n = new int[2] { 0, 0 };
        public static string data = null;
        public Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void timer_palla_Tick(object sender, EventArgs e)
        {
            angle = angle % 359.973f;
            angle += 9.729f;

            Invalidate();

            if (!inizio)
            {
                if (roulette.number[n[1]].color == "green")
                {
                    panel_nestratto.BackColor = Color.LimeGreen;
                }
                else if (roulette.number[n[1]].color == "red")
                {
                    panel_nestratto.BackColor = Color.Red;
                }
                else if (roulette.number[n[1]].color == "black")
                {
                    panel_nestratto.BackColor = Color.Black;
                }
                label_nestratto.Visible = true;
                panel_nestratto.Visible = true;
                label_n.Text = roulette.number[n[1]].n.ToString();
            }

            i++;
            Random r = new Random();
            if (i >= r.Next(30, 50))
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
                    count = 20;
                    label_timer.Text = count.ToString() + " secondi";
                    label_t.Visible = true;
                    label_timer.Visible = true;
                    n[0] = (int)angleToNumber(angle);
                    n[1] = n[0];
                    if (n[0] == 37)
                        n[0] = 0;
                    if (roulette.number[n[0]].color == "green")
                    {
                        p_number.Image = color.Images[2];
                        num.BackColor = Color.LimeGreen;
                    }
                    else if (roulette.number[n[0]].color == "red")
                    {
                        p_number.Image = color.Images[0];
                        num.BackColor = Color.Red;
                    }
                    else if (roulette.number[n[0]].color == "black")
                    {
                        p_number.Image = color.Images[1];
                        num.BackColor = Color.Black;
                    }
                    num.Text = roulette.number[n[0]].n.ToString();
                    p_number.Visible = true;
                    num.Visible = true;
                    risultato = estrazione(roulette.number[n[0]].n, n[0]);
                    stato = true;
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
            g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

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
            if (count >= 0)
            {
                label_timer.Text = count.ToString() + " secondi";
            }
            else
            {
                inizio = false;
                int rr = r.Next(0, 37);
                angle = rr * 9.729f;
                timer_palla.Interval = 50;
                timer_palla.Enabled = true;
                stato = false;
                timer_avvio.Enabled = false;
                p_number.Visible = false;
                num.Visible = false;
                label_timer.Visible = false;
                label_t.Visible = false;
            }
            count--;
        }
        private double angleToNumber(float angle)
        {
            double a = angle;
            double n;
            n = a / 9.729;
            return Math.Truncate(n);
        }

        public List<string> estrazione(int n, int a)
        {
            List<string> result = new List<string>();
            result.Add(n.ToString());
            //nella metà
            if (n <= 18)
                result.Add("1to18");
            else
                result.Add("19to36");

            //nei 12
            if (n <= 12)
                result.Add("1st12");
            else if (n <= 24)
                result.Add("2nd12");
            else
                result.Add("3rd12");

            //colore
            result.Add(roulette.number[a].color);

            //pari e dispari
            if (n % 2 == 0)
                result.Add("even");
            else
                result.Add("odd");

            //fila
            if (n % 3 == 0)
                result.Add("fila3");
            else if ((n + 1) % 3 == 0)
                result.Add("fila2");
            else if ((n + 2) % 3 == 0)
                result.Add("fila1");

            return result;
        }

        public void StartServer()
        {
            IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);
            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
                while (true)
                {
                    Socket handler = listener.Accept();
                    ClientManager clientThread = new ClientManager(handler, this);
                    Thread t = new Thread(new ThreadStart(clientThread.doClient));
                    t.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void btn_avvia_Click(object sender, EventArgs e)
        {
            if (avvia)
            {
                t = new Thread(new ThreadStart(StartServer));
                t.Start();
                timer_palla.Enabled = true;
                avvia = false;
                btn_avvia.Text = "SPEGNI";
            }
            else
            {
                timer_palla.Interval = 50;
                timer_avvio.Interval = 1000;
                timer_palla.Enabled = false;
                timer_avvio.Enabled = false;
                p_number.Visible = false;
                num.Visible = false;
                label_t.Visible = false;
                label_timer.Visible = false;
                label_nestratto.Visible = false;
                panel_nestratto.Visible = false;
                btn_avvia.Text = "AVVIA";
                avvia = true;
            }
        }
        public List<string> Risultato()
        {
            return risultato;
        }
        public bool Stato()
        {
            return stato;
        }
        public bool AvvioSpegni()
        {
            return avvia;
        }
    }
}

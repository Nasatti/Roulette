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
        string[] risultato = new string[5];
        Thread t;
        bool stato = false;
        IPAddress ipAddress;
        IPEndPoint localEndPoint; 
        Socket listener;

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
                    stato = true;


                    



                    timer_palla.Enabled = false;
                    timer_avvio.Enabled = true;
                    int n = (int)angleToNumber(angle);
                    if (n == 37)
                        n = 0;
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
                    risultato = estrazione(roulette.number[n].n, n);

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
            int n = r.Next(0, 37);
            angle = n * 9.729f;
            timer_palla.Interval = 50;
            timer_palla.Enabled = true;
            stato = false;
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

        public string[] estrazione(int n, int a)
        {
            string[] result = new string[6];
            result[0] = n.ToString();
            //nella metà
            if (n <= 18)
                result[1] = "1to18";
            else
                result[1] = "19to36";

            //nei 12
            if (n <= 12)
            if (n <= 12)
                result[2] = "1st12";
            else if (n <= 24)
                result[2] = "2nd12";
            else
                result[2] = "3rd12";

            //colore
            result[3] = roulette.number[a].color;

            //pari e dispari
            if (n % 2 == 0)
                result[4] = "even";
            else
                result[4] = "odd";

            //fila
            if (n % 3 == 0)
                result[5] = "fila3";
            else if ((n + 1) % 3 == 0)
                result[5] = "fila2";
            else if ((n + 2) % 3 == 0)
                result[5] = "fila1";

            return result;
        }

        public void StartServer()
        {
            // Establish the local endpoint for the socket.  
            // Dns.GetHostName returns the name of the   
            // host running the application.  
            ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
            localEndPoint = new IPEndPoint(ipAddress, 5000);

            // Create a TCP/IP socket.  
            listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);


            // Bind the socket to the local endpoint and   
            // listen for incoming connections.  
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Start listening for connections.  

                //while (true)
                //{

                // Program is suspended while waiting for an incoming connection.
                int i = 0;
                Socket handler = listener.Accept();
                while (true)
                {
                    
                    if (stato)
                    {
                        byte[] msg = Encoding.ASCII.GetBytes("Punta$");
                        handler.Send(msg);
                        ClientManager clientThread = new ClientManager(handler, this);
                        Thread t = new Thread(new ThreadStart(clientThread.doClient));
                        t.Start();
                        break;
                    }
                    else if(i == 0)
                    {
                        byte[] msg = Encoding.ASCII.GetBytes("Wait$");
                        handler.Send(msg);
                        i++;
                    }
                    
                }
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void btn_avvia_Click(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(StartServer));
            t.Start();
            btn_avvia.Visible = false;
            timer_palla.Enabled = true;
        }
        public string[] Risultato()
        {
            return risultato;
        }
    }
}

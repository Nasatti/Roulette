using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics.SymbolStore;

namespace Roulette
{
    public partial class Client : Form
    {
        int nfish = 0;int n_ricarica = 0;
        int f, vincita = 0;
        Dictionary<string, int> puntata = new Dictionary<string, int>();
        byte[] bytes = new byte[1024];
        IPAddress ipAddress;
        IPEndPoint remoteEP;
        Socket sender;
        bool esci = true; bool inizio = true; bool start = false;
        List<Button> button_press = new List<Button>();
        List<string> number_press = new List<string>();
        string[] str;
        public Client()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.DoubleBuffered = true;
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
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        private void Button_Fish(Button b, string s, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            switch (me.Button)
            {
                case MouseButtons.Left:
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
                            puntata.Add(s, f);
                            button_press.Add(b);
                            number_press.Add(s);
                        }
                        else
                            MessageBox.Show("Conto insufficiente");
                    }
                    break;
                case MouseButtons.Right:
                    if (b.Image != null)
                    {
                        b.Image = null;
                        b.Text = s;
                        str = label_ricarica.Text.Split(',');
                        n = int.Parse(str[0]);
                        n += puntata[s];
                        label_ricarica.Text = n.ToString() + ",00€";
                        puntata.Remove(s);
                    }
                    else
                    {
                        MessageBox.Show("Punta qualcosa");
                    }
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
            str = label_ricarica.Text.Split(',');
            int n1 = int.Parse(str[0]);
            int n2 = int.Parse(s);
            int r = n1 + n2;
            label_ricarica.Text = r.ToString() + ",00€";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (start)
            {
                if (n_ricarica == 0)
                {
                    Ricarica r = new Ricarica(this, n_ricarica);
                    r.Show();
                }
            }
        }
        public void NRicp()
        {
            n_ricarica++;
        }
        public void NRicm()
        {
            n_ricarica--;

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
        private void b14_MouseDown(object sender, MouseEventArgs e)
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
        private void b31_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b31, "31", e);
        }
        private void b32_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b32, "32", e);
        }
        private void b33_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b33, "33", e);
        }
        private void b34_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b34, "34", e);
        }
        private void b35_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b35, "35", e);
        }
        private void b36_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b36, "36", e);
        }
        private void b1st12_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b1st12, "1st12", e);
        }
        private void b2nd12_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b2nd12, "2nd12", e);
        }
        private void b3rd12_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b3rd12, "3rd12", e);
        }
        private void b1to18_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b1to18, "1to18", e);
        }
        private void beven_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(beven, "even", e);
        }
        private void bred_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(bred, "red", e);
        }
        private void bblack_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(bblack, "black", e);
        }
        private void bodd_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(bodd, "odd", e);
        }
        private void b19to36_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(b19to36, "19to36", e);
        }
        private void bfila1_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(bfila1, "fila1", e);
        }
        private void bfila2_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(bfila2, "fila2", e);
        }
        private void bfila3_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Fish(bfila3, "fila3", e);
        }
        private void button3_Click(object senderr, EventArgs ee)
        {
            p_inizio.Visible = false;
            p_gioco.Visible = true;
            Thread t = new Thread(new ThreadStart(Gioca_Wait));
            t.Start();
        }

        private void btn_esci_Click(object senderr, EventArgs e)
        {
            esci = true;
            if (start)
            {
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
                this.Close();
            }
        }
        public void Gioca_Wait()
        {
            try
            {
                ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                remoteEP = new IPEndPoint(ipAddress, 5000);
                sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);
                sender.Connect(remoteEP);
                start = true;
                inizio = false;
                string data = "";
                bool verifica = true;
                string data_temp = "";
                int bytesRec;
                while (esci && data != "End$")
                {
                    data = "";
                    while (data.IndexOf("$") == -1)
                    {
                        bytesRec = sender.Receive(bytes);
                        data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    }
                    if (data != "End$")
                    {
                        if (data != data_temp)
                        {
                            data_temp = data;
                            verifica = true;
                        }
                        if (data == "Giro Ruota$" && verifica)
                        {
                            panel_tavolo.Enabled = false;
                            stato.Text = "Aspetta";
                            Invia();
                            verifica = false;
                            l_vincita.Visible = false;
                        }
                        else if (data == "Fermo$" && verifica)
                        {
                            stato.Text = "Punta";
                            data = Ricevi();
                            if (data != "End$")
                            {
                                vincita = int.Parse(data);
                                verifica = false;

                                    string[] str = label_ricarica.Text.Split(',');
                                    int n = int.Parse(str[0]);
                                    label_ricarica.Text = (n + vincita).ToString() + ",00€";
                                if (vincita != 0)
                                {
                                    l_vincita.Visible = true;
                                    l_vincita.Text = "HAI VINTO " + vincita.ToString() + ",00€";
                                }
                                Application.DoEvents();
                                pulizia();
                                panel_tavolo.Enabled = true;
                            }
                        }
                    }
                }
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
                DialogResult d = MessageBox.Show("Server spento\nAttendi che riparta", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    p_inizio.Visible = true;
                    p_gioco.Visible = false;
                    pulizia();
                }
                else
                {
                    esci = true;
                    byte[] msg = Encoding.ASCII.GetBytes("End$");
                    this.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                if (inizio)
                {
                    DialogResult d = MessageBox.Show("Qualcosa è andato storto\nriprova l'accesso", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        p_inizio.Visible = true;
                        p_gioco.Visible = false;
                    }
                    else
                    {
                        esci = true;
                        byte[] msg = Encoding.ASCII.GetBytes("End$");
                        this.Close();
                    }
                }
                pulizia();
                label_ricarica.Text = "100,00€";
            }
        }
        public void Invia()
        {
            string jsonString = JsonSerializer.Serialize(puntata);
            byte[] msg = Encoding.ASCII.GetBytes(jsonString);
            sender.Send(msg);
        }
        public string Ricevi()
        {
            int bytesRec = sender.Receive(bytes);
            return Encoding.ASCII.GetString(bytes, 0, bytesRec);
        }
        public void pulizia()
        {
            int i = 0;
            foreach(Button b in button_press)
            {
                b.Text = number_press[i];
                b.Image = null;
                i++;
            }
            puntata.Clear();
        }
    }
}
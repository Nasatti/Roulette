using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;

namespace Roulette_server
{
    public class ClientManager
    {
        Socket clientSocket;
        byte[] bytes = new byte[1024];
        string data = "";
        Server s;
        Roulette roulette = new Roulette();

        public ClientManager(Socket clientSocket, Server s)
        {
            this.clientSocket = clientSocket;
            this.s = s;
        }

        public void doClient()
        {
            Dictionary<string, int> puntata = new Dictionary<string, int>();
            int vincita = 0;
            List<string> n_estratto = new List<string>();
            bool verifica1 = true;
            bool verifica2 = true;
            bool stato;
            try
            {
                byte[] msg;
                while (data != "End$")
                {
                    stato = s.Stato();
                    if (stato && verifica2)//fermo
                    {
                        msg = Encoding.ASCII.GetBytes("Fermo$");
                        clientSocket.Send(msg);

                        List<string> r = new List<string>();
                        List<int> q = new List<int>();
                        foreach (KeyValuePair<string, int> pair in puntata)
                        {
                            string check1 = pair.ToString();
                            string[] check2 = check1.Split(',');
                            r.Add(check2[0].Substring(1));
                            q.Add(int.Parse(check2[1].Substring(0, check2[1].Length - 1)));
                        }
                        vincita = roulette.Vincita(n_estratto, r, q);
                        msg = Encoding.ASCII.GetBytes(vincita.ToString());
                        Thread.Sleep(100);
                        clientSocket.Send(msg);
                        verifica1 = true;
                        verifica2 = false;
                    }
                    else if (!stato && verifica1)//giro ruota
                    {
                        msg = Encoding.ASCII.GetBytes("Giro Ruota$");
                        clientSocket.Send(msg);

                        int bytesRec = clientSocket.Receive(bytes);
                        data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data != "{}")
                            puntata = JsonSerializer.Deserialize<Dictionary<string, int>>(data);
                        n_estratto = s.Risultato();
                        verifica1 = false;
                        verifica2 = true;
                    }

                }
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

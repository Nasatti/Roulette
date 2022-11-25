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
            while (data != "End")
            {
                // An incoming connection needs to be processed.  
                //data = "";
                byte[] msg = Encoding.ASCII.GetBytes("controllo risultati$");
                clientSocket.Send(msg);
                int bytesRec = clientSocket.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                puntata = JsonSerializer.Deserialize<Dictionary<string, int>>(data);
                string[] n_estratto = s.Risultato();

                List<string> r = new List<string>();
                List<int> q = new List<int>();
                foreach (KeyValuePair<string, int> pair in puntata)
                {
                    string check1 = pair.ToString();
                    string[] check2 = check1.Split(',');
                    r.Append(check2[0].Substring(1));
                    q.Append(int.Parse(check2[1].Substring(0, check2[1].Length - 1)));
                }


                // Show the data on the console.  

                // Echo the data back to the client.  

                roulette.Quota(n_estratto, r, q);
                msg = Encoding.ASCII.GetBytes("End$");
                clientSocket.Send(msg);
                bytesRec = clientSocket.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
            }
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            data = "";
        }
        public void abilita()
        {
            byte[] msg = Encoding.ASCII.GetBytes("Punta$");
            clientSocket.Send(msg);
        }
        public void disabilita()
        {
            byte[] msg = Encoding.ASCII.GetBytes("Wait$");
            clientSocket.Send(msg);
        }
    }
}

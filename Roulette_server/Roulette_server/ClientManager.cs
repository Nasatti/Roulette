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

        public ClientManager(Socket clientSocket, Server s)
        {
            this.clientSocket = clientSocket;
            this.s = s;
        }

        public void doClient()
        {
            Dictionary<string, int> puntata = new Dictionary<string, int>();
            while (data != "Quit$")
            {
                // An incoming connection needs to be processed.  
                //data = "";
                byte[] msg = Encoding.ASCII.GetBytes("Giro Ruota$");
                clientSocket.Send(msg);
                int bytesRec = clientSocket.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                puntata = JsonSerializer.Deserialize<Dictionary<string, int>>(data);
                foreach (KeyValuePair<string, int> pair in puntata)
                {
                    MessageBox.Show(pair.ToString());
                }



                // Show the data on the console.  

                // Echo the data back to the client.  
                string[] stringa = s.Risultato();
                msg = Encoding.ASCII.GetBytes(stringa[0] + " " + stringa[1] + "$");
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

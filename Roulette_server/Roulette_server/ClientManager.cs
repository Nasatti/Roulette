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
        byte[] bytes = new Byte[1024];
        String data = "";

        public ClientManager(Socket clientSocket)
        {
            this.clientSocket = clientSocket;
        }

        public void doClient()
        {
            Dictionary<string, int> puntata = new Dictionary<string, int>();
            while (data != "Quit$")
            {
                // An incoming connection needs to be processed.  
                //data = "";
                byte[] msg = Encoding.ASCII.GetBytes("Giro Ruota");
                clientSocket.Send(msg);
                while (data.IndexOf("$") == -1)
                {
                    int bytesRec = clientSocket.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                }
                puntata = JsonSerializer.Deserialize<Dictionary<string, int>>(data);
                foreach(KeyValuePair<string, int> pair in puntata)
                {
                    MessageBox.Show(pair.ToString());
                }
                // Show the data on the console.  

                // Echo the data back to the client.  
                msg = Encoding.ASCII.GetBytes("End$");
                clientSocket.Send(msg);
            }
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            data = "";

        }
    }
}

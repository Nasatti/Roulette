using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

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

            while (data != "Quit$")
            {
                // An incoming connection needs to be processed.  
                //data = "";
                byte[] msg = Encoding.ASCII.GetBytes("ciao");

                clientSocket.Send(msg);
                while (data.IndexOf("$") == -1)
                {
                    /*int bytesRec = clientSocket.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                */
                }

                // Show the data on the console.  

                // Echo the data back to the client.  
                //byte[] msg = Encoding.ASCII.GetBytes(data);

                //clientSocket.Send(msg);
            }
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            data = "";

        }
    }
}

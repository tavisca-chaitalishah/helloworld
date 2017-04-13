using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    class Program
    {

        public static Hashtable clientsList = new Hashtable();

        static void Main(string[] args)
        {
            TcpClient clientSocket = null;
            TcpListener serverSocket = null;
            try
            {
                serverSocket = new TcpListener(8080);
                clientSocket = default(TcpClient);
                int counter = 0;

                serverSocket.Start();
                Console.WriteLine("Chat Server Started ....");
                counter = 0;
                while ((true))
                {
                    counter += 1;
                    clientSocket = serverSocket.AcceptTcpClient();
                    int clientSocketLength = clientSocket.ReceiveBufferSize;
                    byte[] bytesFrom = new byte[clientSocketLength];
                    string dataFromClient = null;

                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, clientSocketLength);
                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                    clientsList.Add(dataFromClient, clientSocket);

                  BroadcastMessager.broadcast(dataFromClient + " Joined ", dataFromClient, false);

                    Console.WriteLine(dataFromClient + " Joined chat room ");
                    HandleClient client = new HandleClient();
                    client.startClient(clientSocket, dataFromClient, clientsList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("server unavailable");
            }
            finally
            {
                clientSocket.Close();
                serverSocket.Stop();
                Console.WriteLine("exit");
                Console.ReadLine();
            }
        }
    }//end Main class

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientSide
{
    class Program
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            Console.Title = "Client";
            LoopConnect();
            sendLoop();
            Console.ReadLine();
        }

        private static void sendLoop()
        {
            while (true)
            {
                Thread.Sleep(500);
                byte[] buffer = Encoding.ASCII.GetBytes("get time");
                _clientSocket.Send(buffer);
                byte[] receivedBuf = new byte[1024];
                int rec = _clientSocket.Receive(receivedBuf);

                byte[] data = new byte[rec];
                Array.Copy(receivedBuf, data, rec);
                Console.WriteLine("Received :" + Encoding.ASCII.GetString(data));
                
            }
        }

        private static void LoopConnect()
        {

            int attemps = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    attemps++;

                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (SocketException)
                {
                    Console.Clear();
                    Console.WriteLine("Connection Attemps :" + attemps.ToString());

                }
            }
            Console.Clear();
            Console.WriteLine("Connected");
        }
    }
}

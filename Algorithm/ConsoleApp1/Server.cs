using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.ComponentModel;

namespace ConsoleApp1
{
    class Server
    {
        public static int maxPlayers;
        public static int port;

        public static Dictionary<int, Client> clients = new Dictionary<int, Client>();

        public static TcpListener listener;

        public static void Start(int _maxPlayers, int _port)
        {
            maxPlayers = _maxPlayers;
            port = _port;

            Console.WriteLine("Starting Server");
            InitializeServerData();

            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();

            listener.BeginAcceptTcpClient(new AsyncCallback(TcpListenerCallBack), null);

            Console.Write($"Server started on {port}");
        }
        private static void TcpListenerCallBack(IAsyncResult _result)
        {
            TcpClient client = listener.EndAcceptTcpClient(_result);
            listener.BeginAcceptTcpClient(new AsyncCallback(TcpListenerCallBack), null);
            Console.WriteLine($"Incoming connection from {client.Client.RemoteEndPoint}");

            for (int i = 1; i<= maxPlayers; i++)
            {
                if (clients[i].tcp.socket == null)
                {
                    clients[i].tcp.Connect(client);
                    return;
                }
            }
            Console.WriteLine("Failed to connect");
        }
        public static void InitializeServerData()
        {
            for (int i = 1; i <= maxPlayers; i++)
            {
                clients.Add(i, new Client(i));
            }
        }
    }
}

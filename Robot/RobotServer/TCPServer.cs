using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace RobotServer
{
    public class TCPServer
    {
        TcpListener listener;
        public event EventHandler TCPLog;

        public TCPServer(int port)
        {
            listener = new TcpListener(IPAddress.Any, port);
        }
        public void Start()
        {
            listener.Start();
            TCPLog?.Invoke("TCP Server Startet", null);
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                TCPLog?.Invoke("TCP Server Connected", null);
                TCPServerHandler handler = new TCPServerHandler(client);
                new Thread(handler.HandleRequest).Start();
            }

        }
    }
}

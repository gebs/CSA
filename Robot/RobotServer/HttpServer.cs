using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace RobotServer
{
    public class HttpServer
    {
        TcpListener listener;
        public event EventHandler HttpLog;

        public HttpServer(int port)
        {
            listener = new TcpListener(IPAddress.Any, port);
        }

        public void Start()
        {
            listener.Start();
            HttpLog?.Invoke("HTTP Server Startet", null);
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                HttpLog?.Invoke("HTTP Server Connected", null);
                HttpServerHandler handler = new HttpServerHandler(client);
                new Thread(handler.HandleRequest).Start();
            }
        }
    }
}

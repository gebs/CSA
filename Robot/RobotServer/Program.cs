using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;

namespace RobotServer
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpServer hs = new HttpServer(8075);
            hs.HttpLog += Hs_HttpLog;
            new Thread(hs.Start).Start();

            TCPServer ts = new TCPServer(7300);
            ts.TCPLog += Ts_TCPLog;
            new Thread(ts.Start).Start();
        }
        private static void Ts_TCPLog(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }

        private static void Hs_HttpLog(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }
    }
}

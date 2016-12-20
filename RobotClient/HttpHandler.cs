using System;
using System.Net.Sockets;
using System.IO;

namespace SimpleHttpServer {

    class HttpHandler {

        private TcpClient client;
        private String path;

        public HttpHandler(TcpClient client) {
            this.client = client;
            this.path = System.Reflection.Assembly.GetAssembly(typeof(SimpleHttpServer)).Location;
            path = Path.GetDirectoryName(path)+ "\\public";

        }

        public void Do() {
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());
            Console.WriteLine("Verbindung zu " +
                client.Client.RemoteEndPoint);


            while (sr.ReadLine() != String.Empty)
            {

            }


            // Datei lesen
            FileStream fs = new FileStream(path + "\\TextFile1.txt", FileMode.Open, FileAccess.Read);
            //fs.Lock(0, fs.Length);
 
            StreamReader srFile = new StreamReader(fs);

            // Datei im HTTP-Format senden
            sw.WriteLine("HTTP/1.1 200 OK");
            sw.WriteLine("Content-type: text/plain");
            sw.WriteLine("Connection:close");
            sw.WriteLine("");
            sw.WriteLine(srFile.ReadToEnd());
            sw.Flush();


            client.Close();
        }
    }
}

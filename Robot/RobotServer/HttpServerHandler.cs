using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace RobotServer
{
    public class HttpServerHandler
    {
        private const string html = "<html><head><title>Beste Gruppe</title></head><body>$$Log</body></html>";
        private TcpClient client;

        public HttpServerHandler(TcpClient client)
        {
            this.client = client;
        }
        public void HandleRequest()
        {
            try
            {
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());

                while (sr.ReadLine() != String.Empty)
                {

                }

                string shtml = "";


                if (AppData.RunnungCommandList.Count == 0)
                    shtml = html.Replace("$$Log", "No Data Found<br/><br/>");
                else
                    shtml = html.Replace("$$Log", string.Join("<br/>", AppData.RunnungCommandList.Select(x => x.getHTML()).ToArray()));


                sw.WriteLine("HTTP/1.1 200 OK");
                sw.WriteLine("Content-type: text/html");
                sw.WriteLine("Connection:close");
                sw.WriteLine("");
                sw.WriteLine(shtml);
                sw.Flush();

                client.Close();

            }
            catch (Exception e)
            {

            }
        }
    }
}

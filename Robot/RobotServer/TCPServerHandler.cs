using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace RobotServer
{
    public class TCPServerHandler
    {
        private TcpClient client;
        static object locker = new object();
        public TCPServerHandler(TcpClient _client)
        {
            client = _client;
        }

        public void HandleRequest()
        {
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());

            try
            {
                string command = "";
                command += sr.ReadLine();
                sr.Close();
                string[] scommand = command.Split(' ');

                RobotCommand rcmd = new RobotCommand();
                rcmd.CMD = (Command)Enum.Parse(typeof(Command), scommand[0],true);
                switch (rcmd.CMD)
                {
                    case Command.TrackLine:
                        rcmd.ValueL = Convert.ToDouble(scommand[1]);
                        break;
                    case Command.TrackTurnLeft:
                    case Command.TrackTurnRight:
                        rcmd.ValueA = Convert.ToInt32(scommand[1]);
                        break;
                    case Command.TrackArcLeft:
                    case Command.TrackArcRight:
                        rcmd.ValueA = Convert.ToInt32(scommand[1]);
                        rcmd.ValueL = Convert.ToDouble(scommand[2]);
                        break;
                    case Command.Start:
                        RobotExecutor re = new RobotExecutor(AppData.CommandList.Clone());
                        AppData.CommandList = new List<RobotCommand>();
                        new Thread(re.Start).Start();
                        break;
                    default:
                        break;
                }

                Console.WriteLine(command);

                lock (locker)
                {
                    if (rcmd.CMD != Command.Start)
                        AppData.CommandList.Add(rcmd);
                }
                sw.WriteLine("OK");
                sw.Flush();
                sw.Close();

            }
            catch (Exception e)
            {

            }
            finally
            {
                client.Close();
               
                
            }
        }

    }
}

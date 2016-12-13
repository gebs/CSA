using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel;
namespace WCFTest
{
    [ServiceContract]
    public interface IRobotControlService
    {
        [OperationContract]
        void AddCommand(string command);
        [OperationContract]
        string GetCommands();
    }
    public enum Command
    {
        TrackLine,
        TrackTurnLeft,
        TrackTurnRight,
        TrackArcLeft,
        TrackArcRight,
        Start
    }
    public class RobotCommand
    {
        public Command CMD { get; set; }
        public int ValueA { get; set; }
        public double ValueL { get; set; }
    }
    public class RobotControlService : IRobotControlService
    {
        List<RobotCommand> Commands = new List<RobotCommand>();

        public void AddCommand(string command)
        {
            string[] scommand = command.Split(' ');

            RobotCommand rcmd = new RobotCommand();
            rcmd.CMD = (Command)Enum.Parse(typeof(Command), scommand[0]);
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
                    break;
                default:
                    break;
            }
            Console.WriteLine(command);
            Commands.Add(rcmd);
        }

        public string GetCommands()
        {
            return "<html><body>This is a Test</body><html>";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# on Windows Embedded Systems");
        }
    }
}

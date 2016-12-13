using RobotCtrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RobotServer
{
    public class RobotExecutor
    {
        //List<RobotCommand> commands { get; set; } = new List<RobotCommand>();
        

        public RobotExecutor(List<RobotCommand> _commands)
        {
            AppData.RunnungCommandList = _commands;
        }
        public void Start()
        {
            AppData.Drive.Power = true;
            foreach (RobotCommand item in AppData.RunnungCommandList)
            {
                switch (item.CMD)
                {
                    case Command.TrackLine:
                        AppData.Drive.RunLine((float)item.ValueL, 0.5f, 0.3f);
                        break;
                    case Command.TrackTurnLeft:
                        AppData.Drive.RunTurn(item.ValueA, 0.5f, 0.3f);
                        break;
                    case Command.TrackTurnRight:
                        AppData.Drive.RunTurn(item.ValueA * -1, 0.5f, 0.3f);
                        break;
                    case Command.TrackArcLeft:
                        AppData.Drive.RunArcLeft((float)item.ValueL, item.ValueA, 0.5f, 0.3f);
                        break;
                    case Command.TrackArcRight:
                        AppData.Drive.RunArcRight((float)item.ValueL, item.ValueA, 0.5f, 0.3f);
                        break;
                    case Command.Start:
                        AppData.Drive.Power = false;
                        break;
                    default:    
                        break;
                }

                while (!AppData.Drive.Done) { }
        //        Thread.Sleep(100);
                item.Status = Status.Done;
            }
        }
    }
}

using RobotCtrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotServer
{
    public static class AppData
    {
        public static List<RobotCommand> CommandList { get; set; } = new List<RobotCommand>();
        public static List<RobotCommand> RunnungCommandList { get; set; } = new List<RobotCommand>();
        public static Drive Drive { get; set; } = new Drive();
    }
}

using RobotCtrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotServer
{
    public class RobotCommand : ICloneable
    {
        public Command CMD { get; set; }
        public int ValueA { get; set; }
        public double ValueL { get; set; }
        public DateTime Timestamp { get; set; }
        public Status Status { get; set; } = Status.Open;
        public List<PositionInfo> Positions { get; set; } = new List<PositionInfo>();

        public RobotCommand()
        {
            Timestamp = DateTime.Now;
        }
        public string getHTML()
        {
            return $"{Timestamp.ToString("dd.MM.yyyy hh:mm:ss")}&emsp;{CMD.ToString()}&emsp;{ValueA}&emsp;{ValueL}&emsp;Positions:<br>&emsp;" 
                        + string.Join("<br>&emsp;", Positions.Select(x=> $"&emsp;x: {x.X.ToString("#0.00000000")}&emsp;y:&emsp;{x.Y.ToString("#0.000000000")}&emsp;angle: {x.Angle.ToString("#0.00")}").ToArray());
        }

        public object Clone()
        {
            RobotCommand rc = new RobotCommand();
            rc.CMD = this.CMD;
            rc.ValueA = this.ValueA;
            rc.ValueL = this.ValueL;
            rc.Timestamp = this.Timestamp;
            rc.Status = this.Status;
            return rc;
        }
    }
}

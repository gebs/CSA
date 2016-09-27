using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung2_Events
{
    public class MyEventArgs : EventArgs
    {
        public string EventData{ get; set; }
        public MyEventArgs(string eventData)
        {
            this.EventData = eventData;
        }
    }
}

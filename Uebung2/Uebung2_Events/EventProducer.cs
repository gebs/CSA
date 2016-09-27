using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung2_Events
{
    public class EventProducer
    {
        public event MyEventHandler MyEvent;

        public void OnMyEvent(string Data)
        {
            MyEvent?.Invoke(this, new MyEventArgs(Data));
        }
    }
}

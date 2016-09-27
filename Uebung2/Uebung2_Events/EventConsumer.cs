using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung2_Events
{
    public class EventConsumer
    {
        public EventConsumer(EventProducer ep)
        {
            ep.MyEvent += Ep_MyEvent;    
        }

        private void Ep_MyEvent(object sender, MyEventArgs e)
        {
            Console.WriteLine(e.EventData);
        }
    }
}

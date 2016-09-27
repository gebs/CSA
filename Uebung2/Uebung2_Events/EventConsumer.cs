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
            ep.MyEvent += (s,e)=> { Console.WriteLine(e.EventData); };
        }


    }
}

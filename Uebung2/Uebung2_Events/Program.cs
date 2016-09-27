using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung2_Events
{
    public delegate void MyEventHandler(object sender, MyEventArgs e);


    class Program
    {
        public Program()
        {
            EventProducer producer = new EventProducer();
            EventConsumer consumer1 = new EventConsumer(producer);
            EventConsumer consumer2 = new EventConsumer(producer);
            producer.OnMyEvent("Event fired...");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {

            Program prog = new Program();
            Console.Read();
        }
    }

}

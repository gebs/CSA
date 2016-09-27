using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung2
{
    class Program
    {



        static void Main(string[] args)
        {
            StringList sl = new StringList();
            sl.Size = 5;

            Console.WriteLine($"Size: {sl.Size}");

            sl.Data[1] = "Some Value";
            sl.Data[3] = "Another Value";

            foreach (string s in sl.Data)
            {
                Console.WriteLine($"entry: {s}");
            }
            Console.WriteLine("");

            sl[4] = "Something else";
            sl[0] = $"{sl[1]}, {sl[3]}";

            for (int i = 0; i < sl.Size; i++)
            {
                Console.WriteLine($"entry:[{i}]: {sl[i]}");
            }
            Console.Read();
        }
    }
}

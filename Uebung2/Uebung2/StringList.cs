using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung2
{
    public class StringList
    {
       
        public int Size
        { 
            get { return Data.Length; }
            set
            { 
                Data = new string[value];
            }
        }

        
        public string[] Data { get; set; }
        public string this[int index]
        {
            get { return Data?[index] ?? ""; }
            set { Data[index] = value; }
        }
        public StringList()
        {
          
        }
    }
}

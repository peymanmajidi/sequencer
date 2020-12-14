using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequencer.Models
{
    public class Utility
    {
        public static  List<int> PreGenerated = new List<int>();
        public static int GenertateRandom()
        {
            var n = new Random().Next(1, 20);
            if(PreGenerated.IndexOf(n)>0)
            {
                return GenertateRandom();
            }
            PreGenerated.Add(n);
            return n;
        }
       
    }
}

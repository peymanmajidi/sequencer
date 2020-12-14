using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequencer.Models
{
    public enum Row
    {
        UP, DOWN

    }
    public class Gate
    {

        public int Index { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public Row Row { get; set; }


    }
}

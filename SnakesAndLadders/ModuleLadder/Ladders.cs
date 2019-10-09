using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Ladders
    {
        public int LadderHead { get; set; }
        public int LadderTail { get; set; }
        public Ladders(int LadderUp, int LadderDown)
        {
            this.LadderHead = LadderUp;
            this.LadderTail = LadderDown;
        }

        public Ladders()
        { }
        
    }
}

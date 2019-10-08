using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Ladders
    {
        public int ladderUp { get; set; }
        public int ladderDown { get; set; }
        public Ladders(int LadderUp, int LadderDown)
        {
            this.ladderUp = LadderUp;
            this.ladderDown = LadderDown;
        }
    }
}

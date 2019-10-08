using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class PositionLadder:Ladders
    {
        public PositionLadder(int ladderUp, int ladderDown) :
           base(ladderUp, ladderDown)
        { }
        public static Dictionary<int, Ladders> LadderPosition = new Dictionary<int, Ladders>()
        {
            //Snake
            {17, new Ladders(7,17)},
            {54, new Ladders(34,54)},
            {62, new Ladders (19,62)},
            {99, new Ladders(99,20)}
        };
    }
}

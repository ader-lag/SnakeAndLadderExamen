using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class PositionSnake: Snakes
    {
        public PositionSnake(int headSnake, int tailSnake):
            base(headSnake, tailSnake)
        { }
        public static Dictionary<int, Snakes> SnakeAndLeadder = new Dictionary<int, Snakes>()
        {
            //Snake
            {1, new Snakes(7,17)},
            {2, new Snakes(34,54)},
            {3, new Snakes(19,62)},
            {4, new Snakes(99,20)}
        };
    }
}

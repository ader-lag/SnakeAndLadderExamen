using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Snakes
    {
        public int HeadSnake { get; set; }
        public int TailSnake { get; set; }

        public Snakes(int headSnake, int tailSnake)
        {
            this.HeadSnake = headSnake;
            this.TailSnake = tailSnake;
        }
    }
}

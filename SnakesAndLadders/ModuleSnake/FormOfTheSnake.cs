using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class FormOfTheSnake
    {
        public static Snakes GetShape(Snakes form, int lowerLimit, int upperLimit)
        {
            var rand = new Random();
            int limit = rand.Next(lowerLimit, upperLimit);
            int lower = rand.Next(lowerLimit, upperLimit);
            if (limit > lower)
            {
                form.HeadSnake = limit;
                form.TailSnake = lower;
            }
            else
            {
                GetShape(form, lowerLimit, upperLimit);
            }
            return form;
        }
    }
}

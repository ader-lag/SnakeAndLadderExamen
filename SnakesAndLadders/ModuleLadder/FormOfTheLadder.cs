using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class FormOfTheLadder
    {
        public static Ladders GetShape(Ladders form, int lowerLimit, int upperLimit)
        {
            var rand = new Random();
            int limit = rand.Next(lowerLimit, upperLimit);
            int lower = rand.Next(lowerLimit, upperLimit);
            if (limit > lower)
            {
                form.LadderHead = limit;
                form.LadderTail = lower;
            }
            else
            {
                GetShape(form, lowerLimit, upperLimit);
            }
            return form;
        }
    }
}

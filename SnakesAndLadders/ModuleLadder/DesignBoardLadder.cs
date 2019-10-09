using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class DesignBoardLadder
    {
        public static List<Ladders> DrawLadders(int quantity, int upperLimit, int lowerLimit)
        {
            List<Ladders> LaddersList = new List<Ladders>();
            for (int i = 0; i < quantity; i++)
            {
                Ladders currenShape = (Ladders)FormOfTheLadder.GetShape(new Ladders(), lowerLimit, upperLimit);
                LaddersList.Add(currenShape);
                upperLimit = upperLimit + 10;
                lowerLimit = lowerLimit + 8;
            }
            return LaddersList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class DesignBoardSnake
    {
        public static List<Snakes> DrawSnakes(int quantity, int upperLimit, int lowerLimit)
        {
            List<Snakes> SnakesList = new List<Snakes>();
            for (int i = 0; i < quantity; i++)
            {
                Snakes currenShape = (Snakes)FormOfTheSnake.GetShape(new Snakes(), lowerLimit, upperLimit);
                SnakesList.Add(currenShape);
                upperLimit = upperLimit + 20;
                lowerLimit = lowerLimit + 7;
            }
            return SnakesList;
        }
    }


}

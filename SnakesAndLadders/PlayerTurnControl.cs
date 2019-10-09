using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class PlayerTurnControl
    {
        public static Player firstTurn(Player firstPlayer, Player secondPlayer)
        {
            var rand = new Random();
            firstPlayer.Turn = rand.Next(1, 7);
            secondPlayer.Turn = rand.Next(1, 7);
            if(firstPlayer.Turn == 7 )
            {
                Console.WriteLine("Es turno del jugador 1");
                var currentPlayer = firstPlayer;
                return currentPlayer;
            }
            else
            {
                if(firstPlayer.Turn == 1)
                {
                    Console.WriteLine("Es turno del jugador 1");
                    var currentPlayer = firstPlayer;
                    return currentPlayer;
                }
                else
                {
                    Console.WriteLine("Es turno del jugador 2");
                    var currentPlayer = secondPlayer;
                    return currentPlayer;
                }
            }
        }
    }
}

using ShipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipLibrary.Methods;

namespace BattleShipLite.UIMethods
{
    public class TakeShot
    {

        public static void ShotCoordinates(int turnCount, PlayerInfoModel attacker, PlayerInfoModel defender)
        {
            

            var shotLetter = ConsoleMessage.MessageAndResponseLetter($"Enter letter coordinates (A-E) for shot number  {turnCount} ");
            var shotNumber = ConsoleMessage.MessageAndResponseInt($"Enter number coordinates (1-5) for shot number  {turnCount} ");

            foreach (GridModel coord in attacker.ShotGrid)
            {
                if (shotLetter == coord.SpotLetter && shotNumber == coord.SpotNumber)
                {
                    if (coord.Status == Enums.GridSpotStatus.Hit || coord.Status == Enums.GridSpotStatus.Miss)
                    {
                        Console.WriteLine("Please choose a coordinates that hasn't been played.");
                        ShotCoordinates(turnCount, attacker, defender);
                    }
                    else
                    {
                        foreach (GridModel point in defender.ShipGrid)
                        {
                            if (shotLetter == point.SpotLetter && shotNumber == point.SpotNumber)
                            {
                                if (point.Status == Enums.GridSpotStatus.Ship)
                                {
                                    Console.WriteLine("Congrats! You sunk an enemy battleship!");
                                    coord.Status = Enums.GridSpotStatus.Hit;
                                }
                                else
                                {
                                    Console.WriteLine("You missed! :\n( ");
                                    coord.Status = Enums.GridSpotStatus.Miss;
                                }
                            }
                        }
                        
                    }
                }
            }


        }

    }
}

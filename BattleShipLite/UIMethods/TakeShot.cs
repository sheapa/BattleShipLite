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
                string attackLetter = coord.SpotLetter;
                int attackNumber = coord.SpotNumber;
                Enum attackStatus = coord.Status;

                if (shotLetter == attackLetter && shotNumber == attackNumber &&
                    attackStatus is Enums.GridSpotStatus.Hit)
                {

                    Console.WriteLine("Please choose a coordinates that hasn't been played.");
                    ShotCoordinates(turnCount, attacker, defender);

                }
                else if (shotLetter == attackLetter && shotNumber == attackNumber &&
                         attackStatus is Enums.GridSpotStatus.Miss)
                {
                    Console.WriteLine("Please choose a coordinates that hasn't been played.");
                    ShotCoordinates(turnCount, attacker, defender);
                }
                else
                {
                    HitChecker(defender, shotLetter, shotNumber, attackStatus );
                    break;
                }

            }

            

           
        }

        public static void HitChecker(PlayerInfoModel defender, string shotLetter, int shotNumber, Enum attackStatus)
        {
            foreach (GridModel point in defender.ShipGrid)
            {
                string defenseLetter = point.SpotLetter;
                int defenseNumber = point.SpotNumber;
                Enum defenseStatus = point.Status;


                if (shotLetter == defenseLetter && shotNumber == defenseNumber && defenseStatus is Enums.GridSpotStatus.Ship)
                {
                    Console.WriteLine("Congrats! You sunk an enemy battleship!");
                    defenseStatus = Enums.GridSpotStatus.Sunk;
                    attackStatus = Enums.GridSpotStatus.Hit;
                    break;

                }
                else
                {
                    Console.WriteLine("You missed! ");
                    attackStatus = Enums.GridSpotStatus.Miss;
                    break;

                }


            }
        }
    }
}

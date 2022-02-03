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
                    foreach (var gridModel in attacker.ShotGrid)
                    {
                        if (shotLetter == attackLetter && shotNumber == attackNumber &&
                            attackStatus is Enums.GridSpotStatus.Hit)
                        {
                            Console.WriteLine("Please choose a coordinates that hasn't been played.");
                            ShotCoordinates(turnCount, attacker, defender);

                        }
                    }

                    break;


                }
                else if (shotLetter == attackLetter && shotNumber == attackNumber &&
                         attackStatus is Enums.GridSpotStatus.Miss)
                {
                    foreach (var gridModel in attacker.ShotGrid)
                    {
                        if (shotLetter == attackLetter && shotNumber == attackNumber &&
                            attackStatus is Enums.GridSpotStatus.Miss)
                        {
                            Console.WriteLine("Please choose a coordinates that hasn't been played.");
                            ShotCoordinates(turnCount, attacker, defender);

                        }
                    }

                    break;

                }
                else if (shotLetter == attackLetter && shotNumber == attackNumber)
                {
                    foreach (GridModel point in defender.ShipGrid)
                    {
                        string defenseLetter = point.SpotLetter;
                        int defenseNumber = point.SpotNumber;
                        Enum defenseStatus = point.Status;
                        Enum shotStatus;


                        if (shotLetter == defenseLetter && shotNumber == defenseNumber)
                        {
                            if (defenseStatus is Enums.GridSpotStatus.Ship)
                            {
                                Console.WriteLine("Congrats! You sunk an enemy battleship!");
                                shotStatus = Enums.GridSpotStatus.Hit;

                                foreach (var shotGridModel in attacker.ShotGrid)
                                {
                                    if (shotGridModel.SpotLetter == attackLetter &&
                                        shotGridModel.SpotNumber == attackNumber)
                                    {
                                        shotGridModel.Status = (Enums.GridSpotStatus) shotStatus;
                                        
                                    }
                                }


                            }

                            break;
                        }
                        else if (shotLetter != defenseLetter && shotNumber != defenseNumber)
                        {
                            Console.WriteLine("You Missed :(");
                            shotStatus = Enums.GridSpotStatus.Miss;

                            foreach (var shotGridModel in attacker.ShotGrid)
                            {
                                if (shotGridModel.SpotLetter == attackLetter &&
                                    shotGridModel.SpotNumber == attackNumber)
                                {
                                    shotGridModel.Status = (Enums.GridSpotStatus)shotStatus;
                                    
                                }
                            }

                            break;
                        }
                        else if (shotLetter == defenseLetter && shotNumber != defenseNumber)
                        {
                            Console.WriteLine("You Missed :(");
                            shotStatus = Enums.GridSpotStatus.Miss;

                            foreach (var shotGridModel in attacker.ShotGrid)
                            {
                                if (shotGridModel.SpotLetter == attackLetter &&
                                    shotGridModel.SpotNumber == attackNumber)
                                {
                                    shotGridModel.Status = (Enums.GridSpotStatus)shotStatus;
                                }
                            }

                            break;
                        }

                    }
                }
            }



        }

        
    }
}

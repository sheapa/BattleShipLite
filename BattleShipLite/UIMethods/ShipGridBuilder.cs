using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShipLite;
using ShipLibrary.Models;


namespace ShipLibrary.Methods
{
    public class ShipGridBuilder
    {
        public static void BuildGrid(PlayerInfoModel player, int startLoop)
        {
            for (int i = startLoop; i < 5; i++)
            {

                GridModel ship = CreateShip(i);

                foreach (GridModel grid in player.ShipGrid)
                {
                    if (ship.SpotLetter == grid.SpotLetter && ship.SpotNumber == grid.SpotNumber)
                    {
                        Console.WriteLine(
                            $"Please enter a unique coordinates {ship.SpotLetter}{ship.SpotNumber} is already in use.");
                        BuildGrid(player, i);
                    }
                }
                player.ShipGrid.Add(ship);

            }

            Console.Clear();
        }

        public static GridModel CreateShip(int num)
        {
            GridModel ship = new GridModel();

            ship.SpotLetter = ConsoleMessage.MessageAndResponseLetter($"Enter letter coordinates (A-E) for ship number  {num + 1} ");
            ship.SpotNumber = ConsoleMessage.MessageAndResponseInt($"Enter number coordinates (1-5) for ship number  {num + 1} ");
            ship.Status = Enums.GridSpotStatus.Ship;

            return ship;

        }
        
    }
}

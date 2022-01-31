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
        public static void BuildGrid(PlayerInfoModel player)
        {
            for (int i = 0; i < 5; i++)
            {
                GridModel ship = new GridModel();

                ship.SpotLetter = ConsoleMessage.MessageAndResponseString($"Enter letter coordinates for ship number {i + 1} ");
                ship.SpotNumber = ConsoleMessage.MessageAndResponseInt($"Enter number coordinates for ship number {i + 1} ");

                player.ShipGrid.Add(ship);
                Console.Clear();
            }
        }

      
    }
}

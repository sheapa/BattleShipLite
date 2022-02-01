using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipLibrary.Models;

namespace BattleShipLite.UIMethods
{
    internal class DisplayShotGrid
    {
        

        public static void DisplayGrid(PlayerInfoModel player)
        {
            int i = 0;
            foreach (GridModel grid in player.ShotGrid)
            {
                i++;

                string coord = $"{grid.SpotLetter}{grid.SpotNumber}";
               
                switch (i % 5)
                {
                    case 0:
                        Console.WriteLine($" {coord}");
                        break;
                    default:
                        Console.Write($" {coord}");
                        break;
                }


            }
        }
    }
}    

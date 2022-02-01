using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipLibrary.Models;

namespace BattleShipLite.UIMethods
{
    public class DisplayShotGrid
    {
        

        public static void DisplayGrid(PlayerInfoModel player)
        {
            int i = 0;
            foreach (GridModel grid in player.ShotGrid)
            {
                i++;
                string coord = null;

                switch (grid.Status)
                {
                    case Enums.GridSpotStatus.Empty:
                        coord = $"{grid.SpotLetter}{grid.SpotNumber}";
                        break;
                    case Enums.GridSpotStatus.Hit:
                        coord = $"{grid.SpotLetter}X";
                        break;
                    case Enums.GridSpotStatus.Miss:
                        coord = $"{grid.SpotLetter}O";
                        break;

                }
               
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ShipLibrary.Models;

namespace ShipLibrary.Methods
{
    public class ShotGrid
    {
        public static void InitializeGrid(PlayerInfoModel model)
        {
            List<string> letters = new List<string>

            {
                "A",
                "B",
                "C",
                "D",
                "E",
            };
            List<int> numbers = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
            };

            foreach (string letter in letters)
            {
                foreach (int number in numbers)
                {
                    AddGridSpot(model, letter, number);
                    
                }
            }
        }

        private static void AddGridSpot(PlayerInfoModel model, string letter, int number)
        {
            GridModel spot = new GridModel
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = Enums.GridSpotStatus.Empty
            };

            model.ShotGrid.Add(spot);
        }

       
    }

    
}

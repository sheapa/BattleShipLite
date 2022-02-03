using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipLibrary.Models;

namespace ShipLibrary.Methods
{
    public class ScoreChecker
    {
        public static int score(PlayerInfoModel player)
        {
            int score = 0;

            foreach (GridModel ShotGrid in player.ShotGrid)
            {
                if (ShotGrid.Status is Enums.GridSpotStatus.Hit)
                {
                    score ++;
                }
            }

            return score;
        }

        public static void ScoreTally(PlayerInfoModel player1, PlayerInfoModel player2)
        {

        }
    }
}

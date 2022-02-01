using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipLibrary.Methods;
using ShipLibrary.Models;

namespace BattleShipLite.UIMethods
{
    public class BuildPlayer
    {
        public static PlayerInfoModel build(string playerNumber)
        {
            PlayerInfoModel output = new PlayerInfoModel();


            output.PlayerName = ConsoleMessage.MessageAndResponseName($"Enter {playerNumber}'s name. ");

            ShotGrid.InitializeGrid(output);

            ShipGridBuilder.BuildGrid(output, 0);

            return output;
        }
    }
}

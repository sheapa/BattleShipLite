using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipLibrary.Models
{
    public class PlayerInfoModel
    {
        public string PlayerName { get; set; }
        public List<GridModel> ShipGrid { get; set; }

        public List<GridModel> ShotGrid { get; set; }

        public PlayerInfoModel()
        { 
           PlayerName = null;

           ShipGrid = new List<GridModel>();

           ShotGrid = new List<GridModel>();
        }
    }

}

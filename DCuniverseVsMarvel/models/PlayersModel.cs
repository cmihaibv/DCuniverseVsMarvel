using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCuniverseVsMarvel.models
{
    public class PlayersModel
    {
        public int id { get; set; }
        public List<PlayerModel> selectedPlayers { get; set; } = new List<PlayerModel> ();
    }
}
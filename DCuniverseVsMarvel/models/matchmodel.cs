using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCuniverseVsMarvel.models
{
    public class matchmodel
    {
        public int id { get; set; }
        public List<PlayersModel> matchPlayers { get; set; } = new List<PlayersModel>();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCuniverseVsMarvel.models
{
    public class PlayerModel
    {
        public int id { get; set; }
        public string emailAddress { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        /// <summary>
        /// We need to refference the deckId selected by player to play in matchups
        /// </summary>
        public int deckID { get; set; }

    }
}
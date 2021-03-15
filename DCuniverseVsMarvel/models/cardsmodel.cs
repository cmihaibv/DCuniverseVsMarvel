using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCuniverseVsMarvel.models
{
    public class cardsmodel
    {
        public int id { get; set; }
        public string cardName { get; set; }
        public int cardDamage { get; set; }
        public int cardHealth { get; set; }
        public int cardCost { get; set; }
    }
}
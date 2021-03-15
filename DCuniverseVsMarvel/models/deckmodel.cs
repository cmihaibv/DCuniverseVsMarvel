using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCuniverseVsMarvel.models
{
    public class deckmodel
    {
        public int id { get; set; }
        public List<cardsmodel> availableCards { get; set; } = new List<cardsmodel>();
    }
}
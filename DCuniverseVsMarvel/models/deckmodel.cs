using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCuniverseVsMarvel.models
{
    public class deckmodel
    {
        public List<cardsmodel> Ford = new List<cardsmodel>
        {
            new cardsmodel{id=1,cardName="Thor",cardHealth=5,cardDamage=5,cardCost=2}
        };

    }
}
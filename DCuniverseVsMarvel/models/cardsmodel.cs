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

        /*  public string name;
        public int damage;
        public int health;
        public int cost;
        public cardsmodel(string cardName, int cardDamage, int cardHealth, int cardCost)
        {
            name = cardName;
            damage = cardDamage;
            health = cardHealth;
            cost = cardCost;
        }*/

    }

}
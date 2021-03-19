using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DCuniverseVsMarvel.web
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\cotim\source\repos\DCuniverseVsMarvel\DCuniverseVsMarvel\data\data.txt";

            List<models.cardsmodel> cards = new List<models.cardsmodel>();
            List<string> lines = File.ReadAllLines(filepath).ToList();
            foreach(var line in lines)
            {
                string[] entry = line.Split(',');

                models.cardsmodel newCard = new models.cardsmodel();

                newCard.id = int.Parse(entry[0]);
                newCard.cardName = entry[1];
                newCard.cardDamage = int.Parse(entry[2]);
                newCard.cardHealth = int.Parse(entry[3]);
                newCard.cardCost = int.Parse(entry[4]);

                cards.Add(newCard);
            }
            TextBox1.Text += cards[0];

        }
    }
}
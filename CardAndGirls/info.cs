using CardAndGirls.CardBag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndGirls
{
    public class Info
    {
        public Player Player { get; set; }

        public Card Card { get; set; }

        public void Select(Card inputCard)
        {
            Card = inputCard;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndGirls.CardBag
{
    public class Card
    {
        public string Name { get; set; }
        public Image cardImage;
        public Player Player { get; set; }
        public enum CardType 
        {
            Mon_Card,Mgc_Card,Pit_Card 
        }
        public CardType Type { get; set; }
        public CardState State { get; set; }

        public enum CardState
        {
            State_Att, State_Def, State_InDom, State_InHandCard, State_InCardGroup
        }

        public string Stateof()
        {
            if(this.State==CardState.State_Att)
            {
                return"【攻】";
            }
            else if(this.State==CardState.State_Def)
            {
                return "【守】";
            }
            else
            {
                return "";
            }
        }
    }
}

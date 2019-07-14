using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardAndGirls.CardBag;

namespace CardAndGirls
{
    public class HandCardController
    {
        public List<Card> handCard = new List<Card>(5);
        public Player Player { get; set; }



        
        public HandCardController()
        {

        }



        public List<Card> GiveActvieHandCard()
        {
            return handCard;
        }

        //抽牌放入手牌
        public void FiveCardGet(CardGroup cardGroup)
        {
            for (int i= 0;i<5;i++)
            {
                handCard.Add(cardGroup.GiveOutOneCard());
            }
        }

        //重载：默认从自己卡组抽牌
        public void FiveCardGet()
        {
            for (int i = 0; i < 5; i++)
            {
                handCard.Add(Player.CardGroup.GiveOutOneCard());
            }
        }

        //抽一张牌
        public void OneCardGet()
        {
            Card o = Player.CardGroup.GiveOutOneCard();
            if (o is null)
            {
                return;
            }
            o.State = Card.CardState.State_InHandCard;
            handCard.Add(o);
        }

        //打出一张牌
        public Card OneCardGiveOut(Card cardToGiveOut)
        {
            Card cardTGO = cardToGiveOut;
            handCard.Remove(cardToGiveOut);
            return cardTGO;
        }


    }
}

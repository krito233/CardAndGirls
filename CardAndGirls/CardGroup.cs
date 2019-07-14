using CardAndGirls.CardBag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndGirls
{

    public class CardGroup
    {
        public Player Player { get; set; }
        List<Card> cardList_Set = new List<Card>(10);
        public List<Card> cardList = new List<Card>(10);




        //加入卡组，并且为卡组内所有的卡的Player赋值
        public void GetCardGroup(List<Card> inputList)
        {
            cardList_Set= inputList.GetRange(0, inputList.Count);
            for(int i=0;i<cardList.Count;i++)
            {
                cardList_Set[i].Player = this.Player;
            }
            cardList = inputList.GetRange(0, inputList.Count);
            for (int i = 0; i < cardList.Count; i++)
            {
                cardList[i].Player = this.Player;
            }

        }

        //洗牌
        public void RandomCardList()
        {
            List<Card> temp = new List<Card>();
            temp = cardList.GetRange(0, cardList.Count);
            cardList.Clear();
            if(temp.Count==0)
            {
                return;
            }
            cardList.Add(temp[0]);
            Random ran = new Random(System.DateTime.Now.Millisecond);
            //利用插入法对卡组进行重新排列
            for (int i=1;i<temp.Count;i++)
            {
                if(ran.Next(0,100)<50)
                {
                    cardList.Insert(0, temp[i]);
                }
                else
                {
                    cardList.Add(temp[i]);
                }
            }
        }

        //对外输出当前卡组

        //对外输出源卡组
        public List<Card> GiveTheSetList()
        {
            return cardList_Set;
        }

        //给出卡组最上方的一张牌，并且从剩余卡组中移除这张牌
        public Card GiveOutOneCard()
        {
            if(cardList.Count==0)
            {
                return null;
            }
            Card CardToGiveOut = cardList[0];
            cardList.RemoveAt(0);
            return CardToGiveOut;
        }
    }
}

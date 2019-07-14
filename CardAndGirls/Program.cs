using CardAndGirls.CardBag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardAndGirls
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //-----------------------------------------------------------------
            MainPlaceInfo mainPlaceInfo = new MainPlaceInfo();
            MainFightPlace mainFightPlace = new MainFightPlace();

            CardGroup cardGroupA = new CardGroup();
            CardGroup cardGroupB = new CardGroup();

            HandCardController handCardControllerA = new HandCardController();
            HandCardController handCardControllerB = new HandCardController();

            Grave grave1 = new Grave();
            Grave grave2 = new Grave();

            Info infoA = new Info();
            Info infoB = new Info();

            InfoForm infoFormA = new InfoForm();
            InfoForm infoFormB = new InfoForm();

            CardGroupForm cardgroupFormA = new CardGroupForm();
            CardGroupForm cardgroupFormB = new CardGroupForm();

            Player player1 = new Player("刀客塔暮狗蛋");
            Player player2 = new Player("没名字的");

            mainFightPlace.MainPlace_Info = mainPlaceInfo;
            mainPlaceInfo.MainFightPlace = mainFightPlace;

            mainPlaceInfo.Player1 = player1;
            player1.MainPlaceInfo = mainPlaceInfo;
            mainPlaceInfo.Player2 = player2;
            player2.MainPlaceInfo = mainPlaceInfo;

            player1.OpPlayer = player2;
            player2.OpPlayer = player1;

            player1.CardGroup = cardGroupA;
            cardGroupA.Player = player1;
            player2.CardGroup = cardGroupB;
            cardGroupB.Player = player2;


            player1.HandCardController = handCardControllerA;
            handCardControllerA.Player = player1;
            player2.HandCardController = handCardControllerB;
            handCardControllerB.Player = player2;


            player1.Grave = grave1;
            grave1.Player = player1;
            player2.Grave = grave2;
            grave2.Player = player2;
            

            player1.Info = infoA;
            infoA.Player = player1;
            player2.Info = infoB;
            infoB.Player = player2;


            player1.InfoForm = infoFormA;
            infoFormA.Player = player1;
            player2.InfoForm = infoFormB;
            infoFormB.Player = player2;


            player1.CardGroupForm = cardgroupFormA;
            cardgroupFormA.Player = player1;
            player2.CardGroupForm = cardgroupFormB;
            cardgroupFormB.Player = player2;


            //---------------------------------------------------------
            //我方牌组
            List<Card> cardList_SetA = new List<Card>();

            cardList_SetA.Add(new Mon_Bird());
            cardList_SetA.Add(new Mon_Bird());
            cardList_SetA.Add(new Mon_Bird());
            cardList_SetA.Add(new Mon_Cat());
            cardList_SetA.Add(new Mon_Cat());
            cardList_SetA.Add(new Mon_Cat());
            cardList_SetA.Add(new Mon_Dog());
            cardList_SetA.Add(new Mon_Dog());
            cardList_SetA.Add(new Mon_Dog());
            cardList_SetA.Add(new Mon_Dog());
            cardGroupA.GetCardGroup(cardList_SetA);
            //----------------------------------------------------------
            //对方牌组
            List<Card> cardList_SetB = new List<Card>();
            cardList_SetB.Add(new Mon_Bird());
            cardList_SetB.Add(new Mon_Bird());
            cardList_SetB.Add(new Mon_Bird());
            cardList_SetB.Add(new Mon_Cat());
            cardList_SetB.Add(new Mon_Cat());
            cardList_SetB.Add(new Mon_Cat());
            cardList_SetB.Add(new Mon_Dog());
            cardList_SetB.Add(new Mon_Dog());
            cardList_SetB.Add(new Mon_Dog());
            cardList_SetB.Add(new Mon_Dog());
            cardGroupB.GetCardGroup(cardList_SetB);
            //----------------------------------------------------------

            //----------------------------------------------------------
            
            Application.Run(mainFightPlace);
        }
    }
}

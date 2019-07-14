using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndGirls
{
    public class MainPlaceInfo
    {
        public MainFightPlace MainFightPlace { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Player PositivePlayer { get; set; }



        public GameState gameState;
        public enum GameState
        {
            Player1Win,Player2Win,Proccess
        }

        private int Time { get; set; }

        public MainPlaceInfo()
        {
            this.Time = 1;
            this.gameState = GameState.Proccess;
        }

        public void TimePlusOne()
        {
            Time++;
        }

        public GameState GamStateFormMainInfo()
        {

            if (Player1.Hp <= 0)
            {
                this.gameState = GameState.Player2Win;
                return GameState.Player2Win;
            }
            else if(Player2.Hp <= 0)
            {
                this.gameState = GameState.Player1Win;
                return GameState.Player1Win;
            }
            else
            {
                return GameState.Proccess;
            }
        }


        public void Process_GetFiveCard()
        {
            
        }




    }
}

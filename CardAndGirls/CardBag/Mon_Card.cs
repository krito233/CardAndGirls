using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndGirls.CardBag
{
    public class Mon_Card:Card
    {
        public int Att_Set { get; set; }
        public int Def_Set { get; set; }
        public int Level_Set { get; set; }
        public int Att { get; set; }
        public int Def { get; set; }
        public int Level { get; set; }

        public int AttAllow_Set { get; set; }

        public int AttAllow_Rest { get; set; }

        public enum CallResult
        {
            Success,LevelLimited,RequestFail
        }

        public string Description { get; set; }
        public Mon_Card()
        {
            base.Type = CardType.Mon_Card;
            base.State = CardState.State_Att;
            AttAllow_Set = 1;
            AttAllow_Rest = 1;
        }

        public virtual CallResult Call(Player thisPlayer)
        {
            this.Player = thisPlayer;
            if(Level<=4)
            {
                return CallResult.Success;
            }
            else if(Level>4)
            {
                return CallResult.LevelLimited;
            }
            else
            {
                return CallResult.RequestFail;
            }
        }
        public virtual void Attack(Mon_Card enemy)
        {
            if(enemy is Mon_null)
            {
                this.Player.MainPlaceInfo.MainFightPlace.textBox3.Text = "无效目标";
                return;
            }
            if (enemy.State == CardState.State_Att)
            {
                if (enemy.Att < this.Att)
                {
                    this.Player.MainPlaceInfo.MainFightPlace.textBox3.Text = this.Player.Name + this.Name + "击杀了" + this.Player.OpPlayer.Name + "    " + enemy.Name + this.Player.OpPlayer.Name + "HP-" + (this.Att - enemy.Att);
                    Player.OpPlayer.Hp -= (this.Att - enemy.Att);
                    enemy.Die();
                    
                    
                }
                else if (enemy.Att == this.Att)
                {
                    this.Player.MainPlaceInfo.MainFightPlace.textBox3.Text = this.Player.Name + this.Name + "、" + this.Player.OpPlayer.Name + enemy.Name + "同归于尽";
                    enemy.Die();
                    this.Die();
                }
                else
                {
                    this.Player.MainPlaceInfo.MainFightPlace.textBox3.Text = this.Player.Name + this.Name + "被" + this.Player.OpPlayer.Name + enemy.Name + "反杀" + "    " + this.Player.Name + "HP-" + (enemy.Att - this.Att);
                    Player.Hp -= (enemy.Att - this.Att);
                    this.Die();
                }
            }
            else if(enemy.State==CardState.State_Def)
            {
                if(this.Att>enemy.Def)
                {
                    this.Player.MainPlaceInfo.MainFightPlace.textBox3.Text = this.Player.Name + this.Name + "击杀" + this.Player.OpPlayer.Name + enemy.Name+"因其守备状态"+ this.Player.Name+"不受到伤害";
                    enemy.Die();
                }
                else if(this.Att==enemy.Def)
                {
                    this.Player.MainPlaceInfo.MainFightPlace.textBox3.Text = this.Player.Name + this.Name + "与" + this.Player.OpPlayer.Name + enemy.Name + "同归于尽";
                    this.Die();
                    enemy.Die();
                }
                else
                {
                    this.Player.MainPlaceInfo.MainFightPlace.textBox3.Text = this.Player.Name + this.Name + "受到来自"+ this.Player.OpPlayer.Name + enemy.Name+"的反伤，死亡。"+ this.Player.Name+"HP-"+(enemy.Def-this.Att);
                    this.Die();
                    this.Player.Hp -= (enemy.Def - this.Att);
                }
            }
        }

        public virtual void AttackTheOpPlayer()
        {
            this.Player.OpPlayer.Hp -= this.Att;
        }

        public virtual void Defense(Mon_Card enemy)
        {
            this.State = CardState.State_Def;
        }

        public virtual void Event()
        {

        }

        public virtual void Die()
        {
            this.State = Card.CardState.State_InDom;
            int index = Player.mon_Place.place.IndexOf(this);
            Player.mon_Place.place[index] = Player.mon_Place.mon_null;


        }



    }
}

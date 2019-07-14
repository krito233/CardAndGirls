using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardAndGirls.CardBag;
using static CardAndGirls.CardBag.Card;

namespace CardAndGirls
{
    
    public partial class InfoForm : Form
    {    
        public Player Player { get; set; }

        public Card SelectCard = new Card();
        public Mon_Card mc;
        public Mon_Card fromMainMc;
        public Mon_Card fromMonPlaceMc;
        public CardType CardType;

        public InfoForm()
        {
            mc = new Mon_null();
            fromMainMc = new Mon_null();
            InitializeComponent();
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
/// <summary>
/// 卡牌信息框
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void InfoForm_Load(object sender, EventArgs e)
        {
            //位置跟随决斗盘
            if(this.Player == Player.MainPlaceInfo.Player1)
            {
                Point point = this.Player.MainPlaceInfo.MainFightPlace.Location;
                point.X -= this.Width;
                this.Location = point;
                
            }
            else
            {
                Point point = this.Player.MainPlaceInfo.MainFightPlace.Location;
                point.X += this.Player.MainPlaceInfo.MainFightPlace.Width;
                this.Location = point;

            }
            this.Text = Player.Name;
            button1.Hide();
            button2.Hide();
            button3.Hide();
        }

        public void GetInfoFromCardFromHandCard(Card card)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            if(card is Mon_Card)
            {
                mc=(Mon_Card)card;
                this.NameLabel1.Text = mc.Name;
                this.LevelLabel.Text = Levelstar(mc.Level);
                this.DescriptionTextBox.Text = mc.Description;
                this.AttLabel.Text = "ATT: " + mc.Att.ToString();
                this.DefLabel.Text = "DEF: " + mc.Att.ToString();
                this.MonPicBox.Image = mc.cardImage;
                CardType = CardType.Mon_Card;
                button1.Text = "召唤" + mc.Name;
                button1.Show();
                
            }

        }
        public void GetInfoFromCardFromMainPlace(Card card)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            if (card is Mon_Card)
            {
                fromMainMc = (Mon_Card)card;
                this.NameLabel1.Text = fromMainMc.Name+fromMainMc.Stateof();
                this.LevelLabel.Text = Levelstar(fromMainMc.Level);
                this.DescriptionTextBox.Text = fromMainMc.Description;
                this.AttLabel.Text = "ATT: " + fromMainMc.Att.ToString();
                this.DefLabel.Text = "DEF: " + fromMainMc.Att.ToString();
                this.MonPicBox.Image = fromMainMc.cardImage;
            }
        }



        static string Levelstar(int level)
        {
            string s = "";
            for(int i=0;i<level;i++)
            {
                s += "★";
            }
            return s;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(CardType==CardType.Mon_Card)
            {
                if(mc.Call(Player)==Mon_Card.CallResult.Success)
                {
                    if (Player.mon_Place.MonCall(mc) == Mon_Place.CallResult.Success)
                    {                      
                        button1.Hide();
                        this.NameLabel1.Text = "";
                        this.LevelLabel.Text = "";
                        this.DescriptionTextBox.Text = "召唤" + mc.Name + "成功";
                        this.AttLabel.Text = "ATT: " + "";
                        this.DefLabel.Text = "DEF: " + "";
                        this.MonPicBox.Image = Image.FromFile(".\\pic\\pic_called.jpg");
                        Player.HandCardController.OneCardGiveOut(mc);
                        Player.CardGroupForm.Renew();
                    }
                    else if((Player.mon_Place.MonCall(mc) == Mon_Place.CallResult.Full))
                    {
                        this.DescriptionTextBox.Text ="槽位已满";
                    }

                }
            }
        }
        //---------------------------------------------------------------------------------------
        public void FromMonPlaceSelect(Mon_Card mc)
        {
            button1.Hide();
            if (mc is Mon_null)
            {
                this.NameLabel1.Text = mc.Name+mc.Stateof();
                this.LevelLabel.Text = Levelstar(mc.Level);
                this.DescriptionTextBox.Text = mc.Description;
                this.AttLabel.Text = "ATT: " + mc.Att.ToString();
                this.DefLabel.Text = "DEF: " + mc.Att.ToString();
                this.MonPicBox.Image = mc.cardImage;
                button2.Text = mc.Name + " 攻击";
            }
            else
            {
                this.NameLabel1.Text = mc.Name;
                this.LevelLabel.Text = Levelstar(mc.Level);
                this.DescriptionTextBox.Text = mc.Description;
                this.AttLabel.Text = "ATT: " + mc.Att.ToString();
                this.DefLabel.Text = "DEF: " + mc.Att.ToString();
                this.MonPicBox.Image = mc.cardImage;
                button2.Text = mc.Name + " 攻击";
                if (mc.State == CardState.State_Att)
                {
                    button2.Show();//攻击指令
                    button3.Show();
                }
                else
                {
                    button2.Hide();
                    button3.Show();
                }
            }
        }

        //攻击指令拉起一个等待进程
        private void Button2_Click(object sender, EventArgs e)
        {
            if(fromMainMc is Mon_null)
            {
                return;
            }
            AttackChoose attackChoose = new AttackChoose(fromMainMc);
            attackChoose.ShowDialog();
            button2.Hide();//攻击指令
            button3.Hide();
        }



        public void RenewLocation()
        {
            if (this.Player == Player.MainPlaceInfo.Player1)
            {
                Point point = this.Player.MainPlaceInfo.MainFightPlace.Location;
                point.X -= this.Width;
                this.Location = point;

            }
            else
            {
                Point point = this.Player.MainPlaceInfo.MainFightPlace.Location;
                point.X += this.Player.MainPlaceInfo.MainFightPlace.Width;
                this.Location = point;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (fromMainMc.State == CardState.State_Att)
            {
                fromMainMc.State = CardState.State_Def;
                button2.Hide();
            }
            else
            {
                fromMainMc.State = CardState.State_Att;
                button2.Show();
            }
        }
    }
}

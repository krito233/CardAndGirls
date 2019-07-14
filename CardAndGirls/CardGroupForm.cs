using CardAndGirls.CardBag;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardAndGirls
{
    public partial class CardGroupForm : Form
    {
        public Player Player { get; set; }

        List<Card> cardList_Set = new List<Card>();


        BindingSource bs1 = new BindingSource();
        BindingSource bs2 = new BindingSource();

        public CardGroupForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CardGroupForm_Load(object sender, EventArgs e)
        {

            //位置跟随
            if (this.Player == Player.MainPlaceInfo.Player1)
            {
                Point point = this.Player.MainPlaceInfo.MainFightPlace.Location;
                point.X -= this.Width;
                point.Y += this.Player.InfoForm.Height;
                this.Location = point;

            }
            else
            {
                Point point = this.Player.MainPlaceInfo.MainFightPlace.Location;
                point.X += this.Player.MainPlaceInfo.MainFightPlace.Width;
                point.Y += this.Player.InfoForm.Height;
                this.Location = point;

            }

            this.Text = Player.Name;
            listBox1.Hide();


            Player.InfoForm.StartPosition = FormStartPosition.Manual;
            Player.InfoForm.Show();


            bs1.DataSource = Player.CardGroup.cardList;
            listBox1.DataSource = bs1;
            listBox1.DisplayMember = "Name";

            bs2.DataSource = Player.HandCardController.handCard;
            listBox2.DataSource = bs2;
            listBox2.DisplayMember = "Name";
        }


        public void Renew()
        {
            bs2.DataSource = null;
            bs2.DataSource = Player.HandCardController.handCard;
            bs1.DataSource = null;
            bs1.DataSource = Player.CardGroup.cardList;
        }

        private void Random_Click(object sender, EventArgs e)
        {
            bs1.DataSource = null;
            Player.CardGroup.RandomCardList();
            bs1.DataSource = Player.CardGroup.cardList;
        }

        private void GetCard_Click(object sender, EventArgs e)
        {
            Player.HandCardController.FiveCardGet();
            //刷新
            Renew();
        }

        private void GetOne_Click(object sender, EventArgs e)
        {
            Player.HandCardController.OneCardGet();
            //刷新
            Renew();
        }

        private void ListBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Card c = (Card)listBox2.SelectedItem;
            Player.InfoForm.GetInfoFromCardFromHandCard(c);
        }

        public void RenewLocation()
        {
            if (this.Player == Player.MainPlaceInfo.Player1)
            {
                Point point = this.Player.MainPlaceInfo.MainFightPlace.Location;
                point.X -= this.Width;
                point.Y += this.Player.InfoForm.Height;
                this.Location = point;

            }
            else
            {
                Point point = this.Player.MainPlaceInfo.MainFightPlace.Location;
                point.X += this.Player.MainPlaceInfo.MainFightPlace.Width;
                point.Y += this.Player.InfoForm.Height;
                this.Location = point;
            }
        }

    }

}

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
    public partial class MainFightPlace : Form
    {
        public MainPlaceInfo MainPlace_Info { get; set; }

        //--------------------------
        

        

        

        public MainFightPlace()
        {
            InitializeComponent();
            
        }

        private void MainFightPlace_Load(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.CardGroupForm.StartPosition = FormStartPosition.Manual;
            MainPlace_Info.Player2.CardGroupForm.StartPosition = FormStartPosition.Manual;
            MainPlace_Info.Player1.CardGroupForm.Show();
            MainPlace_Info.Player2.CardGroupForm.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            try
            {


                label1.Text = MainPlace_Info.Player1.mon_Place.place[0].Name+ MainPlace_Info.Player1.mon_Place.place[0].Stateof();
                pictureBox1.Image = MainPlace_Info.Player1.mon_Place.place[0].cardImage;
                label2.Text = MainPlace_Info.Player1.mon_Place.place[1].Name + MainPlace_Info.Player1.mon_Place.place[1].Stateof();
                pictureBox2.Image = MainPlace_Info.Player1.mon_Place.place[1].cardImage;
                label3.Text = MainPlace_Info.Player1.mon_Place.place[2].Name + MainPlace_Info.Player1.mon_Place.place[2].Stateof();
                pictureBox3.Image = MainPlace_Info.Player1.mon_Place.place[2].cardImage;
                label4.Text = MainPlace_Info.Player1.mon_Place.place[3].Name + MainPlace_Info.Player1.mon_Place.place[3].Stateof();
                pictureBox4.Image = MainPlace_Info.Player1.mon_Place.place[3].cardImage;
                label5.Text = MainPlace_Info.Player1.mon_Place.place[4].Name + MainPlace_Info.Player1.mon_Place.place[4].Stateof();
                pictureBox5.Image = MainPlace_Info.Player1.mon_Place.place[4].cardImage;

                label6.Text = MainPlace_Info.Player2.mon_Place.place[0].Name + MainPlace_Info.Player2.mon_Place.place[0].Stateof();
                pictureBox6.Image = MainPlace_Info.Player2.mon_Place.place[0].cardImage;
                label7.Text = MainPlace_Info.Player2.mon_Place.place[1].Name + MainPlace_Info.Player2.mon_Place.place[1].Stateof();
                pictureBox7.Image = MainPlace_Info.Player2.mon_Place.place[1].cardImage;
                label8.Text = MainPlace_Info.Player2.mon_Place.place[2].Name + MainPlace_Info.Player2.mon_Place.place[2].Stateof();
                pictureBox8.Image = MainPlace_Info.Player2.mon_Place.place[2].cardImage;
                label9.Text = MainPlace_Info.Player2.mon_Place.place[3].Name + MainPlace_Info.Player2.mon_Place.place[3].Stateof();
                pictureBox9.Image = MainPlace_Info.Player2.mon_Place.place[3].cardImage;
                label10.Text = MainPlace_Info.Player2.mon_Place.place[4].Name + MainPlace_Info.Player2.mon_Place.place[4].Stateof();
                pictureBox10.Image = MainPlace_Info.Player2.mon_Place.place[4].cardImage;

                textBox1.Text = MainPlace_Info.Player1.Name+"\r\nHP:" +MainPlace_Info.Player1.Hp;
                textBox2.Text = MainPlace_Info.Player2.Name + "\r\nHP:" + MainPlace_Info.Player2.Hp;

                if (MainPlace_Info.GamStateFormMainInfo()==MainPlaceInfo.GameState.Player1Win)
                { 
                    WinForm winf = new WinForm(this);
                    winf.label1.Text = MainPlace_Info.Player1.Name + "    Win!!!~";
                    timer1.Enabled = false;
                    winf.ShowDialog();
                }
                if (MainPlace_Info.GamStateFormMainInfo() == MainPlaceInfo.GameState.Player2Win)
                {
                    WinForm winf = new WinForm(this);
                    winf.label1.Text = MainPlace_Info.Player2.Name + "    Win!!!~";
                    timer1.Enabled = false;
                    winf.ShowDialog();
                }
            }
            finally
            {

            }
            
            
        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player1.mon_Place.place[0]);
            MainPlace_Info.Player2.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player1.mon_Place.place[0]); 
        }

        private void PictureBox2_MouseHover(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player1.mon_Place.place[1]);
            MainPlace_Info.Player2.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player1.mon_Place.place[1]);
        }

        private void PictureBox3_MouseHover(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player1.mon_Place.place[2]);
            MainPlace_Info.Player2.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player1.mon_Place.place[2]);
        }

        private void PictureBox4_MouseHover(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player1.mon_Place.place[3]);
            MainPlace_Info.Player2.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player1.mon_Place.place[3]);
        }

        private void PictureBox5_MouseHover(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player1.mon_Place.place[4]);
            MainPlace_Info.Player2.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player1.mon_Place.place[4]);
        }

        private void PictureBox6_MouseHover(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player2.mon_Place.place[0]);
            MainPlace_Info.Player2.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player2.mon_Place.place[0]);
        }

        private void PictureBox7_MouseHover(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player2.mon_Place.place[1]);
            MainPlace_Info.Player2.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player2.mon_Place.place[1]);
        }

        private void PictureBox8_MouseHover(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player2.mon_Place.place[2]);
            MainPlace_Info.Player2.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player2.mon_Place.place[2]);
        }

        private void PictureBox9_MouseHover(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player2.mon_Place.place[3]);
            MainPlace_Info.Player2.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player2.mon_Place.place[3]);
        }

        private void PictureBox10_MouseHover(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player2.mon_Place.place[4]);
            MainPlace_Info.Player2.InfoForm.GetInfoFromCardFromMainPlace(MainPlace_Info.Player2.mon_Place.place[4]);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.FromMonPlaceSelect(MainPlace_Info.Player1.mon_Place.place[0]);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.FromMonPlaceSelect(MainPlace_Info.Player1.mon_Place.place[1]);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.FromMonPlaceSelect(MainPlace_Info.Player1.mon_Place.place[2]);
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.FromMonPlaceSelect(MainPlace_Info.Player1.mon_Place.place[3]);
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.FromMonPlaceSelect(MainPlace_Info.Player1.mon_Place.place[4]);
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            MainPlace_Info.Player2.InfoForm.FromMonPlaceSelect(MainPlace_Info.Player2.mon_Place.place[0]);
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            MainPlace_Info.Player2.InfoForm.FromMonPlaceSelect(MainPlace_Info.Player2.mon_Place.place[1]);
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            MainPlace_Info.Player2.InfoForm.FromMonPlaceSelect(MainPlace_Info.Player2.mon_Place.place[2]);
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            MainPlace_Info.Player2.InfoForm.FromMonPlaceSelect(MainPlace_Info.Player2.mon_Place.place[3]);
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            MainPlace_Info.Player2.InfoForm.FromMonPlaceSelect(MainPlace_Info.Player2.mon_Place.place[4]);
        }

        private void MainFightPlace_LocationChanged(object sender, EventArgs e)
        {
            MainPlace_Info.Player1.InfoForm.RenewLocation();
            MainPlace_Info.Player2.InfoForm.RenewLocation();
            MainPlace_Info.Player1.CardGroupForm.RenewLocation();
            MainPlace_Info.Player2.CardGroupForm.RenewLocation();
        }
    }
}

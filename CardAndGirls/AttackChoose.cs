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
    public partial class AttackChoose : Form
    {
        Player player;
        BindingSource bs=new BindingSource();
        Mon_Card attackFromMc;
        public AttackChoose(Mon_Card attackFromMc)
        {
            this.player = attackFromMc.Player;
            this.attackFromMc = attackFromMc;
            InitializeComponent();
        }

        private void FileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void AttackChoose_Load(object sender, EventArgs e)
        {
            button3.Hide();
            bs.DataSource = player.OpPlayer.mon_Place.place;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "Name";
            bool isnull = true;
            for (int i = 0; i < 5; i++)
            {
                if (listBox1.Items[i] is Mon_null)
                {
                    isnull = true;
                }
                else
                {
                    isnull = false;
                }
            }
            if (isnull)
            {
                button3.Show();
            }

        }

        //双击列表进行攻击
        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                Mon_Card attackAim = (Mon_Card)listBox1.SelectedItem;
                attackFromMc.Attack(attackAim);
                this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Mon_Card attackAim = (Mon_Card)listBox1.SelectedItem;
            attackFromMc.Attack(attackAim);
            this.Close();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AttackChoose_Deactivate(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            attackFromMc.AttackTheOpPlayer();
            this.Close();
        }
    }
}

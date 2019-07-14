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
    public partial class WinForm : Form
    {
        MainFightPlace m;
        public WinForm(MainFightPlace m)
        {
            this.m = m;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            m.Close();
            this.Close();
        }
    }
}

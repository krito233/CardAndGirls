using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardAndGirls.CardBag
{
    public class Mon_null:Mon_Card
    {
        public Mon_null()
        {
            base.Name = "";
            base.Att = base.Att_Set =0;
            base.Def = base.Def_Set = 0;
            base.Level = base.Level_Set = 0;
            base.Description = "";
            base.cardImage = Image.FromFile(".\\pic\\pic_null.jpg");
            base.State = CardState.State_InDom;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndGirls.CardBag
{
    public class Mon_Bird:Mon_Card
    {
        public Mon_Bird()
        {
            base.Name = "Bird";
            base.Att = base.Att_Set = 400;
            base.Def = base.Def_Set = 500;
            base.Level = base.Level_Set = 3;
            base.Description = "this is a Bird";
            base.cardImage = Image.FromFile(".\\pic\\pic_bird.jpg");
        }
    }
}

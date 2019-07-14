using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndGirls.CardBag
{
    public class Mon_Cat:Mon_Card
    {

        public Mon_Cat()
        {
            base.Name = "Cat";
            base.Att = base.Att_Set = 300;
            base.Def = base.Def_Set = 300;
            base.Level = base.Level_Set = 3;
            base.Description ="this is a Cat";
            base.cardImage = Image.FromFile(".\\pic\\pic_cat.jpg");
        }

    }
}

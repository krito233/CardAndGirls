﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndGirls.CardBag
{
    public class Mon_Dog:Mon_Card
    {
        public Mon_Dog()
        {
            base.Name = "Dog";
            base.Att = base.Att_Set = 300;
            base.Def = base.Def_Set = 300;
            base.Level = base.Level_Set = 4;
            base.Description ="this is a Dog";
            base.cardImage = Image.FromFile(".\\pic\\pic_dog.jpg");
        }

    }
}

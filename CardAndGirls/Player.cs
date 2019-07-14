using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndGirls
{
    public class Player
    {
        public int Hp { get; set; }
        public string Name { get; set; }
        public Mon_Place mon_Place = new Mon_Place();


        public MainPlaceInfo MainPlaceInfo { get; set; }
        public CardGroup CardGroup { get; set; }
        public HandCardController HandCardController { get; set; }
        public Grave Grave { get; set; }
        public Info Info { get; set; }

        public CardGroupForm CardGroupForm{get;set;}
        public InfoForm InfoForm { get; set; }
        public Player OpPlayer { get; set; }
          



        //-----------------------------
        

        public Player()
        {

        }
        public Player(string name)
        {
            
            Name = name;
            Hp = 4000;
        }
    }
}

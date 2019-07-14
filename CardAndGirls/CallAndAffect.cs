using CardAndGirls.CardBag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndGirls
{
    public class CallAndAffect
    {
        public Mon_Card mc;
        public CallAndAffect()
        {

        }
        public void GetOneCard(Card inputCard)
        {
            if(inputCard is Mon_Card)
            {
                mc = (Mon_Card)inputCard;
            }
        }




    }
}

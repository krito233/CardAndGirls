using CardAndGirls.CardBag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardAndGirls
{
    public class Mon_Place
    {
        public List<Mon_Card> place;
        public enum CallResult
        {
            Success,Full
        }
        public Mon_null mon_null = new Mon_null();
        public Mon_Place()
        {
            place = new List<Mon_Card>(5);
            place.Add(mon_null);
            place.Add(mon_null);
            place.Add(mon_null);
            place.Add(mon_null);
            place.Add(mon_null);
        }
        
        public CallResult MonCall(Mon_Card mc)
        {
            if(place.Contains(mon_null))
            {
                int index = place.IndexOf(mon_null);
                place[index] = mc;
                mc.State = Card.CardState.State_Att;
                return CallResult.Success;
            }
            else
            {
                return CallResult.Full;
            }
        }

    }
}

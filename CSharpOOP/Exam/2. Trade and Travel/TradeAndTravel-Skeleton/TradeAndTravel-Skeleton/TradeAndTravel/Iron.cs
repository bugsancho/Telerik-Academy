using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class Iron : Item
    {
        const int IronDefaultValue = 3;
         public Iron(string name, Location location) : base(name, Iron.IronDefaultValue, ItemType.Iron, location)
        {
        }
    }
}

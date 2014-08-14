using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class Wood : Item
    {
        const int WeaponDefaultValue = 2;
        public Wood(string name, Location location) : base(name, Wood.WeaponDefaultValue, ItemType.Wood, location)
        {

        }
        
        public override void UpdateWithInteraction(string interaction)
        {
            base.UpdateWithInteraction(interaction);
            if (interaction == "drop")
            {
                if (this.Value > 0)
                {
                    this.Value--;
                }
            }

        }
    }
}

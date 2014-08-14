using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class Weapon : Item
    {
        private const int WeaponDefaultValue = 10;
        public Weapon(string name, Location location)
            : base(name, Weapon.WeaponDefaultValue, ItemType.Weapon, location)
        {
        }
    }
}

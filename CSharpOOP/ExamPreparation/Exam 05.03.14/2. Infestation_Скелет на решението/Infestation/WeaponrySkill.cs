using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class WeaponrySkill : ISupplement
    {
        protected const int DefaultEffectStrength = 0;

        public void ReactTo(ISupplement otherSupplement)
        {

        }

        public int PowerEffect
        {
            get
            {
                return WeaponrySkill.DefaultEffectStrength;
            }
        }

        public int HealthEffect
        {
            get
            {
                return WeaponrySkill.DefaultEffectStrength;
            }
        }

        public int AggressionEffect
        {
            get
            {
                return WeaponrySkill.DefaultEffectStrength;
            }
        }
    }
}

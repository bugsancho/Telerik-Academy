using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Weapon : ISupplement
    {
        public const int DefaultEffectStrength = 0;

        private int aggressionEffect;
        private int healthEffect;
        private int powerEffect;

        public Weapon()
        {
            this.AggressionEffect = Weapon.DefaultEffectStrength;
            this.HealthEffect = Weapon.DefaultEffectStrength;
            this.PowerEffect = Weapon.DefaultEffectStrength;
        }

        public int PowerEffect
        {
            get { return this.powerEffect; }
            protected set { this.powerEffect = value; }
        }

        public int HealthEffect
        {
            get { return this.healthEffect; }
            protected set { this.healthEffect = value; }
        }

        public int AggressionEffect
        {
            get { return this.aggressionEffect; }
            protected set { this.aggressionEffect = value; }
        }



        public void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.PowerEffect = 10;
                this.AggressionEffect = 3;
            }
        }
    }
}

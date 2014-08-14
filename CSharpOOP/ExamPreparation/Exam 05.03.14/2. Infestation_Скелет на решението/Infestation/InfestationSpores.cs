using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class InfestationSpores : ISupplement
    {
        public const int DefaultEffectStrength = 0;
        public const int DefaultAggressionEffect = 20;
        public const int DefaultPowerEffect = -1;

        private int aggressionEffect;
        private int healthEffect;
        private int powerEffect;

        public InfestationSpores()
        {
            this.AggressionEffect = InfestationSpores.DefaultAggressionEffect;
            this.HealthEffect = InfestationSpores.DefaultEffectStrength;
            this.PowerEffect = InfestationSpores.DefaultPowerEffect;
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
            if (otherSupplement is InfestationSpores)
            {
                this.PowerEffect = DefaultEffectStrength;
                this.AggressionEffect = DefaultEffectStrength;
            }
        }
    }
}

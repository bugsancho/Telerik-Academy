using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public abstract class Catalyst : ISupplement
    {
        protected const int BoostedEffectStrength = 3;
        protected const int DefaultEffectStrength = 0;

        public virtual void ReactTo(ISupplement otherSupplement)
        {

        }

        public virtual int PowerEffect
        {
            get
            {
                return DefaultEffectStrength;
            }
        }

        public virtual int HealthEffect
        {
            get
            {
                return DefaultEffectStrength;
            }
        }

        public virtual int AggressionEffect
        {
            get
            {
                return DefaultEffectStrength;
            }
        }
    }
}

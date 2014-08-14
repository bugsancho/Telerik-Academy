using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Parasite : Unit    
    {
        public const int DefaultBaseValue = 1;
        public Parasite(string id)
            : base(id, UnitClassification.Biological, Parasite.DefaultBaseValue, Parasite.DefaultBaseValue, Parasite.DefaultBaseValue)
        {
        }
        protected override bool CanAttackUnit(UnitInfo unit)
        {
            if (unit.Id == this.Id)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            return attackableUnits.OrderBy(x => x.Health).FirstOrDefault();
        }
        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            var optimalTarget = this.GetOptimalAttackableUnit(units.Where(unit => this.CanAttackUnit(unit)));
            var requiredTypeForInfestation = InfestationRequirements.RequiredClassificationToInfest(optimalTarget.UnitClassification);

            if (optimalTarget.Id != null && requiredTypeForInfestation == this.UnitClassification)
            {
                return new Interaction(new UnitInfo(this), optimalTarget, InteractionType.Infest);
            }
            return Interaction.PassiveInteraction;
        }

    }
}

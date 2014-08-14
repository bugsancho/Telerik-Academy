using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Queen : Unit
    {
        public const int DefaultBaseValue = 1;
        public const int QueenDefaultHealth = 30;
        public const UnitClassification QueenType = UnitClassification.Psionic;
        public Queen(string id)
            : base(id, Queen.QueenType, Queen.QueenDefaultHealth, Queen.DefaultBaseValue, Queen.DefaultBaseValue)
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
            return attackableUnits.OrderByDescending(x => x.Health).FirstOrDefault();
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

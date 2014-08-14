using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    using WarMachines.Interfaces;

    public class WarTank : WarMachine, ITank
    {
        private bool defenseMode;
        public bool DefenseMode
        {
            get { return this.defenseMode; }
            private set { this.defenseMode = value; }
        }


        public WarTank(string name, double attackPoints, double defensePoints) : base(name, attackPoints, defensePoints)
        {
            this.DefenseMode = false;
            ToggleDefenseMode();
            this.HealthPoints = 100;
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefenseMode = false;
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }
            else
            {
                this.DefenseMode = true;
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
        }
        public override string ToString()
        {
            var info = new StringBuilder();
            info.AppendFormat("- {0}\n", this.Name);
            info.AppendLine(" *Type: Tank");
            info.Append(base.ToString());
            info.Append(" *Defense: ");
            if (this.DefenseMode)
            {
                info.Append("ON");
            }
            else
            {
                info.Append("OFF");
            }
            info.AppendLine();
            return info.ToString();
        }
    }
}

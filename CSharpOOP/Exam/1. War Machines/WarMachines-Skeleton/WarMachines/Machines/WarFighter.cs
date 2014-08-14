using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    using WarMachines.Interfaces;

    public class WarFighter : WarMachine, IFighter
    {
        private bool stealthMode;

        public WarFighter(string name, double attackPoints, double defensePoints, bool stealthMode) : base(name, attackPoints, defensePoints)
        {
            this.StealthMode = stealthMode;
            this.HealthPoints = 200;
        }

        public bool StealthMode
        {
            get { return this.stealthMode; }
            set { this.stealthMode = value; }
        }
      
        public void ToggleStealthMode()
        {
            if (this.StealthMode)
            {
                this.StealthMode = false;
            }
            else
            {
                this.StealthMode = true;
            }
        }
         public override string ToString()
        {
            var info = new StringBuilder();
            info.AppendFormat("- {0}\n", this.Name);
            info.AppendLine(" *Type: Fighter");
            info.Append(base.ToString());
            info.Append(" *Stealth: ");
            if (this.StealthMode)
            {
                info.Append("ON");
            }
            else
            {
                info.Append("OFF");
            }
            return info.ToString();
        }
    }
}

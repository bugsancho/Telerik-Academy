using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    using WarMachines.Interfaces;

    public abstract class WarMachine : IMachine
    {
        protected string name;
        protected IPilot pilot;
        protected double healthPoints;
        protected double attackPoints;
        protected double defensePoints;
        protected IList<string> targets;

        public WarMachine(string name, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.Targets = new List<string>();
        }

        public IList<string> Targets
        {
            get
            {
                return this.targets;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.targets = value;
            }
        }

        public double DefensePoints
        {
            get { return this.defensePoints; }
            protected set { this.defensePoints = value; }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }
            protected set { this.attackPoints = value; }
        }


        public double HealthPoints
        {
            get { return this.healthPoints; }
            set { this.healthPoints = value; }
        }


        public IPilot Pilot
        {
            get { return this.pilot; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.pilot = value;
                }
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {

                    this.name = value;
                }
            }
        }


        public void Attack(string target)
        {
            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentNullException();
            }
            else
            {
                this.Targets.Add(target);
            }
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            info.AppendFormat(" *Health: {0}\n", this.HealthPoints);
            info.AppendFormat(" *Attack: {0}\n", this.AttackPoints);
            info.AppendFormat(" *Defense: {0}\n", this.DefensePoints);
            info.Append(" *Targets: ");
            if (this.Targets.Count == 0)
            {
                info.AppendLine("None");
            }
            else
            {
                foreach (var target in this.Targets)
                {
                    info.AppendFormat("{0}, ", target);
                }
                info.Length -= 2;
                info.AppendLine();
            }
            return info.ToString();
        }
    }
}

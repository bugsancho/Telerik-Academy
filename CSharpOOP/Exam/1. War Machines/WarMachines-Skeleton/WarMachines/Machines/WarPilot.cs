namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using WarMachines.Interfaces;

    public class WarPilot : IPilot
    {
        public WarPilot(string name)
        {
            this.Name = name;
            this.ControlledMachines = new List<IMachine>();
        }

        private string name;
        private ICollection<IMachine> ControlledMachines {get; set;}

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pilot's name cannot be null or empty!");
                }
                else
                {
                    this.name = value;
                }
            }
        }


        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException("Cannot add a non-existing member");
            }
            else
            {
                this.ControlledMachines.Add(machine);
            }
        }

        public string Report()
        {
            var info = new StringBuilder();
            info.AppendFormat("{0} - ", this.Name);
            switch (this.ControlledMachines.Count)
            {
                case 0: info.Append("no machines"); break;
                case 1: info.Append("1 machine\n"); break;
                default: info.AppendFormat("{0} machines\n", this.ControlledMachines.Count); break;
            }

            var orderedMachines = this.ControlledMachines.OrderBy(t => t.HealthPoints).ThenBy(t => t.Name);

            foreach (var machine in orderedMachines)
            {
                info.Append(machine.ToString());
            }
            return info.ToString();
        }
    }
}

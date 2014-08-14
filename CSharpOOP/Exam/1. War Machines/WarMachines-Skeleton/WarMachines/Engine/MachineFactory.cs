namespace WarMachines.Engine
{
    using WarMachines.Interfaces;
    using WarMachines.Machines;

    public class MachineFactory : IMachineFactory
    {
        public IPilot HirePilot(string name)
        {
            return new WarPilot(name);
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            return new WarTank(name, attackPoints, defensePoints);
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            return new WarFighter(name, attackPoints, defensePoints, stealthMode);
        }
    }
}

namespace ComputersSystem.Computers
{
    using Motherboards;
    using ProccessingUnit;
    using StorageDevices;

    public abstract class Computer : IComputer
    {
        private ICpu cpu;
        private IMotherboard motherboard;
        private IHardDrive drive;

        protected Computer(ICpu cpu, IMotherboard motherboard, IHardDrive drive)
        {
            this.Cpu = cpu;
            this.motherboard = motherboard;
            this.Drive = drive;
        }

        public ICpu Cpu
        {
            get
            {
                return this.cpu;
            }

            protected set
            {
                this.cpu = value;
            }
        }

        public IMotherboard Motherboard
        {
            get
            {
                return this.motherboard;
            }

            protected set
            {
                this.motherboard = value;
            }
        }

        public IHardDrive Drive
        {
            get
            {
                return this.drive;
            }

            protected set
            {
                this.drive = value;
            }
        }
    }
}
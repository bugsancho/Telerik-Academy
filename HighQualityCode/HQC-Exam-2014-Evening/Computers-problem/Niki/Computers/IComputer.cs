namespace ComputersSystem.Computers
{
    using Motherboards;
    using ProccessingUnit;
    using StorageDevices;

    public interface IComputer
    {
        ICpu Cpu { get; }

        IMotherboard Motherboard { get; }

        IHardDrive Drive { get; }
    }
}
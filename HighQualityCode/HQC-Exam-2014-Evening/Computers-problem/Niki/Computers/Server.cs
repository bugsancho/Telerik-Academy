namespace ComputersSystem.Computers
{
    using Motherboards;
    using ProccessingUnit;
    using StorageDevices;

    public class Server : Computer, IServer
    {
        public Server(ICpu cpu, IMotherboard motherboard, IHardDrive drive) : base(cpu, motherboard, drive)
        {
        }

        public void ProccessNumber(int number)
        {
            this.Motherboard.SaveRamValue(number);
            this.Cpu.PrintSquareOfNumberFromRam();
        }
    }
}
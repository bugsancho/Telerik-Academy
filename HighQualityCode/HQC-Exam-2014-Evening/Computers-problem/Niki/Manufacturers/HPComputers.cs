namespace ComputersSystem.Manufacturers
{
    using Batteries;
    using Computers;
    using Motherboards;
    using OperationMemory;
    using ProccessingUnit;
    using RenderingDevices;
    using StorageDevices;

    public class HPComputers : IManufacturer
    {
        // TODO introduce constants
        public IPersonalComputer CreatePersonalComputer()
        {
            IRam ram = new Ram(2);
            IVideoCard videoCard = new ColorfullVideoCard();
            IMotherboard board = new MotherBoard(videoCard, ram);
            ICpu cpu = new Cpu32Bit(2, board);
            IHardDrive hardDrive = new HardDrive(500);

            IPersonalComputer computer = new PersonalComputer(cpu, board, hardDrive);
            return computer;
        }

        public ILaptop CreateLaptop()
        {
            IRam ram = new Ram(4);
            IVideoCard videoCard = new ColorfullVideoCard();
            IMotherboard board = new MotherBoard(videoCard, ram);
            ICpu cpu = new Cpu64Bit(2, board);
            IHardDrive hardDrive = new HardDrive(500);
            IBattery battery = new LaptopBattery();

            ILaptop computer = new Laptop(cpu, board, hardDrive, battery);
            return computer;
        }

        public IServer CreateServer()
        {
            // TODO fix server null videocard
            IRam ram = new Ram(32);
            IVideoCard videoCard = new MonochromeVideoCard();
            IMotherboard board = new MotherBoard(videoCard, ram);
            ICpu cpu = new Cpu32Bit(4, board);
            IHardDriveArray driveArray = new HardDriveRaidArray();
            IHardDrive firstDrive = new HardDrive(1000);
            IHardDrive secondDrive = new HardDrive(1000);
            driveArray.AddDrive(firstDrive);
            driveArray.AddDrive(secondDrive);

            IServer server = new Server(cpu, board, driveArray);
            return server;
        }
    }
}
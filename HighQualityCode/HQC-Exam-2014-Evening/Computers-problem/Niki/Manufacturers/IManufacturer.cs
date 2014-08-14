namespace ComputersSystem.Manufacturers
{
    using Computers;

    public interface IManufacturer
    {
        IPersonalComputer CreatePersonalComputer();

        ILaptop CreateLaptop();

        IServer CreateServer();
    }
}
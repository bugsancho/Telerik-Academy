namespace ComputersSystem.Computers
{
    using Batteries;

    public interface ILaptop : IComputer
    {
        IBattery Battery { get; }

        void Charge(int percentage);
    }
}
namespace ComputersSystem.Batteries
{
    public interface IBattery
    {
        int PowerLeftPercentage { get; }

        void Charge(int percentage);
    }
}
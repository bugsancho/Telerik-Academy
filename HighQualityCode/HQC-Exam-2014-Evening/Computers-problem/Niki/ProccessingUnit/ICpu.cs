namespace ComputersSystem.ProccessingUnit
{
    public interface ICpu
    {
        int NumberOfCores { get; }

        void SaveRandomNumberToRam(int lowerBound, int upperBound);

        void PrintSquareOfNumberFromRam();
    }
}
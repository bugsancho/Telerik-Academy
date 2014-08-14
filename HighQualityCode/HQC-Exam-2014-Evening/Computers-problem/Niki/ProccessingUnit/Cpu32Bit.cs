namespace ComputersSystem.ProccessingUnit
{
    using System;
    using Motherboards;

    public class Cpu32Bit : CpuBase
    {
        private const int SquareCalculationUpperBound = 500;
        
        public Cpu32Bit(int numberOfCores, IMotherboard motherBoard) : base(numberOfCores, motherBoard)
        {
        }

        protected override int MaxNumberForSquareCalculation
        {
            get
            {
                return Cpu32Bit.SquareCalculationUpperBound;
            }
        }
    }
}
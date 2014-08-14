namespace ComputersSystem.ProccessingUnit
{
    using System;
    using Motherboards;

    public class Cpu64Bit : CpuBase
    {
        private const int SquareCalculationUpperBound = 1000;
        
        public Cpu64Bit(int numberOfCores, IMotherboard motherBoard) : base(numberOfCores, motherBoard)
        {
        }

        protected override int MaxNumberForSquareCalculation
        {
            get
            {
                return Cpu64Bit.SquareCalculationUpperBound;
            }
        }
    }
}
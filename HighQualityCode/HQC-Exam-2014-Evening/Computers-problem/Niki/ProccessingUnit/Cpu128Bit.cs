namespace ComputersSystem.ProccessingUnit
{
    using System;
    using Motherboards;

    public class Cpu128Bit : CpuBase
    {
        private const int SquareCalculationUpperBound = 2000;
        
        public Cpu128Bit(int numberOfCores, IMotherboard motherBoard) : base(numberOfCores, motherBoard)
        {
        }

        protected override int MaxNumberForSquareCalculation
        {
            get
            {
                return Cpu128Bit.SquareCalculationUpperBound;
            }
        }
    }
}
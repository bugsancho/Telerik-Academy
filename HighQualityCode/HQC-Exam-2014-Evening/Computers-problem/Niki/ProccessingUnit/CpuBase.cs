namespace ComputersSystem.ProccessingUnit
{
    using System;
    using Motherboards;

    public abstract class CpuBase : ICpu
    {
        private const string SquareCalculationMessageTemplate = "Square of {0} is {1}.";
        private readonly Random randomNumberGenerator;
        private int numberOfCores;
        private IMotherboard motherBoard;

        // TODO Fix random number generation
        public CpuBase(int numberOfCores, IMotherboard motherBoard)
        {
            this.NumberOfCores = numberOfCores;
            this.motherBoard = motherBoard;
            this.randomNumberGenerator = new Random();
        }

        public int NumberOfCores
        {
            get
            {
                return this.numberOfCores;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new InvalidArgumentException("CPU cannot have zero or less cores!");
                }

                this.numberOfCores = value;
            }
        }

        protected abstract int MaxNumberForSquareCalculation { get; }

        public void SaveRandomNumberToRam(int lowerBound, int upperBound)
        {
            int randomNumber = this.GenerateRandomNumber(lowerBound, upperBound);
            this.motherBoard.SaveRamValue(randomNumber);
        }

        public void PrintSquareOfNumberFromRam()
        {
            int numberFromRam = this.motherBoard.LoadRamValue();
            int squareOfNumber;
            try
            {
                squareOfNumber = this.CalculateSquareOfNumber(numberFromRam);
                this.motherBoard.SaveRamValue(squareOfNumber);
                this.motherBoard.DrawOnVideoCard(string.Format(CpuBase.SquareCalculationMessageTemplate, numberFromRam, squareOfNumber));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                this.motherBoard.DrawOnVideoCard(ex.ParamName);
            }
        }

        protected int CalculateSquareOfNumber(int number)
        {
            if (number > this.MaxNumberForSquareCalculation)
            {
                throw new ArgumentOutOfRangeException("Number too high!");
            }

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Number too low!");
            }

            int squareOfNumber = number * number;
            return squareOfNumber;
        }

        private int GenerateRandomNumber(int lowerBound, int upperBound)
        {
            int randomNumber = this.randomNumberGenerator.Next(lowerBound, upperBound);
            return randomNumber;
        }
    }
}
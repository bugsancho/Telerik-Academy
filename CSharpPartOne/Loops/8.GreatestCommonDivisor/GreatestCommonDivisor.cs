using System;
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive integer number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another positive integer number");
            int secondNumber = int.Parse(Console.ReadLine());

            int minNumber = Math.Min(firstNumber, secondNumber);

            while (!((firstNumber % minNumber == 0) && (secondNumber % minNumber == 0)))
            {
                minNumber--;
            }
            Console.WriteLine("The greatest common divisor of {0} and {1} is {2}!", firstNumber, secondNumber, minNumber);
        }
    }

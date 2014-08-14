using System;
using System.Numerics;
    class FactorialCalculation
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number from 0 to 100:");
            int number = int.Parse(Console.ReadLine());
            GetFactorial(number);
        }
 
        private static void GetFactorial(int number)
        {
            BigInteger factorial = 1;
 
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
 
            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }

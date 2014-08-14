using System;
using System.Numerics;
class TribonacciNumbers
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdNumber = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            BigInteger nextNumber = 0;
            if (n == 1)
            {
                Console.WriteLine(firstNumber);
            }
            if (n == 2)
            {
                Console.WriteLine(secondNumber);
            }
            if (n == 3)
            {
                Console.WriteLine(thirdNumber);
            }
            else
            {
                for (int i = 3; i < n; i++)
                {
                    nextNumber = firstNumber + secondNumber + thirdNumber;
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = nextNumber;
                }
                Console.WriteLine(nextNumber);
            }
        }
    }


using System;
using System.Numerics;
    class NFibonacciNumbers
    {
        //Write a program that reads a number N and calculates the sum of 
        //the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, …

        static void Main()
        {
            Console.WriteLine("Please enter a positive integer number:");
            BigInteger numberCount = BigInteger.Parse(Console.ReadLine());
            BigInteger firstNumber = 0;
            BigInteger secondNumber = 1;
            BigInteger nextNumber = 0;
            Console.WriteLine("The first {0} Fibonacci numbers are: ",numberCount);
            for (int i = 0; i < numberCount; i++)
            {
                nextNumber = firstNumber + secondNumber; //Calculates the next number,
                firstNumber = secondNumber;              // then moves the numbers 
                secondNumber = nextNumber;               // one position ahead 
                Console.Write("{0} ",nextNumber);        // and prints every number.
            }
        }
    }


using System;
using System.Numerics;
class NAndXEquation
    {
        //Write a program that, for a given two integer numbers N and X, 
        // calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

        static void Main()
        {
            Console.WriteLine("Please enter a positive integer number:");
            Console.Write("N = ");
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another positive integer number:");
            Console.Write("X = ");
            BigInteger X = BigInteger.Parse(Console.ReadLine());
            BigInteger xResult = 1;
            BigInteger nFactorial = 1;
            BigInteger sum = 1;
            for (int i = 1; i <= N; i++)
            {
                nFactorial *= i;        //Calculates both sides individually
                xResult *= X;           // and then saves the result in the 'sum' variable
                sum += (nFactorial / xResult);
            }
            Console.WriteLine("The result of the equation is: {0:0.00}!",sum);
        }
    }


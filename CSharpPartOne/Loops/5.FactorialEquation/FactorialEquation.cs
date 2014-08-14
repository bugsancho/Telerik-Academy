using System;
class FactorialEquation
    {
        //Write a program that calculates N!*K! / (K-N)! 
        // for given N and K (1<N<K).

        static void Main()
        {
            Console.WriteLine("Please enter a positive integer number:");
            Console.Write("N = ");
            decimal N = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a greater positive integer number:");
            Console.Write("K = ");
            decimal K = decimal.Parse(Console.ReadLine());
            decimal nFactorial = 1;
            decimal kFactorial = 1;
            decimal kMinusNFactorial = 1;
            for (decimal i = 1; i <= N; i++)
            {                                   //Calculating all the factorials
                nFactorial *= i;                // individually and then the given equation.
            }
            for (decimal i = 1; i <= K; i++)
            {
                kFactorial *= i;
            }
            for (decimal i = 1; i <= (K-N); i++)
            {
                kMinusNFactorial *= i;
            }
            decimal result = (nFactorial * kFactorial) / kMinusNFactorial;
            Console.WriteLine("The result of ({0}! * {1}!)/({1} - {0})! = {2}",
                N,K, result);
        }
    }


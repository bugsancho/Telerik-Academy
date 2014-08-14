using System;
    class FactorialDivision
    {
       // Write a program that calculates N!/K! for given N and K (1<K<N).

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive integer number:");
            Console.Write("N = ");           
            decimal N = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a smaller positive integer number:");
            Console.Write("K = ");
            decimal K = decimal.Parse(Console.ReadLine());            
            decimal result = 1;
            for (decimal i = N; i > K; i--)  //Making use of the fact that K!/K! = 1, 
            {                                // and calculating only the numbers from N to K
                result *= i;
            }
            Console.WriteLine("The result of {0}!/{1}! is {2}",N,K,result);
        }
    }


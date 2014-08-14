using System;
class NNumbersNotDivisableByThreeAndSeven
    {
    // Write a program that prints all the numbers from 1 to N, 
    //that are not divisible by 3 and 7 at the same time.

        static void Main()
        {
            Console.WriteLine("Please enter a positive integer number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)          //writes all numbers
            {
                if (i % 3 == 0 && i % 7 == 0)     //except those divisable by 3 and 7
                {
                    continue;
                }                
                    Console.Write("{0} ", i);               
            }
            Console.WriteLine();
        }
    }


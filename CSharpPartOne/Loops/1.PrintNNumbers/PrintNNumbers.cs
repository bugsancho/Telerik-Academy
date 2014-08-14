using System;
    class PrintNNumbers
    {
        //Write a program that prints all the numbers from 1 to N.

        static void Main()
        {
            Console.WriteLine("Please enter a positive integer number");
            int n = int.Parse(Console.ReadLine()); 
            for (int i = 1; i <= n; i++)  
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }


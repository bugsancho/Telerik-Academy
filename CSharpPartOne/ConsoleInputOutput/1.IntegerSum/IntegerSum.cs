using System;
    class IntegerSum
    {
        //Write a program that reads 3 integer numbers from the console and prints their sum.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter yet another number: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
        }

     }



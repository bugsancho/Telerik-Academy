using System;
    class Program
    {
        //Write a program that reads two positive integer numbers and prints how many numbers p exist between them.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number you want to devide with:");
            int c = int.Parse(Console.ReadLine());
            int result = Math.Abs((a / c) - (b / c));
            Console.WriteLine("The numbers between {0} and {1}, that can be devided by {2} are {3}!",a,b,c,result);
        }
    }


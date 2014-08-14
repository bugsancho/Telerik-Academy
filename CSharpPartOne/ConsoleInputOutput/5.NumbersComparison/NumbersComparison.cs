using System;
    class NumbersComparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The greater number of {0} and {1} is {2}!", a,b,Math.Max(a,b));
        }
        
    }


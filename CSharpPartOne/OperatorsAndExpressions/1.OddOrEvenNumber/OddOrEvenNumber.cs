using System;
    class OddOrEvenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 1 ? "The number is odd!" : "The number is even!");
        }
    }


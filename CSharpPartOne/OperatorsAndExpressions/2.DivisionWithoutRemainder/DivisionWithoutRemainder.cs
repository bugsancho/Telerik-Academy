using System;
    class DivisionWithoutRemainder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 5 != 0 && number % 7 != 0 ? "The number cannot be devided by 5 and 7 without remainder!" : "The number can be divided by 5 and 7 without remainder!");
        }
    }


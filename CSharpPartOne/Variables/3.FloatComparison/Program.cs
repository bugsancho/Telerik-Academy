using System;

    class FloatComparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            float FirstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number:");
            float SecondNumber = float.Parse(Console.ReadLine());

            if (FirstNumber == SecondNumber)
                Console.WriteLine("The numbers appear to be equal!");
            else
                Console.WriteLine("The numbers are not equal!");


        }
    }


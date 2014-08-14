using System;
    class LinearEquation
    {
//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//		Create appropriate methods.
//		Provide a simple text-based menu for the user to choose which task to solve.
//		Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

        static void Main()
        {
            Console.WriteLine("Please chooese what you want to do by typing \"reversed number\", \"avarage\" or \"solve equation\": ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "reversed number": GetReversedNumber(); break;
                case "avarage": GetAvarage(); break;
                case "solve equation": SolveEquation(); break;
                default: Console.WriteLine("Not a valid command"); Console.WriteLine(); Main(); break;
            }
        }


        private static void GetReversedNumber()
        {
            Console.WriteLine("Now enter the number you want to see reversed(make sure its a positive integer):");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Not a positive number!");
                Console.WriteLine();
                Main();
            }
            int reversed = 0;
            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
            Console.WriteLine("The number you entered reversed looks like this: {1}, ",reversed);
        }
        private static void GetAvarage()
        {
            double sum = 0;
            Console.WriteLine("Now enter how many numbers you want to sum");
            int numbersToSum = int.Parse(Console.ReadLine());
            Console.WriteLine("And now enter {0} numbers",numbersToSum);
            for (int i = 0; i < numbersToSum; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            if (numbersToSum == 0)
            {
                Console.WriteLine("You have to enter some numbers!");
                Console.WriteLine();
                Main();
            }
            double avarage = sum /numbersToSum;
            Console.WriteLine("The avarage of the numbers you entered is {0}",avarage);
        }
        private static void SolveEquation()
        {
            Console.WriteLine("You are now solving a linear equation of the type: a*x + b = 0");
            Console.WriteLine("Now enter a coefficient for a:");
            double aCoefficient = double.Parse(Console.ReadLine());
            if (aCoefficient == 0)
            {
                Console.WriteLine("The coefficient for \"a\" should not be 0!");
                Console.WriteLine();
                Main();
            }
            Console.WriteLine("Now enter a coefficient for b:");
            double bCoefficient = double.Parse(Console.ReadLine());
            double result = -(bCoefficient/aCoefficient);
            Console.WriteLine("X = {0}", result);
        }

    }


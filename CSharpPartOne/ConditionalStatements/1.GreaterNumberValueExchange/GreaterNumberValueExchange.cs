using System;
    class GreaterNumberValueExchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            double secondNumber = double.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The greater number is: {0}!",firstNumber);
            }
            else
            {
                firstNumber = secondNumber;
                Console.WriteLine("The greater number is: {0}!", firstNumber);
            }

        }
    }


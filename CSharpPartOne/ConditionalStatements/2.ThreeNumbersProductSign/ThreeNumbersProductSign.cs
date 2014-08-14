using System;
class ThreeNumbersProductSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter yet another number");
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber >= 0)
            {
                if (secondNumber >= 0)
                {
                    if (thirdNumber >= 0)
                    {
                        Console.WriteLine("The multiplication of {0}, {1} and {2} results in a positive number", 
                            firstNumber, secondNumber, thirdNumber);
                    }
                    else
                    {
                        Console.WriteLine("The multiplication of {0}, {1} and {2} results in a negative number",
                            firstNumber, secondNumber, thirdNumber);
                    }
                }
                else if (thirdNumber >= 0)
                {
                    Console.WriteLine("The multiplication of {0}, {1} and {2} results in a negative number",
                        firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("The multiplication of {0}, {1} and {2} results in a positive number",
                        firstNumber, secondNumber, thirdNumber);
                }
            }

            if (firstNumber < 0)
            {
                if (secondNumber < 0)
                {
                    if (thirdNumber < 0)
                    {
                        Console.WriteLine("The multiplication of {0}, {1} and {2} results in a negative number",
                            firstNumber, secondNumber, thirdNumber);
                    }
                    else
                    {
                        Console.WriteLine("The multiplication of {0}, {1} and {2} results in a positive number",
                            firstNumber, secondNumber, thirdNumber);
                    }
                }
                else if (thirdNumber < 0)
                {
                    Console.WriteLine("The multiplication of {0}, {1} and {2} results in a positive number",
                        firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("The multiplication of {0}, {1} and {2} results in a negative number",
                        firstNumber, secondNumber, thirdNumber);
                }
            }

            

        }
          }


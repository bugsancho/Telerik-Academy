using System;
    class ThreeNumbersComparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter yet another number");
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber)
            {
                if (secondNumber >= thirdNumber)
                {
                    Console.WriteLine("The greatest number of {0},{1} and {2} is {0}",firstNumber,secondNumber,thirdNumber);
                }
                else if (firstNumber >= thirdNumber)
                {
                    Console.WriteLine("The greatest number of {0},{1} and {2} is {0}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("The greatest number of {0},{1} and {2} is {2}", firstNumber, secondNumber, thirdNumber);
                }
            }
            else if (secondNumber >= thirdNumber)
            {
                Console.WriteLine("The greatest number of {0},{1} and {2} is {1}", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("The greatest number of {0},{1} and {2} is {2}", firstNumber, secondNumber, thirdNumber);

            }
        }
    }


using System;
    class GreatestofFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter yet another number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter just one more number: ");
            double fourthNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your last number: ");
            double fifthNumber = double.Parse(Console.ReadLine());

            double greatestNumber = firstNumber;
            if (greatestNumber < secondNumber)
            {
                greatestNumber = secondNumber;
            }
            if (greatestNumber < thirdNumber)
            {
                greatestNumber = thirdNumber;
            }
            if (greatestNumber < fourthNumber)
            {
                greatestNumber = fourthNumber;
            }
            if (greatestNumber < fifthNumber)
            {
                greatestNumber = fifthNumber;
            }
            Console.WriteLine("The greatest number entered is: {0}", greatestNumber);
        }
    }


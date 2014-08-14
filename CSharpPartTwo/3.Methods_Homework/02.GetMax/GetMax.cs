using System;
    class GetMax
    {
        //Write a method GetMax() with two parameters that returns the bigger of two integers.
        //Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("And just one more number:");
            int thirdNumber = int.Parse(Console.ReadLine());
            int greatestNumber = 0;
            greatestNumber = GetMaxMethod(GetMaxMethod(firstNumber, secondNumber), thirdNumber);
            Console.WriteLine("The greatest number of {0}, {1} and {2} is: {3}!",firstNumber,secondNumber,thirdNumber,greatestNumber);
        }

        static int GetMaxMethod(int firstNumber, int secondNumber)
        {
            int greaterNumber = firstNumber;
            if (secondNumber > greaterNumber)
            {
                greaterNumber = secondNumber;
            }
            return greaterNumber;
        }
    }

using System;
    class SquareRootCalculation
    {
        //Write a program that reads an integer number and calculates and prints its square root. 
        //If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

        static void Main()
        {
            Console.WriteLine("This program calculates the square root of given number:");
            Console.WriteLine("Please enter a number:");
            uint number = 0;
            try
            {
                number = uint.Parse(Console.ReadLine());
                Console.WriteLine("The square root of {0} is {1:0.00} !", number, Math.Sqrt(number));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
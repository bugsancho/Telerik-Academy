using System;
    class MaxAndMinNumbers
    {
        //Write a program that reads from the console a sequence of N integer numbers 
        // and returns the minimal and maximal of them.


        static void Main()
        {
             Console.Write("Please enter how many numbers you would like to enter: ");
            int n = int.Parse(Console.ReadLine());
            decimal minNumber = 0;
            decimal maxNumber = 0;
            decimal number = 0;
            number = decimal.Parse(Console.ReadLine()); //Reads the first number.
            minNumber = number;                 //Makes sure the result is within
            maxNumber = number;                 // the range  of the entered numbers.

            for (int i = 0; i < n - 1; i++)   //The loop reads the next numbers and compares
            {                                 // them to the previous ones.
                number = decimal.Parse(Console.ReadLine());
                if (maxNumber < number)
                {
                    maxNumber = number;
                }
                else if (minNumber > number)
                {
                    minNumber = number;
                }
            }

            Console.WriteLine("The greatest number entered is: {0}",maxNumber);
            Console.WriteLine("The smallest number entered is: {0}",minNumber);
        }
    }


using System;
    class ReversedNumber
    {
        //Write a method that reverses the digits of given decimal number. Example: 256  652

        static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("The number {0}, reversed, looks like this: ", number);
            Console.WriteLine(GetReversedNumber(number));
        }

        private static int GetReversedNumber(int number)
        {
            int reversed = 0;
            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
            return reversed;
        }
    }


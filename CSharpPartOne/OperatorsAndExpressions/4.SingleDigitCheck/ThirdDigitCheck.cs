using System;
    class ThirdDigitCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            number /= 100;
            int thirdDigit = number % 10;
            Console.WriteLine("The third digit(right to left) is {0}!", Math.Abs(thirdDigit));
                   
        }
    }

using System;
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the lenght of side a of the trapezoid:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the lenght of side b of the trapezoid:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height of the trapezoid:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of the trapezoid is {0}", (a + b) / 2.0 * h);
        }
    }


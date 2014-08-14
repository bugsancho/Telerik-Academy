using System;
    class CoordinateCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a coordinate for X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a coordinate for Y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(x) <= 5 & Math.Abs(y) <= 5 ? "The point is within the circle ((0,0);5)" : "The point isn't within the circle ((0,0);5)");
        }
    }

using System;
    class CirclePerimeterAndArea
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area.

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle:");
            int radius = int.Parse(Console.ReadLine());
            double pi = Math.PI;
            double perimeter = 2 * pi * radius;
            double area = pi * radius * radius;

            Console.WriteLine("The perimeter of the circle is: {0:0.00}",perimeter);
            Console.WriteLine("The area of the circle is: {0:0.00}",area);
        }
    }


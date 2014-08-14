using System;
    class RectangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the height of the rectangle:");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of the rectangle:");
            int width =int.Parse(Console.ReadLine());
            Console.WriteLine("The area of the rectangle is: " + Math.Abs(width * height));
            bool sa = true;
            Console.WriteLine(sa);
        }
    }

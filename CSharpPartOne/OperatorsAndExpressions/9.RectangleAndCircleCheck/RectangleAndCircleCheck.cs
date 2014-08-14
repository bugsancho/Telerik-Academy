using System;
    class RectangleAndCircleCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the X coordinate:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Y coordinate:");
            int y = int.Parse(Console.ReadLine());
           
            bool InCircle = (Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 3);
            bool OutOfRectangle = ((1 > x || x > 7) && (-1 < y || y < -3));

            if (InCircle && OutOfRectangle)
            {
                Console.WriteLine("The Point is in the circle and out of the rectangle");
            }
            else
            {
                Console.WriteLine("The Point is either out of the circle or in the rectangle");
            }
        }
    }


using System;
class CartesianCoordinateSystem
{
    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("1");
                }
                if (y < 0)
                {
                    Console.WriteLine("4");
                }
                if (y == 0)
                {
                    Console.WriteLine("6");                    
                }

            }
            if (x < 0)
            {
                if (y < 0)
                {
                    Console.WriteLine("3");
                }
                if (y > 0)
                {
                    Console.WriteLine("2");
                }
                if (y == 0)
                {
                    Console.WriteLine("6");
                }
            }
            if (x == 0)
            {
                if (y == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("5");
                }
            }
    }
}


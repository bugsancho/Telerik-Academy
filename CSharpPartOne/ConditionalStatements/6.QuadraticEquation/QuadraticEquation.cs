using System;
class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the coefficient for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coefficient for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coefficient for c: ");
        double c = double.Parse(Console.ReadLine());
        double D = (b * b) - (4 * a * c);
        if (D > 0)
        {
            double firstX = (-b + Math.Sqrt(D)) / (2 * a);
            double secondX = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("The two real roots of the equation are: {0:0.00} and {1:0.00}", firstX, secondX);
        }
        else if (D == 0)
        {
            double OnlyX = (-b / 2 * a);
            Console.WriteLine("The only (double) real root of the equation is: {0:0.00}", OnlyX);
        }
        else if (D < 0)
        {
            Console.WriteLine("The equation doesn't have any real roots!");
        }


    }
}


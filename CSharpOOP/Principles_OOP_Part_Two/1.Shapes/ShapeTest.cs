using System;
class ShapeTest
{
    //simple example of the functionality of the introduced shape classes.
    static void Main()
    {
        Rectangle rectangle = new Rectangle(2,4);
        Triangle triangle = new Triangle(2, 4);
        Circle circle = new Circle(2);
        Shape[] shapes = { rectangle, triangle, circle };
        foreach (var shape in shapes)
        {
            Console.Write("{0} area: ",shape.GetType().Name.PadRight(10));
            Console.WriteLine(shape.CalculateSurface());
        }
    }
}
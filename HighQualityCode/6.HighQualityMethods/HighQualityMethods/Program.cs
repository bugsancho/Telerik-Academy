using System;
namespace HighQualityMethods
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The area of a triangle with sides 3,4,5 is: {0}", Geometry.CalcTriangleArea(3, 4, 5));
            Console.WriteLine("The English wording for the digit 5 is: {0}", LanguageTools.GetEnglishWordForDigit(5));
            Console.WriteLine(CollectionTools.FindMax(5, -1, 3, 2, 14, 2, 3));

            ConsolePrinter.PrintNumberAsFloat(1.3);
            ConsolePrinter.PrintNumberAsPercent(0.75);
            ConsolePrinter.PrintRightAlignedNumber(2.30);

            Console.WriteLine("The distance between the points (3,-1) and (3,2.5) is: {0}", Geometry.CalcDistanceBetweenTwoPoints(3, -1, 3, 2.5));
            Console.WriteLine("Is the line formed by the points (3,-1) and (3,2.5) horizontal: {0}", Geometry.IsLineHorizontal(3, -1, 3, 2.5));
            Console.WriteLine("Is the line formed by the points (3,-1) and (3,2.5) vertical: {0}", Geometry.IsLineVertical(3, -1, 3, 2.5));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov", DateOfBirth = new DateTime(1992,03,17) };
            Student stella = new Student() { FirstName = "Stella", LastName = "Markova", DateOfBirth = new DateTime(1993,11,03) };
            Console.WriteLine("Is {0} older than {1}: {2}",peter.FirstName,stella.FirstName,peter.IsOlderThan(stella));
        }
    }
}
using System;
using System.Linq;
class DivisibleNumbers
{//simple filtering demo using LINQ and lambda expressions.
    static void Main()
    {
        int[] numbers = { 3, 7, 12, 21, 42, 45 };
        var filteredNumbers = numbers.Where(number => number % 21 == 0);
        foreach (var number in filteredNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

        var moreFilteredNumbers =
            from number in numbers
            where number % 21 == 0
            select number;
        foreach (var number in moreFilteredNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
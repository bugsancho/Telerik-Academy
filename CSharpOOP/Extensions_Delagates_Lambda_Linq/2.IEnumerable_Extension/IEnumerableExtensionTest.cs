using System;

public static class IEnumerableExtensionTest
{
    static void Main()
    {
        int[] numbers = {-4, 3, 4, -5 };
        Console.WriteLine(numbers.Min());
        Console.WriteLine(numbers.Max());
        string[] strings = {"bla","ba","ahaa"};
        Console.WriteLine(strings.Min());
        Console.WriteLine(strings.Max());
        Console.WriteLine(numbers.Average());
        Console.WriteLine(numbers.Product());
        Console.WriteLine(numbers.Sum());
    }
}
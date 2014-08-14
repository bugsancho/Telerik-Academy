using System;

class ReadNumberInGivenRange
{
    //Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
    //If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
    //a1, a2, … a10, such that 1 < a1 < … < a10 < 100

    private static void Main()
    {
        Console.WriteLine("This program reads 10 integer numbers in an increasing sequence in the range(0,100)");
        int[] numbers = new int[10];
        int start = 0;
        int end = 100;
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = ReadNumber(start, end);
            start = numbers[i];

        }
        Console.Clear();
        Console.WriteLine("The numbers you entered are: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0},",numbers[i]);
        }
        Console.WriteLine();
    }

    private static int ReadNumber(int start, int end)
    {
        Console.WriteLine("Please enter a number in the range: ({0}, {1})", start, end);
        int number = int.Parse(Console.ReadLine());
        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException();
        }
        start = number;
        return number;

    }
}

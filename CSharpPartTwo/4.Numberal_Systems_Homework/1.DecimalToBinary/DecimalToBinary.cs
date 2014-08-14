using System;
using System.Collections.Generic;
class DecimalToBinary
{
    //Write a program to convert decimal numbers to their binary representation.

    private static bool isNegative = false;

    static void Main()
    {
        Console.WriteLine("Please enter an number in decimal numeral system: ");
        int numberInDecimal = int.Parse(Console.ReadLine());
        List<int> numberInBinary = ConvertToBinary(numberInDecimal);
        PrintNumber(numberInBinary);
    }

    private static void PrintNumber(List<int> numberInBinary)
    {
        Console.WriteLine("The number in binary numeral system looks like this: ");
        if (isNegative)
        {
            Console.Write("-");
        }
        for (int i = 0; i < numberInBinary.Count; i++)
        {
            Console.Write(numberInBinary[i]);
        }
        Console.WriteLine();
    }

    private static List<int> ConvertToBinary(int numberInDecimal)
    {
        
        List<int> numberInBinary = new List<int>();
        if (numberInDecimal < 0)
        {
            numberInDecimal = -numberInDecimal;
            isNegative = true;
        }
        else if (numberInDecimal == 0)
        {
            numberInBinary.Add(0);
            return numberInBinary;
        }
        while (numberInDecimal > 0)
        {
            numberInBinary.Add(numberInDecimal % 2);
            numberInDecimal /= 2;
        }
        numberInBinary.Reverse();
        return numberInBinary;
    }
}

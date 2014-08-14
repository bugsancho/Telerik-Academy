using System;
using System.Collections.Generic;
class ConversionBetweenTwoRandomNumeralSystems
//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

{
    private static bool isNumberNegative = false;

    static void Main()
    {
        Console.WriteLine("Please enter the base of the numeral system of the number you are about to enter(a number between 2 and 16):");
        int inputNumberBase = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter enter the number:");
        string inputNumber = Console.ReadLine();
        Console.WriteLine("And now the base of the numeral system you want to convert it to(a number between 2 and 16):");
        int outputNumberBase = int.Parse(Console.ReadLine());
        List<char> outputNumber = ConvertFromBaseStoD(inputNumber, inputNumberBase, outputNumberBase);
        PrintNumber(outputNumber);
    }
    private static List<char> ConvertFromBaseStoD(string inputNumber, int inputNumberBase, int outputNumberBase)
    {
        int numberInDecimal = ConvertToDecimal(inputNumber, inputNumberBase);
        List<char> result = ConvertToNewBase(numberInDecimal, outputNumberBase);
        return result;

    }
    private static int ConvertToDecimal(string inputNumber, int inputNumberBase)
    {
        int numberInDecimal = 0;
        int multiplier = 1;
        for (int i = inputNumber.Length - 1; i >= 0; i--)
        {
            char currentChar = inputNumber[i];
            switch (currentChar)
            {
                case '-': isNumberNegative = true; break;
                case '0': numberInDecimal += multiplier * 0; break;
                case '1': numberInDecimal += multiplier * 1; break;
                case '2': numberInDecimal += multiplier * 2; break;
                case '3': numberInDecimal += multiplier * 3; break;
                case '4': numberInDecimal += multiplier * 4; break;
                case '5': numberInDecimal += multiplier * 5; break;
                case '6': numberInDecimal += multiplier * 6; break;
                case '7': numberInDecimal += multiplier * 7; break;
                case '8': numberInDecimal += multiplier * 8; break;
                case '9': numberInDecimal += multiplier * 9; break;
                case 'A': numberInDecimal += multiplier * 10; break;
                case 'B': numberInDecimal += multiplier * 11; break;
                case 'C': numberInDecimal += multiplier * 12; break;
                case 'D': numberInDecimal += multiplier * 13; break;
                case 'E': numberInDecimal += multiplier * 14; break;
                case 'F': numberInDecimal += multiplier * 15; break;
            }
            multiplier *= inputNumberBase;
        }
        return numberInDecimal;
    }

    private static List<char> ConvertToNewBase(int number, int outputNumberBase)
    {
        List<char> outputNumber = new List<char>();
        if (number == 0)
        {
            outputNumber.Add('0');
            return outputNumber;
        }
        while (number > 0)
        {
            int currentChar = number % outputNumberBase;
            switch (currentChar)
            {
                case 0: outputNumber.Add('0'); break;
                case 1: outputNumber.Add('1'); break;
                case 2: outputNumber.Add('2'); break;
                case 3: outputNumber.Add('3'); break;
                case 4: outputNumber.Add('4'); break;
                case 5: outputNumber.Add('5'); break;
                case 6: outputNumber.Add('6'); break;
                case 7: outputNumber.Add('7'); break;
                case 8: outputNumber.Add('8'); break;
                case 9: outputNumber.Add('9'); break;
                case 10: outputNumber.Add('A'); break;
                case 11: outputNumber.Add('B'); break;
                case 12: outputNumber.Add('C'); break;
                case 13: outputNumber.Add('D'); break;
                case 14: outputNumber.Add('E'); break;
                case 15: outputNumber.Add('F'); break;
            }
            number /= outputNumberBase;
        }
        if (isNumberNegative)
        {
            outputNumber.Add('-');
        }
        outputNumber.Reverse();
        return outputNumber;
    }
    private static void PrintNumber(List<char> outputNumber)
    {
        foreach (char item in outputNumber)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}
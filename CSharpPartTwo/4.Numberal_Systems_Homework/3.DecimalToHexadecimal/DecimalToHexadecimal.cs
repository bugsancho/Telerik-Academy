using System;
using System.Collections.Generic;
class DecimalToHexadecimal
{
    //Write a program to convert decimal numbers to their hexadecimal representation.

    static void Main()
    {
        Console.WriteLine("Please enter a number in decimal numeral system:");
        int number = int.Parse(Console.ReadLine());
        List<char> numberInHexadecimal = ConvertToHexadecimal(number);
        PrintHexadecimalNumber(numberInHexadecimal);
    }

    private static void PrintHexadecimalNumber(List<char> numberInHexadecimal)
    {
        Console.WriteLine("The number in hexadecimal numeral system looks like this: ");
        foreach (char item in numberInHexadecimal)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }

    private static List<char> ConvertToHexadecimal(int number)
    {
        bool isNegative = false;
        List<char> numberInHexadecimal = new List<char>();
        if (number == 0)
        {
            numberInHexadecimal.Add('0');
            return numberInHexadecimal;
        }
        else if (number < 0)
        {
            isNegative = true;
            number = -number;
        }
        while (number > 0)
        {
            int currentChar = number % 16;
            switch (currentChar)
            {
                case 0: numberInHexadecimal.Add('0'); break;
                case 1: numberInHexadecimal.Add('1'); break;
                case 2: numberInHexadecimal.Add('2'); break;
                case 3: numberInHexadecimal.Add('3'); break;
                case 4: numberInHexadecimal.Add('4'); break;
                case 5: numberInHexadecimal.Add('5'); break;
                case 6: numberInHexadecimal.Add('6'); break;
                case 7: numberInHexadecimal.Add('7'); break;
                case 8: numberInHexadecimal.Add('8'); break;
                case 9: numberInHexadecimal.Add('9'); break;
                case 10: numberInHexadecimal.Add('A'); break;
                case 11: numberInHexadecimal.Add('B'); break;
                case 12: numberInHexadecimal.Add('C'); break;
                case 13: numberInHexadecimal.Add('D'); break;
                case 14: numberInHexadecimal.Add('E'); break;
                case 15: numberInHexadecimal.Add('F'); break;
            }
            number /= 16;
        }
        if (isNegative)
        {
            numberInHexadecimal.Add('-');
        }
        numberInHexadecimal.Reverse();
        
        return numberInHexadecimal;
    }
}

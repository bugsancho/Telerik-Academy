using System;
using System.Collections.Generic;
class HexadecimalToDecimal
{
    //Write a program to convert hexadecimal numbers to their decimal representation.

    static void Main()
    {
        Console.WriteLine("Please enter a number in hexadecimal numeral system:");
        string numberInHexadecimal = Console.ReadLine();
        int numberInDecimal = ConvertToDecimal(numberInHexadecimal);
        if (numberInHexadecimal[0] == '-')
        {
            numberInDecimal = -numberInDecimal;
        }
        Console.WriteLine("The number in decimal numeral system looks like this: {0}",numberInDecimal);
    }

    private static int ConvertToDecimal(string numberInHexadecimal)
    {
        int numberInDecimal = 0;
        int multiplier = 1;
        for (int i = numberInHexadecimal.Length -1; i >= 0 ; i--)
        {
            char currentChar = numberInHexadecimal[i];
            switch (currentChar)
            {
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
            multiplier *= 16;
        }
        return numberInDecimal;
    }
}
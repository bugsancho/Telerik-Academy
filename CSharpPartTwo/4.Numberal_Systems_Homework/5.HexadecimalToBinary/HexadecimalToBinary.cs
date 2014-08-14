using System;
using System.Collections.Generic;
class HexadecimalToBinary
{
    //Write a program to convert hexadecimal numbers to binary numbers (directly).

    static void Main()
    {
        Console.WriteLine("Please enter a number in hexadecimal numeral system:");
        string HexadecimalNumber = Console.ReadLine();
        string[] numberInBinary = ConvertToBinary(HexadecimalNumber);
        PrintBinaryNumber(numberInBinary, HexadecimalNumber);
    }

    private static void PrintBinaryNumber(string[] numberInBinary, string HexadecimalNumber)
    {
        Console.WriteLine("The number in binary numeral system looks like this: ");
        if (HexadecimalNumber[0] == '-')
        {
            Console.Write("-");
        }
        for (int i = 0; i < numberInBinary.Length; i++)
        {
            Console.Write(numberInBinary[i]);
        }
        Console.WriteLine();
    }

    private static string[] ConvertToBinary(string HexadecimalNumber)
    {
        string[] numberInBinary = new string[HexadecimalNumber.Length];
        for (int i = 0; i < HexadecimalNumber.Length; i++)
        {
            char currentChar = HexadecimalNumber[i];
            switch (currentChar)
            {
                case '0': numberInBinary[i] = "0000"; break;
                case '1': numberInBinary[i] = "0001"; break;
                case '2': numberInBinary[i] = "0010"; break;
                case '3': numberInBinary[i] = "0011"; break;
                case '4': numberInBinary[i] = "0100"; break;
                case '5': numberInBinary[i] = "0101"; break;
                case '6': numberInBinary[i] = "0110"; break;
                case '7': numberInBinary[i] = "0111"; break;
                case '8': numberInBinary[i] = "1000"; break;
                case '9': numberInBinary[i] = "1001"; break;
                case 'A': numberInBinary[i] = "1010"; break;
                case 'B': numberInBinary[i] = "1011"; break;
                case 'C': numberInBinary[i] = "1100"; break;
                case 'D': numberInBinary[i] = "1101"; break;
                case 'E': numberInBinary[i] = "1110"; break;
                case 'F': numberInBinary[i] = "1111"; break;
            }
        }
        return numberInBinary;
    }
}

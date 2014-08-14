using System;
using System.Numerics;
using System.Text;
using System.Collections.Generic;
class Zerg
{
    static StringBuilder numberInPentadecimal = new StringBuilder();
    static List<string> digitsInPenta = new List<string>();
    static void ConvertStringToNumber()
    {
        foreach (var digit in digitsInPenta)
        {
            switch (digit)
            {
                case "Rawr": numberInPentadecimal.Append("0"); break;
                case "Rrrr": numberInPentadecimal.Append("1"); break;
                case "Hsst": numberInPentadecimal.Append("2"); break;
                case "Ssst": numberInPentadecimal.Append("3"); break;
                case "Grrr": numberInPentadecimal.Append("4"); break;
                case "Rarr": numberInPentadecimal.Append("5"); break;
                case "Mrrr": numberInPentadecimal.Append("6"); break;
                case "Psst": numberInPentadecimal.Append("7"); break;
                case "Uaah": numberInPentadecimal.Append("8"); break;
                case "Uaha": numberInPentadecimal.Append("9"); break;
                case "Zzzz": numberInPentadecimal.Append("A"); break;
                case "Bauu": numberInPentadecimal.Append("B"); break;
                case "Djav": numberInPentadecimal.Append("C"); break;
                case "Myau": numberInPentadecimal.Append("D"); break;
                case "Gruh": numberInPentadecimal.Append("E"); break;
                default:
                    break;
            }
        }
    }


    static void Main()
    {
        string input = Console.ReadLine();

        int chunkSize = 4;
        int stringLength = input.Length;
        for (int i = 0; i < stringLength; i += 4)
        {
            if (i + chunkSize > stringLength) chunkSize = stringLength - i;
            digitsInPenta.Add(input.Substring(i, 4));
        }
        ConvertStringToNumber();
        BigInteger numberInDecimal = ConvertToDecimal(numberInPentadecimal.ToString());
        Console.WriteLine(numberInDecimal);



    }

    private static BigInteger ConvertToDecimal(string numberInPentadecimal)
    {
        BigInteger numberInDecimal = 0;
        BigInteger multiplier = 1;
        for (int i = numberInPentadecimal.Length - 1; i >= 0; i--)
        {
            char currentChar = numberInPentadecimal[i];
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
            }
            multiplier *= 15;
        }
        return numberInDecimal;
    }
}

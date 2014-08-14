using System;
class BinaryToHexadecimal
{
    //Write a program to convert binary numbers to hexadecimal numbers (directly).

    static void Main()
    {
        Console.WriteLine("Please enter a number in binary numeral system:");
        string binaryNumber = Console.ReadLine();
        char[] numberInHexadecimal;
        string[] binaryNumberStr;
        string OutputNumber;
        binaryNumber = ConvertToHexadecimal(binaryNumber, out numberInHexadecimal, out binaryNumberStr, out OutputNumber);
        Console.WriteLine("The number in hexadecimal numeral system looks like this: {0}", OutputNumber);
    }

    private static string ConvertToHexadecimal(string binaryNumber, out char[] numberInHexadecimal, out string[] binaryNumberStr, out string OutputNumber)
    {
        binaryNumber = SplitIntoStringArray(binaryNumber, out numberInHexadecimal, out binaryNumberStr);
        for (int i = 0; i < binaryNumberStr.Length; i++)
        {
            switch (binaryNumberStr[i])
            {
                case "0000": numberInHexadecimal[i] = '0'; break;
                case "0001": numberInHexadecimal[i] = '1'; break;
                case "0010": numberInHexadecimal[i] = '2'; break;
                case "0011": numberInHexadecimal[i] = '3'; break;
                case "0100": numberInHexadecimal[i] = '4'; break;
                case "0101": numberInHexadecimal[i] = '5'; break;
                case "0110": numberInHexadecimal[i] = '6'; break;
                case "0111": numberInHexadecimal[i] = '7'; break;
                case "1000": numberInHexadecimal[i] = '8'; break;
                case "1001": numberInHexadecimal[i] = '9'; break;
                case "1010": numberInHexadecimal[i] = 'A'; break;
                case "1011": numberInHexadecimal[i] = 'B'; break;
                case "1100": numberInHexadecimal[i] = 'C'; break;
                case "1101": numberInHexadecimal[i] = 'D'; break;
                case "1110": numberInHexadecimal[i] = 'E'; break;
                case "1111": numberInHexadecimal[i] = 'F'; break;
            }
        }
        OutputNumber = new string(numberInHexadecimal);
        OutputNumber = OutputNumber.TrimStart('0');
        return binaryNumber;
    }

    private static string SplitIntoStringArray(string binaryNumber, out char[] numberInHexadecimal, out string[] binaryNumberStr)
    {
        numberInHexadecimal = new char[8];
        binaryNumber = binaryNumber.PadLeft(32, '0');
        int ChunkSize = 4;
        binaryNumberStr = new string[8];
        for (int i = 0, startIndex = 0; startIndex < 32; i++, startIndex += 4)
        {
            binaryNumberStr[i] = binaryNumber.Substring(startIndex, ChunkSize);
        }
        return binaryNumber;
    }
}
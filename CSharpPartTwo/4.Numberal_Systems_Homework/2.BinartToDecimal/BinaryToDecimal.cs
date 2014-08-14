using System;
class BinaryToDecimal
{
    //Write a program to convert binary numbers to their decimal representation.

    static void Main()
    {
        Console.WriteLine("Please enter a 32 bit number in binary numberal system: ");
        string numberInBinary = Console.ReadLine();
        int numberInDecimal = ConvertToDecimal(numberInBinary);
        if (numberInBinary[0] == '-')
        {
            numberInDecimal = -numberInDecimal;
        }
        Console.WriteLine("The number in decimal looks like this: {0}!", numberInDecimal);
    }

    private static int ConvertToDecimal(string numberInBinary)
    {
        int numberInDecimal = 0;
        int multiplier = 1;
        for (int i = numberInBinary.Length -1; i >= 0; i--)
        {
            if (numberInBinary[i] == '1')
            {
                numberInDecimal += multiplier;
            }
            multiplier *= 2;
        }
       return numberInDecimal;
    }
}


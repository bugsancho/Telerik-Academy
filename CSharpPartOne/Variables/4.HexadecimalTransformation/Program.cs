using System;

class HexadecimalTransformation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a decimal number:\n");

        int hexadecimal = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe hexadecimal representation of {0} is {0:X}!\n", hexadecimal);
    }
}


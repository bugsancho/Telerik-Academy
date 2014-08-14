using System;
using System.Text;
class PrintNumber
{
    //Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
    //Format the output aligned right in 15 symbols.

    static void Main()
    {
        Console.WriteLine("This program reads a decimal number and prints its decimal, hexadecimal, percentage and scientific representations.");
        Console.WriteLine("Please enter a number:");
        long inputNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Decimal representation: {0,15:D}",inputNumber);
        Console.WriteLine("Hexadecimal representation: {0,15:X}",inputNumber);
        Console.WriteLine("Percent representation: {0,15:P}",inputNumber);
        Console.WriteLine("Scientific representation: {0,15:E}",inputNumber);
    }
}
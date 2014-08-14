using System;
using System.Collections;
class LastDigitName
{
    //Write a method that returns the last digit of given integer as an English word. 
    //Examples: 512  "two", 1024  "four", 12309  "nine".
    static void Main()
    {
        Console.WriteLine("Please enter a number");
        int number = int.Parse(Console.ReadLine());
        Console.Write("The last digit of the number you entered is: ");
        Console.WriteLine(LastDigit(number));
    }
    static string LastDigit(int number)
    {
        if (number < 0)
        {
            number = -number;
        }
        int lastDigit = number % 10;
        string[] digitName = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        return digitName[lastDigit];
    }
}
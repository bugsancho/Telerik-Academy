using System;
using System.Text.RegularExpressions;
class SubstringRepetitionCount
{
    //Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

    static void Main()
    {
        Console.WriteLine("This program finds the number of repetitions of given substring in a string!");
        Console.WriteLine("Please enter the text that is to be iterated:");
        string input = Console.ReadLine();
        Console.WriteLine("Now enter the substring you are looking for:");
        string substring = Console.ReadLine();
        MatchCollection matches = Regex.Matches(input, substring, RegexOptions.IgnoreCase);
        Console.WriteLine("The substring is found {0} times in the entered text!", matches.Count);
    }
}

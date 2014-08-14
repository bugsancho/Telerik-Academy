using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class ReverseWords
{
    //Write a program that reverses the words in given sentence.
    //Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

    static void Main()
    {
        Console.WriteLine("This program reverses a sentence, while keeping the punctuation.");
        Console.WriteLine("Please type something");
        string input = Console.ReadLine();
        string[] words = input.Split();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(",")||words[i].Contains("!")||words[i].Contains("?")||words[i].Contains("."))
            {
                
            }
        }

        /*
        string pattern = @"[^A-Za-z]+";
        string[] words = Regex.Split(input, pattern);
        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
         * */
    }
}
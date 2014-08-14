using System;
using System.Collections.Generic;
using System.Text;
class TrimConsecutiveCharacters
{
    //Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
    //Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

    static void Main()
    {
        Console.WriteLine("This program replaces all series of consecutive identical letters in a string with a single one.");
        Console.WriteLine("Please type something:");
        string input = Console.ReadLine();
        string[] words = input.Split();
        char previousChar = new char();
        List<StringBuilder> trimmedWords = new List<StringBuilder>();
        for (int i = 0; i < words.Length; i++)
        {
            trimmedWords.Add(new StringBuilder());
            previousChar = words[i][0];
            trimmedWords[i].Append(previousChar);
            for (int j = 1; j < words[i].Length; j++)
            {
                if (previousChar == words[i][j])
                {
                    previousChar = words[i][j];
                    continue;
                }
                else
                {
                    previousChar = words[i][j];
                    trimmedWords[i].Append(words[i][j]);
                }
            }
        }
        Console.WriteLine("The words trimmed are:");
        foreach (var item in trimmedWords)
        {
            Console.WriteLine(item);
        }
    }
}

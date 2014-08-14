using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
    class TextCensorship
    {
        //We are given a string containing a list of forbidden words and a text containing some of these words. 
        //Write a program that replaces the forbidden words with asterisks. 
        static void Main()
        {
            Console.WriteLine("This program replaces forbidden words with asteriks.");
            string dictionary = "PHP,CLR,Microsoft";
            string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] forbiddenWords = dictionary.Split(',');
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                input = input.Replace(forbiddenWords[i],new string('*',forbiddenWords[i].Length));
            }
            Console.WriteLine("The censored text looks like this:");
            Console.WriteLine(input);
        }
    }
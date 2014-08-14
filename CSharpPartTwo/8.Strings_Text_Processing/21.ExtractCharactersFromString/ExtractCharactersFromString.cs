using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    class ExtractCharactersFromString
    {
        //Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 

        static void Main()
        {
            Console.WriteLine("This program reads a string and prints how many times each character is found.");
            Console.WriteLine("Please type some text:");
            string input = Console.ReadLine();
            Dictionary<char, int> characters = new Dictionary<char, int>();
            char[] notLetters = new Char[]{' ','.', '?','!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+'};
            foreach (char character in input)
            {
                if (characters.ContainsKey(character))
                {
                    characters[character]++;
                }
                else if (!(notLetters.Contains(character)))
                {
                    characters.Add(character, 1);
                }
            }
            foreach (var character in characters)
            {
                Console.WriteLine("\'{0}\' is found {1} times.",character.Key,character.Value);
            }
        }
    }

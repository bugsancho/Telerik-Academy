using System;
using System.Collections.Generic;
using System.Text;
    class ExtractWordsFromText
    {
        //Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

        static void Main()
        {
            Console.WriteLine("This program reads a string and prints how many times each word is found.");
            Console.WriteLine("Please type some text:");
            string input = Console.ReadLine();
            string[] words = input.Split();
            Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();
            
            foreach (string word in words)
            {
                if (wordsDictionary.ContainsKey(word))
                {
                    wordsDictionary[word]++;
                }
                else 
                {
                    wordsDictionary.Add(word, 1);
                }
            }
            foreach (var word in wordsDictionary)
            {
                Console.WriteLine("\"{0}\" is found {1} times.", word.Key, word.Value);
            }
        }
    }
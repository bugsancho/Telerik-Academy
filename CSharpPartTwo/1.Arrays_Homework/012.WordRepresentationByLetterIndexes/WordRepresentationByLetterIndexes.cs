using System;
    class WordRepresentationByLetterIndexes
    {
        //Write a program that creates an array containing all letters from the alphabet (A-Z).
        //Read a word from the console and print the index of each of its letters in the array.

        static void Main()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string capitalAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.WriteLine("Please enter a word:");
            string inputWord = Console.ReadLine();

            Console.Write("The indexes of the word given are:");
            for (int i = 0; i < inputWord.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (inputWord[i] == alphabet[j] || inputWord[i] == capitalAlphabet[j])
                    {
                        Console.Write(" " + j);
                    }
                }
            }
            Console.WriteLine();
        }
    }


using System;
using System.Collections.Generic;
using System.Text;
class ExtractPalindromes
{
    //Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

    static void Main()
    {
        Console.WriteLine("This program extracts palindromes from given text.");
        string text = "This is text ABBA BALLAB bla bla EXE exe lammammal mamma";
        string[] words = text.Split();
        List<string> palindromes = new List<string>();
        foreach (string word in words)
        {
            for (int i = 0; i < word.Length /2; i++)
            {
                if (!(word[i] == word[word.Length - i -1]))
                {
                    break;
                }
                if (i == word.Length/2 -1)
                {
                    palindromes.Add(word);
                }
            }
        }
        Console.WriteLine("The palindromes in the text are:");
        foreach (var palindrome in palindromes)
        {
            Console.WriteLine(palindrome);
        }
    }
}

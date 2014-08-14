using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class SortWords
{
    //Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

    static void Main()
    {
        Console.WriteLine("This program reads a list of words and sorts them.");
        Console.WriteLine("Please type some words, separeted by whitespaces");
        string input = Console.ReadLine();
        string[] words = input.Split();
        Array.Sort(words);
        Console.WriteLine("The list of sorted words is:");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}

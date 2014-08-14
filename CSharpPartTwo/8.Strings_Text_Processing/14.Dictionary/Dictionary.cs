using System;
using System.Collections.Generic;
using System.Text;
class Dictionary
{
    //A dictionary is stored as a sequence of text lines containing words and their explanations.
    //Write a program that enters a word and translates it by using the dictionary. 
    static void Main()
    {
        Console.WriteLine("This is a simple dictionary program that gives the explanation of a word, if such exists.");
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add(".Net", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");
        Console.WriteLine("Please enter the word to search for:");
        string input = Console.ReadLine();
        if (dictionary.ContainsKey(input))
        {
            Console.WriteLine("{0} - {1}!",input,dictionary[input]);
            return;
        }
        Console.WriteLine("No such word exist in the dictionary!");
        
    }
}

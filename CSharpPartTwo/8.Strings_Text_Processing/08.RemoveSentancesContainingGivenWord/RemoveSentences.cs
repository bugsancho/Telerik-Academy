using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class RemoveSentences
{
    static void Main()
    {
        Console.WriteLine("This program removes from given text the sentences containing given word.");
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight.So we are drinking all the day. We will move out of it in 5 days.";
        string word = @"\bin\b";
        string[] sentences = text.Split('.');
        Console.WriteLine("The sentences that don't contain the key word are:");
        foreach (string sentence in sentences)
        {
            if (!(Regex.IsMatch(sentence,word,RegexOptions.IgnoreCase)))
            {
                continue;
            }
            Console.WriteLine(sentence.Trim());
        }
    }
}

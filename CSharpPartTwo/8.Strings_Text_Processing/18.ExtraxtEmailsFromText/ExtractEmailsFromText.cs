using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class ExtractEmailsFromText
{
    //Write a program for extracting all email addresses from given text. 
    //All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

    static void Main()
    {
        Console.WriteLine("This program extracts all emails from given text.");
        string text = "some text mail@gmail.com some more text email@email.email some invalid email mail@f.b";
        string regex = @"\w{2,}@\w{2,}\.\w{2,6}";
        MatchCollection emails = Regex.Matches(text, regex);
        Console.WriteLine("The emails found in the text are:");
        foreach (var email in emails)
        {
            Console.WriteLine(email);
        }
    }
}

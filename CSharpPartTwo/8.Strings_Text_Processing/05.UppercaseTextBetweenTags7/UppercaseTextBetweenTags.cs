using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
class UppercaseTextBetweenTags
{
    //You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 
    static void Main()
    {
        Console.WriteLine("This program reads text and uppercases all text between <upcase></upcase> tags.");
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        text = Regex.Replace(text, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper());
        Console.WriteLine("The uppercased text looks like this:");
        Console.WriteLine(text);
    }
}
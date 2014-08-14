using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
    class ExtractTextFromHTML
    {
        //Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
        static void Main()
        {
            Console.WriteLine("This program extracts the text between HTML tags.");
            string HTML = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";
            string pattern = "(?<=>).*?(?=<)";
            MatchCollection matches = Regex.Matches(HTML, pattern);
            Console.WriteLine("And here is the extracted text:");
            foreach (var match in matches)
            {
                if (match.ToString() != string.Empty)
                {
                    Console.WriteLine(match);
                }

            }
        }
    }

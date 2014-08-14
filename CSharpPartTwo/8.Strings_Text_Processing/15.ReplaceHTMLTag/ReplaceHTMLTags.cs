using System;
using System.Collections.Generic;
using System.Text;
class ReplaceHTMLTags
{
    //Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
    static void Main()
    {
        Console.WriteLine(@"This program replaces <a href="".. tags with [URL=.. tags.");
        string text = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        string[] tagsToFind = new string[] { "<a href=\"", "\">", "</a>" };
        string[] tagsToReplace = new string[] { "[URL=", "]", "[/URL]" };
        for (int i = 0; i < tagsToFind.Length; i++)
        {
           text = text.Replace(tagsToFind[i], tagsToReplace[i]);
        }
        Console.WriteLine(text);
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class URLAdressParsing
{
    //Write a program that parses an URL address given in the format:
    //and extracts from it the [protocol], [server] and [resource] elements. 
    //For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
    //[protocol] = "http"
    //[server] = "www.devbg.org"
    //[resource] = "/forum/index.php"
    
    static void Main()
    {
        Console.WriteLine("This program parses an URL adress and splits it into protocol, server and resource.");
        string url = "http://www.devbg.org/forum/index.php";
        string pattern = @"(.+)://(.+?)/(.+)";
        GroupCollection match = Regex.Match(url, pattern).Groups;
        Console.WriteLine("URL: {0}",url);
        Console.WriteLine("Protocol: {0}",match[1]);
        Console.WriteLine("Server: {0}", match[2]);
        Console.WriteLine("Resource: {0}", match[3]);
    }
}

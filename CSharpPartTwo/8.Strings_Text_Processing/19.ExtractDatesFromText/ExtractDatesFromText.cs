using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;
class ExtractDatesFromText
{
    //Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.

    static void Main()
    {
        Console.WriteLine("This program extracts dates in the format DD.MM.YYYY from a text");
        string text = "This is text 5.5.2012 this is text 03.10.2000 this is not date 5.15.2000";
        string pattern = @"\b\d{1,2}.\d{1,2}.\d{2,4}\b";
        MatchCollection dates = Regex.Matches(text, pattern);
        List<DateTime> parsedDates = new List<DateTime>();
        DateTime tempDate = new DateTime();
        foreach (var date in dates)
        {
            if (DateTime.TryParse(date.ToString(), out tempDate))
            {
                parsedDates.Add(tempDate);

            }
        }
        Console.WriteLine("The dates in the text are:");
        foreach (var date in parsedDates)
        {
            Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
        }
        
    }
}
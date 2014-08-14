using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
class ReadDateAndTime
{
    //Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
    // and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

    static void Main()
    {
        CultureInfo cultureinfo = new CultureInfo("bg-BG");
        Console.WriteLine("This program reads date and time in the format:");
        Console.WriteLine(" day.month.year hour:minute:second, adds 6 hours and 30 minutes and prints the day of week");
        Console.WriteLine("Please enter the date and time in the format described:");
        DateTime dateAndTime = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Date and time after 6.5 hours:");
        Console.WriteLine(dateAndTime.AddHours(6.5));
        Console.WriteLine("Day of week:");
        Console.WriteLine(dateAndTime.ToString("dddd"));
    }
}

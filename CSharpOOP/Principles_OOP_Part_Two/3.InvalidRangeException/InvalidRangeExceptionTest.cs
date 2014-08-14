using System;
class InvalidRangeExceptionTest
{
    //Very simple example for the use of the introduced exception class.
    static string dateTimeFormat = "dd.MM.yyyy";
    static void Main()
    {
        int startNumber = 0;
        int endNumber = 100;
        DateTime startDate = new DateTime(2000, 1, 1);
        DateTime endDate = new DateTime(2020, 1, 1);
        
        try
        {
            ReadNumberInRange(startNumber, endNumber);
        }
        catch (InvalidRangeException<int> exception)
        {
            Console.WriteLine(exception.Message);
            Console.WriteLine("The specified range was: ({0},{1})", exception.Start, exception.End);
        }
        try
        {
            ReadDateInRange(startDate, endDate);
        }
        catch (InvalidRangeException<DateTime> exception)
        {
            Console.WriteLine(exception.Message);
            Console.WriteLine("The specified range was: ({0},{1})", exception.Start.ToString(dateTimeFormat), exception.End.ToString(dateTimeFormat));
        }

        Console.WriteLine("Everything went smoothly!");
    }

    private static void ReadDateInRange(DateTime start, DateTime end)
    {
        Console.WriteLine("Please enter a date in the range: ({0}, {1})!", start.ToString(dateTimeFormat), end.ToString(dateTimeFormat));
        DateTime readDate = DateTime.Parse(Console.ReadLine());
        if (readDate.CompareTo(start) < 0 || readDate.CompareTo(end) > 0)
        {
            throw new InvalidRangeException<DateTime>(start, end, "The date was not in the specified range!");
        }
    }

    private static void ReadNumberInRange(int start, int end)
    {
        Console.WriteLine("Please enter a number in the range:  {0}, {1} !", start, end);
        int readNumber = int.Parse(Console.ReadLine());
        if (readNumber < start || readNumber > end)
        {
            throw new InvalidRangeException<int>(start, end, "The number was not in the specified range!");
        }
    }


}
namespace DayOfWeekClient
{
    using System;
    using System.Text;
    using DayOfWeekClient.DayOfWeek;

    class DayOfWeekConsoleClient
    {
        static void Main()
        {
            var client = new DayOfWeekServiceClient();
            Console.OutputEncoding = Encoding.Unicode;

            //You need to change the console font to 'Lucida Console' or 'Consolas' to properly display cyrilic letters
            Console.WriteLine("Днес е {0}!", client.GetDayOfWeek(DateTime.Now));

            Console.WriteLine(GetSubstringCount("blabla", "bla"));
        }

         public static int GetSubstringCount(string message, string substring)
        {
            int count = 0;
            int currentIndex = message.IndexOf(substring);

            while (currentIndex != -1)
            {
                currentIndex = message.IndexOf(substring, currentIndex + substring.Length);
                count++;
            }
            
            return count;
        }
    }
}
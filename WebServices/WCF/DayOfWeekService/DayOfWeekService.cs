namespace DayOfWeekService
{
    using System;
    using System.Globalization;

    public class DayOfWeekService : IDayOfWeekService
    {
        public string GetDayOfWeek(DateTime date)
        {
            return date.ToString("dddd", new CultureInfo("bg-BG"));
        }
    }
}
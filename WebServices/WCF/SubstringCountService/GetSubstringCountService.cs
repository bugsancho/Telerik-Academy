namespace SubstringCountService
{
    public class GetSubstringCountService : IGetSubstringCountService
    {
        public int GetSubstringCount(string message, string substring)
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
namespace SubstringCount.Console
{
    using SubstringCount.Console.SubstringCountService;
    using System;

    public class SubstringCountConsoleClient
    {
        static void Main()
        {
            var client = new GetSubstringCountServiceClient();
            var text = "blabla bla bla bl al bla";
            var substr = "bla";
            var result = client.GetSubstringCount(text, substr);
            Console.WriteLine("The substring: '{0}' is found in the text: '{1}' exactly {2} times!",substr, text,result);

        }
    }
}
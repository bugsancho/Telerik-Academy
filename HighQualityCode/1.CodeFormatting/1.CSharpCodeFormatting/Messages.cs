using System.Text;

public static class Messages
{
    private static readonly StringBuilder Output = new StringBuilder();

    public static string OutputString
        {
            get
            {
                return Output.ToString();
            }
        }

    public static void EventAdded()
    {
        Output.AppendLine("Event added");
    }

    public static void EventDeleted(int x)
    {
        if (x == 0)
        {
            Messages.NoEventsFound();
        }
        else
        {
            Output.AppendFormat("{0} events deleted\n", x);
        }
    }

    public static void NoEventsFound()
    {
        Output.AppendLine("No events found");
    }

    public static void PrintEvent(Event eventToPrint)
    {
        if (eventToPrint != null)
        {
            Output.AppendLine(eventToPrint.ToString());
        }
    }
}
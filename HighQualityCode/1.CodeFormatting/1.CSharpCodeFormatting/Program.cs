using System;
using System.Text;
using Wintellect.PowerCollections; // downloaded the library power collections

public static class Program
{
    private static readonly EventHolder Events = new EventHolder();

    // fixed scope parentesis, fixed apendLine where needed, fixed class access modifier
    public static void Main(string[] args)
    {
        while (ExecuteNextCommand())
        {
            Console.WriteLine(Messages.OutputString);
        }
    }

    // fixed formatting, deleted obsolete code, consolidated conditions with 'else' statements
    private static bool ExecuteNextCommand()
    {
        string command = Console.ReadLine();

        if (command[0] == 'A')
        {
            AddEvent(command);
            return true;
        }
        else if (command[0] == 'D')
        {
            DeleteEvents(command);
            return true;
        }
        else if (command[0] == 'L')
        {
            ListEvents(command);
            return true;
        }

        return false;
    }

    private static void ListEvents(string command)
    {
        int pipeIndex = command.IndexOf('|');
        DateTime date = GetDate(command, "ListEvents");
        string countString = command.Substring(pipeIndex + 1);
        int count = int.Parse(countString);
        Events.ListEvents(date, count);
    }

    private static void DeleteEvents(string command)
    {
        string title = command.Substring("DeleteEvents".Length + 1);
        Events.DeleteEvents(title);
    }

    private static void AddEvent(string command)
    {
        DateTime date;
        string title;
        string location;
        GetParameters(command, "AddEvent", out date, out title, out location);
        Events.AddEvent(date, title, location);
    }

    private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
    {
        dateAndTime = GetDate(commandForExecution, commandType);
        int firstPipeIndex = commandForExecution.IndexOf('|');

        int lastPipeIndex = commandForExecution.LastIndexOf('|');
        if (firstPipeIndex == lastPipeIndex)
        {
            eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
            eventLocation = string.Empty;
        }
        else
        {
            eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
            eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
        }
    }

    private static DateTime GetDate(string command, string commandType)
    {
        DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
        return date;
    }
}
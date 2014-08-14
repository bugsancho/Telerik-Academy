using System;
using System.Text;

static class StringBuilderExtensionTest
{
    static void Main()
    {
        StringBuilder text = new StringBuilder();
        text.Append("This is wonderful!");
        Console.WriteLine(text.Length);
        text = text.Substring(0, 15);
        Console.WriteLine(text);
        text = text.Substring(5);
        Console.WriteLine(text);
    }
}
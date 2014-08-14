using System;

public class BoolPrinter
{
    public static void Main()
    {
        BoolPrinter printer = new BoolPrinter();
        printer.PrintBoolValue(true);
    }

    public void PrintBoolValue(bool value)
    {
        Console.WriteLine(value);
    }
}
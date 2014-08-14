using System;
class PrintName
{
    //Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
    //Write a program to test this method.
    static void Main()
    {
        PrintNameMethod();
    }
    static void PrintNameMethod()
    {
        Console.WriteLine("What's your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}
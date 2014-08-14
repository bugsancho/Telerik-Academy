using System;
using System.Collections.Generic;
    class StringOperations
    {
        //Describe the strings in C#. What is typical for the string data type? Describe the most important methods of the String class
        static void Main()
        {
            Console.WriteLine("This program shows some basic functions of the string class!");
            Console.WriteLine("Please enter a piece of text to manipulate:");
            string input = Console.ReadLine();
            Console.WriteLine("ToUpper: {0}",input.ToUpper());
            Console.WriteLine("Trim: {0}",input.Trim());
            Console.WriteLine("Substring(2): {0}",input.Substring(2));
            Console.WriteLine("PadRight(10,'*'): {0}",input.PadRight(10,'*'));
            Console.WriteLine("Replace(a,b): {0}",input.Replace('a','b');

        }
    }

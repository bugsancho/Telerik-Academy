using System;
using System.Collections.Generic;
using System.Text;
    class StringToUnicode
    {
        //Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings
        static void Main()
        {
            Console.WriteLine("This program shows the unicode character representation of given string.");
            Console.WriteLine("Please type something:");
            string input = Console.ReadLine();
            StringBuilder unicodeRepresentation = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                unicodeRepresentation.AppendFormat("\\u{0:X4}",(int)input[i]);
            }
            Console.WriteLine("The unicode character representation of your text is:");
            Console.WriteLine(unicodeRepresentation);
        }
    }
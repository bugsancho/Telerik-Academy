using System;
using System.Collections.Generic;
using System.Text;
    class StringCompletion
    {
        //Write a program that reads from the console a string of maximum 20 characters. 
        //If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.

        static void Main()
        {
            Console.WriteLine("This program reads a string of maximal length - 20 characters and appends '*' if the length is lesser!");
            Console.WriteLine("Please enter the string:");
            string input = Console.ReadLine();
            if (input.Length >20)
            {
                Console.Clear();
                Console.WriteLine("The string must be less than 20 characters long!");
                input = Console.ReadLine();
            }
            StringBuilder textBuilder = new StringBuilder(20);
            textBuilder.Append(input);
            while (textBuilder.Length <=20)
            {
                textBuilder.Append('*');
            }
            Console.Write("The string with the appended asteriks looks like this: ");
            Console.WriteLine(textBuilder);
        }
    }

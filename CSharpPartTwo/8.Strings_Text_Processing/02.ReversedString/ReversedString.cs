using System;
using System.Collections.Generic;
    class ReversedString
    {
        static void Main()
        {//Write a program that reads a string, reverses it and prints the result at the console.

            Console.WriteLine("This program reverses a string read from the console.");
            Console.WriteLine("Please enter a piece of text:");
            string input = Console.ReadLine();
            char[] arr= input.ToCharArray();
            Array.Reverse(arr);
            Console.Write("The text reversed looks like: \"");
            foreach (var character in arr)
            {
                Console.Write(character);
            }
            Console.WriteLine("\"");
        }
    }

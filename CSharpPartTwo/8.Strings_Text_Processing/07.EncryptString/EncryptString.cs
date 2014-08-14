using System;
using System.Collections.Generic;
using System.Text;
class EncryptString
{
    static void Main()
    {
        Console.WriteLine("This program encodes and decodes a string by given key");
        Console.WriteLine("Please enter the string to manipulate:");
        string input = Console.ReadLine();
        string cipher = "cipher";
        string encoded = Encode(input, cipher);
        string decoded = Decode(encoded, cipher);
        Console.WriteLine("This is how the text looks encoded:");
        Console.WriteLine(encoded);
        Console.WriteLine("And this is the text decoded again:");
        Console.WriteLine(decoded);
    }

    private static string Decode(string encoded, string cipher)
    {
       return Encode(encoded, cipher);
        
    }

     static string Encode(string input, string cipher)
    {
        StringBuilder encoded = new StringBuilder(input.Length);
         int tick = cipher.Length;
         for (int i = 0; i < input.Length; i++)
         {
             encoded.Append((char)(input[i]^cipher[i%tick]));
         }
         return encoded.ToString();
    }
}

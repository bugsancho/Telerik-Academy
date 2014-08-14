using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class ReadTextFromXMLFile
{
    //Write a program that extracts from given XML file all the text without the tags. 
    static void Main()
    {
        StreamReader reader = new StreamReader("SampleFile.txt");
        using (reader)
        {
            int previousChar = ' ';
            List<string> words = new List<string>();
            StringBuilder currentWord = new StringBuilder();

            for (int currentChar; (currentChar = reader.Read()) != -1; )
            {
                if (previousChar == '>' && currentChar != '<')
                {
                    while (currentChar != '<' && currentChar != -1)
                    {
                        if (currentChar != ' ' && currentChar != '\n' && currentChar != '\r' && currentChar != '\t') currentWord.Append((char)currentChar);
                        currentChar = reader.Read();
                    }

                    if (currentWord.Length > 0)
                    {
                        words.Add(currentWord.ToString());
                        currentWord.Clear();
                    }
                }
                previousChar = currentChar;
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}

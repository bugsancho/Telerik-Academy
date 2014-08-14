using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
class DeleteWordsFromFIle
{
    //Write a program that deletes from a text file all words that start with the prefix "test".
    //Words contain only the symbols 0...9, a...z, A…Z, _.

    static void Main()
    {
        string tempFile = Path.GetTempFileName();


        StreamReader reader = new StreamReader("SampleText.txt");
        using (reader)
        {
            using (var writer = new StreamWriter(tempFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');

                    foreach (var word in words)
                    {
                        if (!(Regex.IsMatch(word, @"^[\w]+$") && word.StartsWith("test")))
                        {
                            writer.Write("{0} ", word);
                        }
                    }
                    
                }
            }
        }
        File.Delete("SampleText.txt");
        File.Move(tempFile, "SampleText.txt");
    }

}


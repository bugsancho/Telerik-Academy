using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("SampleText.txt");
        
        int counter = 1;
        List<string> evenLines = new List<string>();
        string currentLine = "";
        using (reader)
        {
            while ((currentLine = reader.ReadLine()) != null)
            {
                if (counter % 2 == 1)
                {
                    evenLines.Add(currentLine);
                }
                counter++;
            }

        }
        StreamWriter writer = new StreamWriter("SampleText.txt");
        using (writer)
        {
            foreach (var line in evenLines)
            {
                writer.WriteLine(line);
                Console.WriteLine(line);
            }
        }
    }
}

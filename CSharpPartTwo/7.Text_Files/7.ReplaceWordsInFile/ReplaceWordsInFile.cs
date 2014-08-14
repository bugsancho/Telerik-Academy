using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class ReplaceWordsInFile
{
    static void Main()
    {
        StreamReader reader = new StreamReader("SampleText.txt");
        StreamWriter writer = new StreamWriter("ReplacementText.txt");
        string currentLine = "";
        using (reader)
        {
            using (writer)
            {
                while ((currentLine = reader.ReadLine()) != null)
                {

                    currentLine = currentLine.Replace("start", "finish");
                    //and here is the solution for task 8:
                    //currentLine = Regex.Replace(currentLine, @"\bstart\b", "finish");
                    writer.WriteLine(currentLine);
                }
            }
        }
    }
}

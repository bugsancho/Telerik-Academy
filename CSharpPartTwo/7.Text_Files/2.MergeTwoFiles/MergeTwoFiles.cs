using System;
using System.IO;
class MergeTwoFiles
{
    //Write a program that concatenates two text files into another text file.

    static void Main()
    {
        StreamReader firstFile = new StreamReader("firstFile.txt");
        StreamReader secondFile = new StreamReader("secondFile.txt");
        string currentLine = "";

        using (firstFile)
        {
            StreamWriter result = new StreamWriter("result.txt", false);
            using (result)
            {
                ;
                while ((currentLine = firstFile.ReadLine()) != null)
                {
                    result.WriteLine(currentLine);
                }
            }
        }
        using (secondFile)
        {
            StreamWriter result = new StreamWriter("result.txt", true);
            using (result)
            {
                
                while ((currentLine = secondFile.ReadLine()) != null)
                {
                    result.WriteLine(currentLine);
                }
            }
        }
    }
}

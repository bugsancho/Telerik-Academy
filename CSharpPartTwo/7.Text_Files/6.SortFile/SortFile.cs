using System;
using System.IO;
using System.Collections.Generic;
    class SortFile
    {
        //Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 
        static void Main()
        {
            StreamReader reader = new StreamReader("SampleFile.txt");
            StreamWriter writer = new StreamWriter("SortedFile.txt");
            List<string> names = new List<string>();
            string currentLine = "";
            using (reader)
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    names.Add(currentLine);
                }
            }
            names.Sort();
            using (writer)
            {
                foreach (string name in names)
                {
                    writer.WriteLine(name);
                }
            }
        }
    }

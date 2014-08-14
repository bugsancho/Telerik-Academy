using System;
using System.IO;
    class InsertLineNumbers
    {
        //Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

        static void Main()
        {
            StreamReader reader = new StreamReader("sampleFile.txt");
            StreamWriter writter = new StreamWriter("resultFile.txt");
            string currentLine = "";
            int counter = 1;
            using (reader)
            {
                using (writter)
                {
                    while ((currentLine = reader.ReadLine()) != null)
                    {

                        writter.Write("{0}. ", counter);
                        counter++;
                        writter.WriteLine(currentLine);

                    }
                }
            }
        }
    }

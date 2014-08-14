using System;
using System.IO;
    class CompareTwoFiles
    {
        //Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
        //Assume the files have equal number of lines.

        static void Main()
        {
            StreamReader firstReader = new StreamReader("firstFile.txt");
            StreamReader secondReader = new StreamReader("secondFile.txt");
            string currentFirstFileLine = "";
            string currentSecondFileLine = "";
            int identicalLines = 0;
            int differentLines = 0;
            using (firstReader)
            {
                using (secondReader)
                {
                    while ((currentSecondFileLine = secondReader.ReadLine()) != null && (currentFirstFileLine = firstReader.ReadLine()) != null)
                    {
                        if (currentFirstFileLine == currentSecondFileLine)
                        {
                            identicalLines++;
                        }
                        else
                        {
                            differentLines++;
                        }
                    }
                }
            }
            Console.WriteLine(identicalLines + " " + differentLines);
        }
    }

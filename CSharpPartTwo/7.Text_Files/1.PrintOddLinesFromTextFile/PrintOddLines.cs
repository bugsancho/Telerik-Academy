using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class PrintOddLines
{
    //Write a program that reads a text file and prints on the console its odd lines.
    static void Main()
    {
        try
        {
            using (StreamReader readText = new StreamReader("sampleTxt.txt"))
            {
                int counter = 1;
                string line = readText.ReadLine();


                while (line != null)
                {
                    if (counter % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    line = readText.ReadLine();
                    counter++;
                }
            }
        }
        catch (Exception)
        {

            Console.WriteLine("An error occured while reading the file");
        }

    }
}
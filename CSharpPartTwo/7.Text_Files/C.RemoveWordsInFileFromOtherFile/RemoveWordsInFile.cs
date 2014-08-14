using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
    class RemoveWordsInFile
    {//Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.

        static void Main()
        {
            string dictionaryPath = "dictionary.txt";
            string filePath = "SampleText.txt";
            string tempFile = Path.GetTempFileName();
            List<string> dictionary = new List<string>();
            try
            {
                StreamReader dictionaryReader = new StreamReader(dictionaryPath);
                StreamReader fileReader = new StreamReader(filePath);
                using (dictionaryReader)
                {
                    string line;
                    while ((line = dictionaryReader.ReadLine()) != null)
                    {
                        string[] words = line.Split(' ');
                        foreach (var word in words)
                        {
                            dictionary.Add(word);
                        }
                    }
                    using (fileReader)
                    {
                        using (var writer = new StreamWriter(tempFile))
                        {
                            string currentLine;
                            while ((currentLine = fileReader.ReadLine()) != null)
                            {
                                foreach (var word in dictionary)
                                {
                                    currentLine = Regex.Replace(currentLine, @"\b" + word + @"\b", "");
                                }
                                writer.WriteLine(currentLine);
                            }
                        }
                    }
                }
                File.Delete(filePath);
                File.Move(tempFile, filePath);
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("The file was not found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("There was a problem reading the file.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
        }
    }

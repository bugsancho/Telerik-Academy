using System;
using System.Text;
using System.IO;
using System.Security;
    class ReadAllTextMethod
    {
        //Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
        //Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.

        static void Main()
        {
            Console.WriteLine("This program reads the contents of a text file if possible or returns correspoding error messages.");
            Console.WriteLine("Please enter the path for the file:");
            string path = Console.ReadLine();
            try
            {
                string text = File.ReadAllText(path);
                Console.WriteLine("The file reads as follows: ");
                Console.WriteLine(text);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please enter a path!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a valid path!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered path is too long!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The directory you pointed at was not found!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found!");
            }
            catch (IOException)
            {
                Console.WriteLine("The file could not be read!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The format of the file is not supported!");
            }
            catch (SecurityException)
            {
                Console.WriteLine("You dont have permission to access that file!");
            }

        }
    }

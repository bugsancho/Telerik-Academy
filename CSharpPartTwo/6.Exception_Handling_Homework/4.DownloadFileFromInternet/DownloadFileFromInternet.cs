using System;
using System.Net;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;
    class DownloadFileFromInternet
    {
        //Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
        //Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

        static void Main()
        {
            using(WebClient client = new WebClient())
            {
                try
                {
                    Console.WriteLine("This program downloads a file from the internet and opens it!");
                    Console.WriteLine("Please enter the URL of the file you want to download:");
                    string URL = Console.ReadLine();
                    Console.WriteLine("Now please enter the name of the file as you would like to save it(mind including the file extension (e.g.: .txt)): ");
                    string fileName = Console.ReadLine();
                    //string URL = "http://www.devbg.org/img/Logo-BASD.jpg";
                    //string fileName = "logo.jpg";
                    client.DownloadFile(URL, fileName);
                    Process.Start(fileName);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Please enter a proper URL!");
                }
                catch (WebException)
                {
                    Console.WriteLine("There was a problem with your download!");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("Your file cannot be downloaded right now!");
                }
                catch (ObjectDisposedException)
                {
                    Console.WriteLine("The file isn't available anymore!");
                }
                catch (Win32Exception)
                {
                    Console.WriteLine("The file could not be opened!");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("The file was not found at the pointed location!");
                }
            }
        }
    }

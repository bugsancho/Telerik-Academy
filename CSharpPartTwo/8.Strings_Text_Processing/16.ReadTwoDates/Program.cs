using System;
using System.Collections.Generic;
using System.Text;
    class Program
    {
        //Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
        static void Main()
        {
            Console.WriteLine("This program reads two dates in the format day.month.year and calculates the days between them.");
            Console.WriteLine("Please enter the first date:");
            try
            {
                DateTime firstDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Now enter the second date:");
                DateTime secondDate = DateTime.Parse(Console.ReadLine());
                Console.Write("The days between the two dates are: ");
                if (firstDate.CompareTo(secondDate) < 0)
                {
                    Console.WriteLine((secondDate - firstDate).Days);
                    return;
                }
                Console.WriteLine((firstDate - secondDate).Days);
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Invalid input!");
                Main();
                return;
            }
            

        }
    }
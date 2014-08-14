using System;
    class NumberMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            int numberOfRows = 1;
            int numberOfColumns = number;

            for (int j = 1; j <= number; j++)
            {
                for (int i = numberOfRows; i <= numberOfColumns; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                numberOfRows++;
                numberOfColumns++;
            }
        }
    }


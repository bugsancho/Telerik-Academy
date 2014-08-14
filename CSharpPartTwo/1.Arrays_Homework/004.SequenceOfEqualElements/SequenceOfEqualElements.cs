using System;
    class SequenceOfEqualElements
    {
        //Write a program that finds the maximal sequence of equal elements in an array.

        static void Main()
        {
            Console.WriteLine("Please enter how many elements long you want the array to be:");
            string input = Console.ReadLine();
            int arrayLength;
            int longestStreak = 1;
            int currentStreak = 1;
            int streakNumber = 0;
            while (!(int.TryParse(input, out arrayLength)) || input[0] == '-')                 //checking if the input data is a positive integer
            {
                Console.WriteLine("Please enter a valid, positive integer number!");
                input = Console.ReadLine();
            }
            Console.WriteLine("Now enter {0} numbers for the array:", arrayLength); 
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)                                              //here we fill the array
            {
                input = Console.ReadLine();
                int arrayNumber;
                while (!int.TryParse(input, out arrayNumber))
                {
                    Console.WriteLine("Please enter a valid integer number!");
                    input = Console.ReadLine();
                }
                array[i] = arrayNumber;
            }
            streakNumber = array[0];
            for (int i = 1; i < arrayLength; i++)
            {
                if (array[i] == array[i-1])
                {
                    currentStreak++;
                }
                else
                {
                    currentStreak = 1;
                }
                if (currentStreak > longestStreak)
                {
                    longestStreak = currentStreak;
                    streakNumber = array[i];
                }
            }
            if (longestStreak == 1)
            {
                Console.WriteLine("There are no repeating elements in the array given!");
            }
            else
            {
                Console.Write("The longest streak of equal numbers in the array given is: ");
                for (int i = 0; i < longestStreak; i++)
                {
                    Console.Write(" {0}", streakNumber);
                }
                Console.WriteLine();
            } 
        }
    }


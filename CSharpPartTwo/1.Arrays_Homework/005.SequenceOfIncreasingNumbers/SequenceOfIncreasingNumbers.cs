using System;
class SequenceOfIncreasingNumbers
{
    //Write a program that finds the maximal increasing sequence in an array. 
    //Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


    static void Main()
    {
        Console.WriteLine("Please enter how many elements long you want the array to be:");
        string input = Console.ReadLine();
        int arrayLength;
        int longestStreak = 1;
        int currentStreak = 1;
        int streakNumber = 0;
        bool isItAStreak = false;
        while (!(int.TryParse(input, out arrayLength)) || input[0] == '-')                 
        {
            Console.WriteLine("Please enter a valid, positive integer number!");
            input = Console.ReadLine();
        }
        Console.WriteLine("Now enter {0} numbers for the array:", arrayLength);
        int[] array = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)                                              
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
            if (array[i] - 1 == array[i - 1])
            {
                currentStreak++;
            }
            else
            {
                isItAStreak = false;
                currentStreak = 1;
            }
            if (currentStreak >= longestStreak)
            {
                longestStreak = currentStreak;

                if (!isItAStreak)
                {
                    streakNumber = i - 1;
                    isItAStreak = true;
                }

            }
        }
        if (longestStreak == 1)
        {
            Console.WriteLine("There are no increasing elements in the array given!");
        }
        else
        {
            Console.Write("The longest streak of increasing numbers in the array given is: ");
            for (int i = 0; i < longestStreak; i++)
            {
                Console.Write(" {0}", array[streakNumber]);
                streakNumber++;

            }
            Console.WriteLine();
        }
    }
}


using System;
    class MostFrequentElement
    {
        //Write a program that finds the most frequent number in an array. Example:
	    //{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

        static void Main()
        {
            string input = "";
            int arrayLength;
            int currentNumberOfRepetitions = 1;
            int maxNumberOfRepetitions = 1;
            int Number = 0;

            Console.WriteLine("Please enter how many elements long you want the array to be:");
            input = Console.ReadLine();
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

            Array.Sort(array);

            for (int i = 1; i < arrayLength; i++)
            {
                if (array[i] == array[i-1])
                {
                    currentNumberOfRepetitions++;
                }
                else
                {
                    currentNumberOfRepetitions = 1;
                }
                if (currentNumberOfRepetitions > maxNumberOfRepetitions)
                {
                    maxNumberOfRepetitions = currentNumberOfRepetitions;
                    Number = array[i];
                }
            }

            Console.WriteLine("The most frequent number in the array is {0}, which apears {1} times!",Number,maxNumberOfRepetitions);
        }
    }


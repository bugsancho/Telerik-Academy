using System;
    class BinarySearchAlgorithm
    {
        //Write a program that finds the index of given element in a sorted array of integers
        //by using the binary search algorithm (find it in Wikipedia).

        static void Main()
        {
            string input = "";
            int arrayLength;
            int searchBeginning = 0;
            int searchedNumber = 0;
            int searchEnding = 0;
            int middle = 0;

            Console.WriteLine("Please enter how many elements long you want the array to be:");
            input = Console.ReadLine();
            while (!(int.TryParse(input, out arrayLength)) || input[0] == '-')
            {
                Console.WriteLine("Please enter a valid, positive integer number!");
                input = Console.ReadLine();
            }
            Console.WriteLine("Now enter the desired number:");
            input = Console.ReadLine();
            while (!int.TryParse(input, out searchedNumber) || input[0] == '-')
            {
                Console.WriteLine("Please enter a valid, positive integer number!");
                input = Console.ReadLine();
            }

            Console.WriteLine("And now enter {0} numbers for the array:", arrayLength);
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
            searchEnding = array.Length -1;
            while (searchBeginning <= searchEnding)
            {
                middle = (searchBeginning + searchEnding) / 2;
                if (array[middle] == searchedNumber)
                {
                    Console.WriteLine("The index of the searched number is: {0}!", middle);
                    return;
                }

                if (array[middle] < searchedNumber)
                {
                    searchBeginning = middle + 1;
                }

                if (array[middle] > searchedNumber)
                {
                    searchEnding = middle - 1;
                }
            }
            Console.WriteLine("There is no such number in the array!");
        }
    }


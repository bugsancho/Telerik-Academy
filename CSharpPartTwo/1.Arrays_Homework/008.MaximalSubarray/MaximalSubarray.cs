using System;
    class MaximalSubarray
    {
    
    //Write a program that finds the sequence of maximal sum in given array. Example:
	//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	//Can you do it with only one loop (with single scan through the elements of the array)?


        static void Main()
        {
            string input = "";
            int arrayLength;
            int currentSum = 0;
            int maxSum = 0;
            int startIndex = 0;
            int endingIndex = 0;
            int tempStartIndex = 0;

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

            currentSum = array[0];
            maxSum = array[0];

            for (int i = 1; i < arrayLength; i++)
            {
                if (currentSum >= 0)
                {
                    currentSum += array[i];
                    
                }
                else
                {
                    currentSum = array[i];
                    tempStartIndex = i;
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startIndex = tempStartIndex;
                    endingIndex = i;
                    
                }

            }

            Console.Write("The maximal subarray sum is: {0} and the subarray is:", maxSum);
            for (int i = startIndex; i <= endingIndex; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
        }
    }


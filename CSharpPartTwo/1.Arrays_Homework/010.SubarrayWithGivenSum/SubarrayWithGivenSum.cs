using System;
    class SubarrayWithGivenSum
    {
        //Write a program that finds in given array of integers a sequence of given sum S (if present). 
        //Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	

        static void Main()
        {
            string input = "";
            int arrayLength;
            int currentSum = 0;
            int desiredSum = 0;
            int endingIndex = 0;
            int StartIndex = 0;

            Console.WriteLine("Please enter how many elements long you want the array to be:");
            input = Console.ReadLine();
            while (!(int.TryParse(input, out arrayLength)) || input[0] == '-')
            {
                Console.WriteLine("Please enter a valid, positive integer number!");
                input = Console.ReadLine();
            }
            Console.WriteLine("Now enter the desired sum:");
            input = Console.ReadLine();
            while (!int.TryParse(input, out desiredSum) || input[0] == '-')
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


            for (int i = 0; i < arrayLength; i++)
            {
                if (currentSum < desiredSum)
                {
                    currentSum += array[i];

                }
                else if (currentSum == desiredSum)
                {
                    endingIndex = i - 1;
                    Console.Write("The subarray with the given sum is:");
                    for (int j = StartIndex; j <= endingIndex; j++)
                    {
                        Console.Write(" " + array[j]);
                    }
                    Console.WriteLine();
                    return;
                }
                else
                {
                    currentSum -= array[StartIndex];
                    StartIndex++;
                    i--;
                }
            }
            Console.WriteLine("There is no subarray with the given sum!");
        }
    }


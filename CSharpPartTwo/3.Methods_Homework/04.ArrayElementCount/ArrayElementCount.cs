using System;
    class ArrayElementCount
    {
        //Write a method that counts how many times given number appears in given array.
        //Write a test program to check if the method is working correctly.

        static void Main()
        {
            int[] array = new int[] { 8, 3, 7, 345, 76, 4, 4, 34, 5, 7, 9, 3, 2, 22, 4, 5, 76, 43, 2, 0, 11, 1, 2, 3 };
            Console.WriteLine("Please enter the number you are looking for: ");
            int searchedNumber = int.Parse(Console.ReadLine());
            int numberOfRepetitions = CheckNumberOfRepetitions(array,searchedNumber);
            Console.WriteLine("The number {0} apears {1} times in the array.",searchedNumber,numberOfRepetitions);
        }

        private static int CheckNumberOfRepetitions(int[] array, int searchedNumber)
        {
            int numberOfRepetitions = 0;
            foreach (int number in array)
            {
                if (number == searchedNumber)
                {
                    numberOfRepetitions++;
                }
            }
            return numberOfRepetitions;
        }
    }


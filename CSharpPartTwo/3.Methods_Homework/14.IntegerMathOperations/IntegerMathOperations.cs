using System;
    class IntegerMathOperations
    {
        //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

        static void Main()
        {
            int[] array = new int[] { 2, 5, 8, 3, 2, 45, 67, 9, 64, 3, 2, 34, 56, 7, 89, 0 };
            Console.WriteLine("The greatest element in the array is: {0}", GetMax(array));
            Console.WriteLine("The smallest element in the array is: {0}", GetMin(array));
            Console.WriteLine("The avarage element in the array is: {0}", GetAvarage(array));
            Console.WriteLine("The sum of the elements in the array is: {0}", GetSum(array));

        }

        private static int GetMin(int[] array)
        {
            int minNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minNumber)
                {
                    minNumber = array[i];
                }
            }
            return minNumber;
        }
        private static int GetMax(int[] array)
        {
            int maxNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
            }
            return maxNumber;
        }
        private static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        private static double GetAvarage(int[] array)
        {
            return GetSum(array) /(double)array.Length;
        }


    }

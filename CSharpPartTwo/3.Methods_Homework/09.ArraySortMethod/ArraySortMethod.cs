using System;
    class ArraySortMethod
    {
        //Write a method that return the maximal element in a portion of array of integers starting at given index. 
        //Using it write another method that sorts an array in ascending / descending order.

        static void Main()
        {
            int[] array = new int[] { 5, 3, 1, 4, 6, 8, 5, 32, 4, 5, 67, 3, 2, 34, 56, 8, 98, 54, 2, 3, 4, 56, 2, 14, 6 };
            Console.WriteLine("Please enter the intex of the number to look up: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("The greatest element in the selected portion of the array is: ");
            Console.WriteLine(GetMaxElement(array, index));
            int[] arraySorted = SortArray(array);
            Console.WriteLine("The array, sorted looks like: ");
            for (int i = 0; i < arraySorted.Length; i++)
            {
                Console.Write(arraySorted[i] + " ");
            }
        }

        private static int GetMaxElement(int[] array, int index)
        {
            int maxElement = array[index];
            for (int i = index; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }
            return maxElement;
        }
        static int[] SortArray(int[] array)
        {
            int maximalElement = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                maximalElement = GetMaxElement(array, i);
                array[i] = maximalElement;
                maximalElement = int.MinValue;
            }
            return array;
        }
    }

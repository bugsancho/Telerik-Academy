using System;
class MaximalSUmOfSubarray
{   //Write a program that reads a rectangular matrix of size N x M 
    // and finds in it the square 3 x 3 that has maximal sum of its elements.



    static void Main()
    {   //Here we get the matrix, hardcoded to ease the revision of the task.
        int[,] matrix = new int[,]    {{1,2,0,6,9,9,5},
                                       {2,3,1,3,6,7,5},
                                       {5,2,7,4,7,9,3},
                                       {2,5,8,4,6,2,9},
                                       {8,2,4,6,7,5,9}};

        int currentSum = 0;
        int maxSum = 0;
        int maxSumStartRow = 0;
        int maxSumStartColumn = 0;
        //Here we check the sum of all subarrays using the method implemented below 
        // and save in variables the coordinates of the subarray with the greatest sum and the sum itself.
        for (int startRow = 0; startRow <= matrix.GetLength(0) - 3; startRow++)
        {
            for (int startColumn = 0; startColumn <= matrix.GetLength(1) - 3; startColumn++)
            {
                currentSum = SumOfSubarray(matrix, startRow, startColumn);
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumStartRow = startRow;
                    maxSumStartColumn = startColumn;

                }
            }
        }
        //Here we print the result. First we print the sum and then the actual subarray.
        Console.WriteLine("The maximal sum of a subarray of size(3x3) in the matrix given is: {0}", maxSum);
        Console.WriteLine("And the subarray is: ");
        for (int i = maxSumStartRow; i < maxSumStartRow + 3; i++)
        {
            for (int j = maxSumStartColumn; j < maxSumStartColumn + 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    //And this is the method that gets the sum of the elements of a (3x3) matrix that starts from the given coordiates in the array.
    static int SumOfSubarray(int[,] matrix, int startRow, int startColumn)
    {
        int sum = 0;

        for (int currentRow = startRow; currentRow < startRow + 3; currentRow++)
        {
            for (int currentColumn = startColumn; currentColumn < startColumn + 3; currentColumn++)
            {
                sum += matrix[currentRow, currentColumn];
            }
        }
        return sum;
    }


}


using System;
using System.IO;
class MaximalSUmOfSubarray
{
    //Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
    //The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. 
    //The output should be a single number in a separate text file



    static void Main()
    {   //Here we get the matrix, hardcoded to ease the revision of the task.
        int[,] matrix = ReadMatrix();
            
            //new int[,]    {{1,2,0,6,9,9,5},
                        //               {2,3,1,3,6,7,5},
                        //               {5,2,7,4,7,9,3},
                        //               {2,5,8,4,6,2,9},
                        //               {8,2,4,6,7,5,9}};

        int currentSum = 0;
        int maxSum = 0;
        int maxSumStartRow = 0;
        int maxSumStartColumn = 0;
        //Here we check the sum of all subarrays using the method implemented below 
        // and save in variables the coordinates of the subarray with the greatest sum and the sum itself.
        for (int startRow = 0; startRow <= matrix.GetLength(0) - 2; startRow++)
        {
            for (int startColumn = 0; startColumn <= matrix.GetLength(1) - 2; startColumn++)
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
        Console.WriteLine("The maximal sum of a subarray of size(2x2) in the matrix given is: {0}", maxSum);
        Console.WriteLine("And the subarray is: ");
        for (int i = maxSumStartRow; i < maxSumStartRow + 2; i++)
        {
            for (int j = maxSumStartColumn; j < maxSumStartColumn + 2; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] ReadMatrix()
    {
        StreamReader matrixReader = new StreamReader("MatrixFile.txt");
        using (matrixReader)
        {
            int matrixDimensions = int.Parse(matrixReader.ReadLine());
            int[,] matrix = new int[matrixDimensions,matrixDimensions];

            
            for (int i = 0; i < matrixDimensions; i++)
            {
                string[] numbers = matrixReader.ReadLine().Split();
                for (int j = 0; j < matrixDimensions; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }
            }
            return matrix;
        }
    }

    //And this is the method that gets the sum of the elements of a (2x2) matrix that starts from the given coordiates in the array.
    static int SumOfSubarray(int[,] matrix, int startRow, int startColumn)
    {
        int sum = 0;

        for (int currentRow = startRow; currentRow < startRow + 2; currentRow++)
        {
            for (int currentColumn = startColumn; currentColumn < startColumn + 2; currentColumn++)
            {
                sum += matrix[currentRow, currentColumn];
            }
        }
        return sum;
    }


}
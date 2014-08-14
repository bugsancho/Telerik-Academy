using System;
    class MatrixA
    {
        //Write a program that fills and prints a matrix of size (n, n)
        //as in the examples shown in the presentation.

        static void Main()
        {  
            Console.WriteLine("Please enter a number N for the dimensions of the matrix(n x n):");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int numberOfMatrix = 1;
            //Here we fill the array, using a variable that increases its value each time a number is assigned.
            //The array is filled using a loop that fills each column and when it reaches the last row,
            // moves to the top of the next column.
            for (int columns = 0; columns < size; columns++)
            {
                for (int rows = 0; rows < size; rows++)
                {
                    matrix[rows, columns] = numberOfMatrix;
                    numberOfMatrix++;
                }
            }
            //The following loop is used to print the array.
            for (int rows = 0; rows < size; rows++)
            {
                for (int columns = 0; columns < size; columns++)
                {
                    Console.Write(matrix[rows,columns] + " ");
                }
                Console.WriteLine();
            }
        }
    }


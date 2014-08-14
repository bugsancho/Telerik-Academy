using System;
    class MatrixC
    {
        //Write a program that fills and prints a matrix of size (n, n)
        //as in the examples shown in the presentation.

        static void Main()
        {
            Console.WriteLine("Please enter a number 'n' for the dimensions of the matrix(n x n):");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int numberOfMatrix = 1;
            //The following loop is used to fill the bottom-left half of the matrix using the algorithm described.
            for (int rows = 0; rows <= size - 1; rows++)
            {
                for (int columns = 0; columns <= rows; columns++)
                {
                    matrix[size - rows + columns - 1, columns] = numberOfMatrix;
                    numberOfMatrix++;
                }
            }
            //This set of nested loops is used to fill the remaining top-right part of the matrix using the algorithm you can see below.
           for (int rows = size - 2; rows >= 0; rows--)
           {
               for (int columns = rows; columns >= 0; columns--)
               {
                   matrix[rows - columns, size - columns - 1] = numberOfMatrix;
                   numberOfMatrix++;
               }
           }
            //Print the array.
            for (int rows = 0; rows < size; rows++)
            {
                for (int columns = 0; columns < size; columns++)
                {
                    Console.Write(matrix[rows, columns] + " ");
                }
                Console.WriteLine();
            }
        }        
    }


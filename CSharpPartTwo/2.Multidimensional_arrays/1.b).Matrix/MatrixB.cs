using System;
    class MatrixB
    {
        //Write a program that fills and prints a matrix of size (n, n)
        //as in the examples shown in the presentation.

        static void Main()
        {
            Console.WriteLine("Please enter a number N for the dimensions of the matrix(n x n):");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int numberOfMatrix = 1;
            //Here use the same trick with a variable to fill the array, but the algorithm is the following:
            //The even-numbered columns are filled from the top to the bottom, and odd-numbered columns - from the bottom to the top.
            for (int columns = 0; columns < size; columns++)
            {
                if (columns % 2 == 0)
                {
                    for (int rows = 0; rows < size; rows++)
                    {
                        matrix[rows, columns] = numberOfMatrix;
                        numberOfMatrix++;
                    }
                }
                else
                {
                    for (int rows = size-1; rows >= 0; rows--)
                    {
                        matrix[rows, columns] = numberOfMatrix;
                        numberOfMatrix++;
                    }
                }
            }
            //And again the same loop used for the printing.
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


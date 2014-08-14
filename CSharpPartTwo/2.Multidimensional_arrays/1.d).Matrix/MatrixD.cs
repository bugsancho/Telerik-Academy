using System;
    class MatrixD
    {
        //Write a program that fills and prints a matrix of size (n, n)
        //as in the examples shown in the presentation.

        static void Main()
        {
            Console.WriteLine("Please enter a positive integer number 'n' for the dimensions of the matrix(n x n):");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int numberOfMatrix = 1;
            int currentRow = 0;
            int currentColumn = 0;
            //The direction of the spiral is determined by the following string, 
            //that has values conviniently set for the actual english wording of the direction it is assigned to.
            string direction = "down";
            //Here we use a while loop, that loops until we have generated enough numbers to fill the given matrix.
            while (numberOfMatrix <= size*size)
            {
                //First we check if we have reached the boundaries of the matrix or an already filled 'cell' 
                //and change the direction accordingly, if necessary.
                if (direction == "down" && (currentRow == size - 1 || matrix[currentRow + 1, currentColumn] != 0))
                {
                    direction = "right";
                }
                else if (direction == "right" && (currentColumn == size - 1 || matrix[currentRow,currentColumn+1] != 0))
                {
                    direction = "up";
                }
                else if (direction == "up" && (currentRow == 0 || matrix[currentRow -1, currentColumn] != 0))
                {
                    direction = "left";
                }
                else if (direction == "left" && (currentColumn == 0 || matrix[currentRow, currentColumn - 1] != 0))
                {
                    direction = "down";
                }
                //After having the direction properly set, we fill the current 'cell' and then continue in the apropriate direction.
                if (direction == "down")
                {
                    matrix[currentRow, currentColumn] = numberOfMatrix;
                    numberOfMatrix++;
                    currentRow++;
                }
                else if (direction == "right")
                {
                    matrix[currentRow, currentColumn] = numberOfMatrix;
                    numberOfMatrix++;
                    currentColumn++;
                }
                else if (direction == "up")
                {
                    matrix[currentRow, currentColumn] = numberOfMatrix;
                    numberOfMatrix++;
                    currentRow--;
                }
                else //if (direction == "left")
                {
                    matrix[currentRow, currentColumn] = numberOfMatrix;
                    numberOfMatrix++;
                    currentColumn--;
                }
            }
            //And finally we print the matrix.
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


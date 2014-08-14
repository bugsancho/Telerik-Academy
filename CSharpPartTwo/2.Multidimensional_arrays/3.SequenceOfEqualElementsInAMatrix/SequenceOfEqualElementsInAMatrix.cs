using System;
class SequenceOfEqualElementsInAMatrix
{
    //We are given a matrix of strings of size N x M.
    //Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
    //Write a program that finds the longest sequence of equal strings in the matrix. 
    
    //With this method we check ifthe next element in the same row is the same
    //and return the number of equal elements in the row.
    static int CheckHorizontally(string[,] matrix, int startRow, int startCol)
    {
         int streak = 0;
            for (int currentCol = startCol +1; currentCol <= matrix.GetLength(1) -1; currentCol++)
			{
                if (matrix[startRow, startCol] == matrix[startRow, currentCol])
                {
                    streak++;
                }
                else
                {
                    return streak;
                }
			}
            return streak;
    }
    //We do the same here, but checking the columns in the array.
    static int CheckVertically(string[,] matrix, int startRow, int startCol)
    {
        int streak = 0;
        for (int currentRow = startRow + 1; currentRow <= matrix.GetLength(0) - 1; currentRow++)
        {
            if (matrix[startRow, startCol] == matrix[currentRow, startCol])
            {
                streak++;
            }
            else
            {
                return streak;
            }
        }
        return streak;
    }
    //here we check using the same technique the diagonal that goes from the top left corner to the bottom right(aproximately).
    static int CheckDiagonalTopLeft(string[,] matrix, int startRow, int startCol)
    {
        int streak = 0;
        for (int currentRow = startRow + 1, currentCol = startCol+1; 
            currentRow <= matrix.GetLength(0) -1 && currentCol <= matrix.GetLength(1) -1; 
            currentRow++, currentCol++)
        {
            if (matrix[startRow, startCol] == matrix[currentRow, currentCol])
            {
                streak++;
            }
            else
            {
                return streak;
            }
        }
        return streak;
    }
    //And this method checks the top right - bottom left diagonal.
    static int CheckDiagonalTopRight(string[,] matrix, int startRow, int startCol)
    {
        int streak = 0;
        for (int currentRow = startRow + 1, currentCol = startCol - 1;
            currentRow < matrix.GetLength(0) && currentCol >= 0;
            currentRow++, currentCol--)
        {
            if (matrix[startRow, startCol] == matrix[currentRow, currentCol])
            {
                streak++;
            }
            else
            {
                return streak;
            }
        }
        return streak;
    }
    //And this is the 'mother' method that uses all the methods above and compares the length of
    //all sequences of equal elements and returns the greatest.
    static int CheckNextElement(string[,] matrix, int startRow, int StartCol)

    {        
        int horizontalStreak = CheckHorizontally(matrix, startRow, StartCol);
        int verticalStreak = CheckVertically(matrix, startRow, StartCol);
        int diagonalLeftStreak = CheckDiagonalTopLeft(matrix, startRow, StartCol);
        int diagonalRightStreak = CheckDiagonalTopRight(matrix, startRow, StartCol);
        int maxStreak = Math.Max(Math.Max(horizontalStreak, verticalStreak),Math.Max(diagonalLeftStreak,diagonalRightStreak));
        return maxStreak;
    }

    static void Main()
    {//Here we get the input data, again hardcoded to ease the revision of the task.
        string[,] matrix = {{"bla","ba","bla","la"},
                            {"hey","ba","la","hey"},
                            {"bla","la","ba","ho"}};
        int currentStreak = 0;
        int maxStreak = 0;
        string streakElement = "";
        //here we go through the array and check all neighbouring elements using the methods implemented above.
        for (int currentRow = 0; currentRow <= matrix.GetLength(0) -1; currentRow++)
        {
            for (int currentCol = 0; currentCol <= matrix.GetLength(1) -1; currentCol++)
            {
               currentStreak = CheckNextElement(matrix,currentRow,currentCol);
               if (maxStreak < currentStreak)
               {
                   maxStreak = currentStreak;
                   streakElement = matrix[currentRow, currentCol];
               }
               currentStreak = 0;
            }
        }
        //and here we print the result.
        Console.WriteLine("The longest streak of equal elements in the matrix given is: {0}",maxStreak +1);
        Console.WriteLine("And it is:");
        for (int i = 0; i <= maxStreak; i++)
        {
            Console.Write(streakElement + " ");
        }
        Console.WriteLine();
        
    }
}
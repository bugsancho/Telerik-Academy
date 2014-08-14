using System;
using System.Collections.Generic;
//Couldn't push it past 70 points":(
//http://bgcoder.com/Contest/Practice/95
class SpecialValue
{
    static List<List<int>> numbers = new List<List<int>>();
    static List<List<bool>> isVisited = new List<List<bool>>();
    static void Main()
    {
        int maxSum = 1;
        int currentSum;
        int numberOfRows = int.Parse(Console.ReadLine());
        ReadInput(numberOfRows);

        int row = 0;
        int nextRow = 0;
        int nextCol =0;
        for (int col = 0; col < numbers[row].Count; col++)
        {
            currentSum = 1;
            int currentCol = col;
            while (numbers[row][currentCol] >= 0 && !isVisited[row][currentCol])
            {
                nextCol = numbers[row][currentCol];

                isVisited[row][currentCol] = true;

                if (row + 1 < numbers.Count)
                {
                    nextRow = row + 1;
                }
                else
                {
                    nextRow = 0;
                }
                currentSum++;

                currentCol = nextCol;
                row = nextRow;

            }
            currentSum += Math.Abs(numbers[row][currentCol]); 
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }

            ReinitializeBoolArray();
            row = 0;
        }

        Console.WriteLine(maxSum);
    }

    private static void ReinitializeBoolArray()
    {
        for (int i = 0; i < isVisited.Count; i++)
        {
            for (int j = 0; j < isVisited[i].Count; j++)
            {
                isVisited[i][j] = false;
            }
        }
    }

    private static void ReadInput(int numberOfRows)
    {
        for (int row = 0; row < numberOfRows; row++)
        {
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            numbers.Add(new List<int>(inputNumbers.Length));
            isVisited.Add(new List<bool>(inputNumbers.Length));
            for (int col = 0; col < inputNumbers.Length; col++)
            {
                numbers[row].Add(int.Parse(inputNumbers[col]));
                isVisited[row].Add(false);
            }
        }
    }
}

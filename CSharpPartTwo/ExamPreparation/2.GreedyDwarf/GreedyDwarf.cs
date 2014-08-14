using System;
using System.Collections.Generic;
class GreedyDwarf
{
    //http://bgcoder.com/Contest/Practice/92

    private static int mostCoins = 0;
    private static List<int> numbers = new List<int>();
    private static List<List<int>> pattern = new List<List<int>>();
    private static List<List<bool>> isVisited = new List<List<bool>>();
    static void Main()
    {
        ReadValues(numbers);
        int numberOfPatterns = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfPatterns; i++)
        {
            pattern.Add(new List<int>());
            ReadValues(pattern[i]);
        }
        FillBoolArray(pattern, isVisited);
        for (int i = 0; i < pattern.Count; i++)
        {
            int currentCoins = CheckPattern(pattern[i], isVisited[i]);
            if (i == 0)
            {
                mostCoins = currentCoins;
            }
            else if (currentCoins > mostCoins)
            {
                mostCoins = currentCoins;
            }
        }
        Console.WriteLine(mostCoins);
    }

    private static int CheckPattern(List<int> pattern, List<bool> visited)
    {
        int index = 0;
        int coins = 0;
        int patternCounter = 0;
        
        while (index < numbers.Count && index >=0 && !visited[index])
        {
            coins += numbers[index];
            visited[index] = true;
            if (patternCounter == pattern.Count)
            {
                patternCounter = 0;
            }
            index += pattern[patternCounter];
            patternCounter++;
        }
        return coins;
    }

    private static void FillBoolArray(List<List<int>> pattern, List<List<bool>> isVisited)
    {
        for (int i = 0; i < pattern.Count; i++)
        {
            isVisited.Add(new List<bool>());
            for (int j = 0; j < numbers.Count; j++)
            {
                isVisited[i].Add(false);
            }
        }
    }

    private static void ReadValues(List<int> numbers)
    {
        string input = Console.ReadLine();
        string[] bla = input.Split(new string[] { ", " }, StringSplitOptions.None);
        foreach (var item in bla)
        {
            numbers.Add(int.Parse(item));
        }
    }
}
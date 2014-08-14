using System;
using System.Collections.Generic;
using System.Text;
class MovingLetters
{
    static int maxWordLength = 0;
    static List<StringBuilder> wordsList = new List<StringBuilder>(); //stringBuilder
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split();
        for (int i = 0; i < words.Length; i++)
        {
            wordsList.Add(new StringBuilder());
            wordsList[i].Append(words[i]);
        }

        maxWordLength = GetMaxWordLength(wordsList);
        string extractedLetters = ExtractLetters(wordsList);
        string movedLetters = MoveLetters(extractedLetters);
        Console.WriteLine(movedLetters);
    }

    private static string MoveLetters(string extractedLetters)
    {
        StringBuilder workingLetters = new StringBuilder();
        char currentLetter = new char();
        workingLetters.Append(extractedLetters);

        int lengthOfCycle = workingLetters.Length;
        for (int i = 0; i < lengthOfCycle; i++)
        {
            int positionInAlphabet = 0;
            int positionInAscii = (byte)workingLetters[i];
            if (positionInAscii > 96)
            {
                positionInAlphabet = positionInAscii - 96;
            }
            else
            {
                positionInAlphabet = positionInAscii - 64;
            }
            currentLetter = workingLetters[i];
            workingLetters.Remove(i, 1);
            workingLetters.Insert((((positionInAlphabet % lengthOfCycle) + i) % lengthOfCycle), currentLetter);

        }

        return workingLetters.ToString();
    }



    private static int GetMaxWordLength(List<StringBuilder> words)
    {
        int maxLength = 0;
        int currentLength = 0;
        for (int i = 0; i < words.Count; i++)
        {
            currentLength = words[i].Length;
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }
        }
        return maxLength;
    }

    private static string ExtractLetters(List<StringBuilder> words)
    {
        StringBuilder extractedLetters = new StringBuilder();
        for (int numberOfCycles = 0; numberOfCycles < maxWordLength; numberOfCycles++)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length != 0)
                {
                    extractedLetters.Append(words[i][words[i].Length - 1]);
                    words[i] = words[i].Remove(words[i].Length - 1, 1);
                }
            }

        }
        return extractedLetters.ToString();
    }

}
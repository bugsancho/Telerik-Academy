
using System;
using System.Text;
public class MovingLettersSecond
{
   public static void AnotherMain()
    {
        string input = Console.ReadLine();
        string[] arrInputWords = input.Split();
        StringBuilder words = new StringBuilder();
        int maxLenWord = 0;
        int currentLenWord = 0;
        for (int i = 0; i < arrInputWords.Length; i++)
        {
            currentLenWord = arrInputWords[i].Length;
            if (currentLenWord > maxLenWord)
                maxLenWord = currentLenWord;
        }
        int counter = 0;
        while (counter <= maxLenWord - 1)
        {
            for (int i = 0; i < arrInputWords.Length; i++)
            {
                if (arrInputWords[i].Length > counter)
                words.Append(arrInputWords[i][arrInputWords[i].Length - 1 - counter]);
            }
            counter++;
        }
        char currentLetter = 'a';
        int indexLetter = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] >= 65 && words[i] <= 90)
            {
                indexLetter = words[i] - 65;
            }
            else
            {
                indexLetter = words[i] - 97;
            }
                currentLetter = words[i];
                //while (indexLetter + i >= words.Length)
                //{
                //    indexLetter = words.Length - indexLetter - 1;
                //}
                indexLetter= (indexLetter % (words.Length-1) + i) % (words.Length - 1);
                words.Remove(i, 1);
                words.Insert(indexLetter, currentLetter);
        }
        Console.WriteLine(words);
    }
}
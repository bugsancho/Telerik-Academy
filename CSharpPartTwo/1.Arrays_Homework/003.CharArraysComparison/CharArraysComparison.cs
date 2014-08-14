using System;
    class CharArraysComparison
    //Write a program that compares two char arrays lexicographically (letter by letter).

    {
        static void Main()
        {

            Console.WriteLine("Please enter the characters for the first array:");
            string firstText = Console.ReadLine();
            char[] firstArray = firstText.ToCharArray();
           
            Console.WriteLine("Please enter the characters for the second array:");
            string secondText = Console.ReadLine();
            char[] secondArray = secondText.ToCharArray();

            int minLength = Math.Min(secondArray.Length, firstArray.Length); 

            bool areTheArraysEqual = true;

            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    continue;
                }
                else
                {
                    areTheArraysEqual = false;
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine("The first char array comes lexicografically before the second.");
                    }
                    else
                    {
                        Console.WriteLine("The second char array comes lexicografically before the first.");
                    }
                    break;
                }                                          
            }
            if (areTheArraysEqual && firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("The first char array comes lexicografically before the second.");
            }
            else if (areTheArraysEqual && firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("The second char array comes lexicografically before the first.");
            }
            else if (areTheArraysEqual && firstArray.Length == secondArray.Length)
            {
                Console.WriteLine("The arrays are all the same.");
            }
            
        }       
    }


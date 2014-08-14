using System;
    class SortStringArrayByLength
    { 
        //You are given an array of strings. Write a method that sorts the array by the length of its elements
        //(the number of characters composing them).

        static void Main()
        {
            //We introduce a string array that needs to be sorted.
            string[] array = { "wazaaaaaaaaaaaaaaa", "blabla","mnaaaaaaa","Brum Brum", "Chooo Chooo","djv"};
            SortByLength(array);

            //And here we print all the elements, already arranged accordingly.
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        //The method below is used to sort a string array by creating a new int array 
        // that is filled with the lengths of the elements of the string array 
        // and then uses the int array as key for sorting the string one.
        static void SortByLength(string[] array)
        {
            int[] lengths = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                lengths[i] = array[i].Length;
            }
            Array.Sort(lengths, array);
            return;
        }
    }


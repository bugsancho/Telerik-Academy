using System;
    class FindNumbeUsingBinarySearch
    {
        //Write a program, that reads from the console an array of N integers and an integer K, 
        //sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

        static void Main()
        {
            //Here is a hard-coded array that eases the revision.
            int[] array = new int[] {2,6,8,3,6,75,23,6,8,53,43,2,5,0,1,-77,0,6,3,76,6,4 };
            Console.WriteLine("Please enter the number you are looking for: ");
            //here we get the number to search for.
            int searchedNumber = int.Parse(Console.ReadLine());
            int result = 0;
            Array.Sort(array);
            //Here we make a simple binary search and if the number is not found(returns a negative number)
            // we lower the number to look for until we reach a number that actualy apears in the array.
            while (true)
            {
                result = Array.BinarySearch(array, searchedNumber);
                if (result < 0)
                {
                    searchedNumber--;
                    continue;
                }
                else
                {
                    break;
                }
            }
            //This is the code that prints the position where the number, or the closest one is found.
            Console.WriteLine("The number {0} is found at index {1} in the array: ",searchedNumber,result);
           for (int i = 0; i < array.Length; i++)
           {
               Console.Write(array[i] + " ");
           }
           Console.WriteLine();
        }
    }


using System;
    class SelectionSortAlgorithm
    {
        //Sorting an array means to arrange its elements in increasing order.
        //Write a program to sort an array. Use the "selection sort" algorithm: 
        //Find the smallest element, move it at the first position, find the smallest from the rest, 
        //move it at the second position, etc.

        static void Main()
        {
            
            string input = "";                
            int arrayLength;
            int minNumber = 0;
            int indexMinNumber = 0;
            int tempPlaceHolder = 0;

            Console.WriteLine("Please enter how many elements long you want the array to be:");
            input = Console.ReadLine();
            while (!(int.TryParse(input, out arrayLength)) || input[0] == '-')                 
            {
                Console.WriteLine("Please enter a valid, positive integer number!");
                input = Console.ReadLine();
            }
            Console.WriteLine("Now enter {0} numbers for the array:", arrayLength);
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)                                              
            {
                input = Console.ReadLine();
                int arrayNumber;
                while (!int.TryParse(input, out arrayNumber))
                {
                    Console.WriteLine("Please enter a valid integer number!");
                    input = Console.ReadLine();
                }
                array[i] = arrayNumber;
            }
            Console.WriteLine("The array given, arranged by a selection sort algorithm looks like this:");
            minNumber = array[0];
            for (int i = 0; i <= arrayLength; i++)
            {
                
                for (int j = i; j < arrayLength; j++)
                {
                    if (array[j] < minNumber)
                    {
                        minNumber = array[j];
                        indexMinNumber = j;
                    }
                }
                if (arrayLength - 1 == i)
                {
                    Console.WriteLine(" " + array[i]);
                    break;
                }
                tempPlaceHolder = array[i];
                array[i] = minNumber;
                array[indexMinNumber] = tempPlaceHolder;
                Console.Write(" " + array[i]);
                minNumber = array[i + 1];
            }
        }
    }

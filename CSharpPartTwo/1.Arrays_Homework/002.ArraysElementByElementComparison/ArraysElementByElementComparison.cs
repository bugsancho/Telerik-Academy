using System;
    class ArraysElementByElementComparison
    //Write a program that reads two arrays from the console 
    //and compares them element by element.

    {
        static void Main()
        {
            Console.WriteLine("Please enter how many elements long you want the array to be:");
            string input = Console.ReadLine();
            int arrayLength;
            while (!(int.TryParse(input, out arrayLength)) || input[0] == '-')                 //checking if the input data is a positive integer
            {
                Console.WriteLine("Please enter a valid, positive integer number!");
                input = Console.ReadLine();
            }
            Console.WriteLine("Now enter {0} numbers for the first array:", arrayLength);      //here we define the length of the arrays
            int[] firstArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)                                              //and here we fill the first array
            {
                input = Console.ReadLine();
                int arrayNumber;
                while (!int.TryParse(input, out arrayNumber))
                {
                    Console.WriteLine("Please enter a valid integer number!");
                    input = Console.ReadLine();
                }
                firstArray[i] = arrayNumber;
            }
            Console.WriteLine("And now another {0} numbers for the second array:", arrayLength);       //same procedure for the second array
            int[] secondArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                input = Console.ReadLine();
                int arrayNumber;
                while (!int.TryParse(input, out arrayNumber))
                {
                    Console.WriteLine("Please enter a valid integer number!");
                    input = Console.ReadLine();
                }
                secondArray[i] = arrayNumber;
            }
            for (int i = 0; i < arrayLength; i++)                       //and below is the actual comparison of the elements
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("The {0}. number of the first array is greater than the {0}. number of the second!", i);
                }
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("The {0}. number of the first array is lesser than the {0}. number of the second!", i);
                }
                else
                {
                    Console.WriteLine("The {0}. numbers in both arrays are equal!", i);
                }
            }
        }
    }


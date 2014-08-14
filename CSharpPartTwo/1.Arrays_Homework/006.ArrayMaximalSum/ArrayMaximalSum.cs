using System;
    class ArrayMaximalSum
    {
        //Write a program that reads two integer numbers N and K and an array of N elements from the console.
        //Find in the array those K elements that have maximal sum.

        static void Main()
        {           
            string input = "";
            int arrayLength;
            int numberOfElements;
            int sumOfElements = 0;

            Console.WriteLine("Please enter how many elements long you want the array to be:");
            input = Console.ReadLine();
            while (!(int.TryParse(input, out arrayLength)) || input[0] == '-')                 
            {
                Console.WriteLine("Please enter a valid, positive integer number!");
                input = Console.ReadLine();
            }

            Console.WriteLine("And now how many elements you want to sum:");
            input = Console.ReadLine();            
            while (!int.TryParse(input, out numberOfElements) || input[0] == '-')
            {
                Console.WriteLine("Please enter a valid, positive integer number!");
                input = Console.ReadLine();
            }

            Console.WriteLine("Now enter {0} numbers for the array:", arrayLength);
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)                                              //here we fill the array
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

            Array.Sort(array);
            for (int i = 0; i < numberOfElements; i++)
            {
                sumOfElements += array[arrayLength-1];
                arrayLength--;
            }
            Console.WriteLine("The sum of the {0} greatest elements of the array given is: {1}", numberOfElements, sumOfElements);
        }
    }


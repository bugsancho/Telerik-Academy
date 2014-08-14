using System;         
    class ArrayMultipliedByIndex
    //Write a program that allocates array of 20 (N) integers
    //and initializes each element by its index multiplied by 5. 
    //Print the obtained array on the console. 

    {                       
        static void Main()  
        {
            Console.WriteLine("Enter how many numbers you want to print: ");
            string input = Console.ReadLine();
            int inputNumber;
           while (!(int.TryParse(input, out inputNumber)) || input[0] == '-')
            {
                Console.WriteLine("Please enter a valid, positive integer number!");
                input = Console.ReadLine();
           }
            int[] array = new int[inputNumber];
            Console.WriteLine("The first {0} numbers of the array, with their index multiplied by 5 are:", inputNumber);
            for (int i = 0; i < inputNumber; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }
        }
    }


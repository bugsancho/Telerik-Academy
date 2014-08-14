using System;
    class CombinationsGenerator
    {
        static void Main()
        {
        //Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
	    //N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

            string input = "";
            int n;
            int k;

            Console.WriteLine("Please enter a value for N:");
            input = Console.ReadLine();
            while (!(int.TryParse(input, out n)) || input[0] == '-')
            {
                Console.WriteLine("Please enter a valid, positive integer number!");
                input = Console.ReadLine();
            }
            Console.WriteLine("Please enter a value for K (must be lower than N:");
            input = Console.ReadLine();
            while (!(int.TryParse(input, out k)) || input[0] == '-' || int.Parse(input) > n)
            {
                Console.WriteLine("Please enter a valid, positive integer number, lower than {0}!",n);
                input = Console.ReadLine();
            }

            for (int i = 0; i < Math.Pow(n, k); i++)
            {
                int combinations = i;
                int[] number = new int[k];
                bool print = true;

                for (int j = 0; j < k; j++)
                {
                    number[k - j - 1] = combinations % n;
                    combinations = combinations / n;
                }

                for (int j = 1; j < number.Length; j++)
                {
                    if (number[j] <= number[j - 1])
                    {
                        print = false;
                    }
                }

                if (print)
                {
                    Console.Write(number[0] + 1);

                    for (int j = 1; j < k; j++)
                    {
                        Console.Write(", {0}", number[j] + 1);
                    }
                    Console.WriteLine();
                }

            }
        }
    }


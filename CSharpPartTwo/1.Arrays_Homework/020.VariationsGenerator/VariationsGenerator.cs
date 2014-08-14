using System;
class VariationsGenerator
{
    //Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	//N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

    static void Main()
    {
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
        Console.WriteLine("Please enter a value for K:");
        input = Console.ReadLine();
        while (!(int.TryParse(input, out k)) || input[0] == '-')
        {
            Console.WriteLine("Please enter a valid, positive integer number!");
            input = Console.ReadLine();
        }
        for (int i = 0; i < Math.Pow(n, k); i++)
        {
            int variation = i;
            int[] number = new int[k];
            for (int j = 0; j < k; j++)
            {
                number[k - j - 1] = variation % n;
                variation = variation / n;
            }
            Console.Write(number[0] + 1);

            for (int j = 1; j < k; j++)
            {
                Console.Write(", {0}", number[j] + 1);
            }
            Console.WriteLine();
        }
    }


}



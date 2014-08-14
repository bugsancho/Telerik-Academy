using System;
    class isPrimeNumberAlgorithm
    {
        //Write a program that finds all prime numbers in the range [1...10 000 000]. 
        //Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

        static void Main()
        {
            string input = "";
            int number;

            Console.WriteLine("Please what range you want to check for prime numbers:");
            input = Console.ReadLine();
            while (!(int.TryParse(input, out number)) || input[0] == '-')
            {
                Console.WriteLine("Please enter a valid, positive integer number!");
                input = Console.ReadLine();
            }

            bool[] isPrimeNumber = new bool[number];
            isPrimeNumber[2] = true;
            for (int i = 3; i <= number; i += 2)
            {
                isPrimeNumber[i] = true;
            }

            for (int i = 3; i < (int)Math.Sqrt(number); i++)
            {
                if (isPrimeNumber[i] == false)
                {
                    continue;
                }
                for (int j = i * 2; j < number; j += i)
                {
                    isPrimeNumber[j] = false;
                }
            }
            Console.WriteLine("The prime numbers from 2 to {0} are:",number);

            for (int i = 2; i < number; i++)
            {
                if (isPrimeNumber[i] == true)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }


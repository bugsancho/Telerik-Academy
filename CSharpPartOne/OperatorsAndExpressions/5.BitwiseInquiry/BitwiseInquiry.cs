using System;
//Turns out writing this code i have overdone myself and solved problems 10 and 11 aswell, that's why they don't appear in the solution
    class BitwiseInquiry
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the bit position you are interested in: ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1;
            mask <<= position;
            int result = mask & number;
            result >>= position;
            Console.WriteLine("The {0}. bit in the number {1} is {2}!", position, number, result);
        }
    }


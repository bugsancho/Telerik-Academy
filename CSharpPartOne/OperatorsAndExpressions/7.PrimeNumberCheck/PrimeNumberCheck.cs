using System;
class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number that is not higher than 100:");
        int number = int.Parse(Console.ReadLine());
        bool check = number > 100;

        if (check)
        {
            Console.WriteLine("You have entered a number that is higher than 100!!!");
        }
        else if ((number == 2 || number == 3 || number == 5 || number == 7)
                ^ (number % 2 != 0 && number % 3 != 0
                && number % 5 != 0 && number % 7 != 0))
        {
            Console.WriteLine("The number is Prime!");
        }
        else
            Console.WriteLine("The number is not Prime!");
    }
}


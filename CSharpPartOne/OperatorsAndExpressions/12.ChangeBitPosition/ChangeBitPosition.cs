using System;
class ChangeBitPosition
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the bit position you are interested in:");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the desired value:");
        int value = int.Parse(Console.ReadLine());

        int mask = 1 << position;

        if (value == 0)
        {
            number = number & (~mask);
            Console.WriteLine("The new number is: {0}", number);
                    }
        else
        {
            number = number | mask;
            Console.WriteLine("The new number is: {0}", number);
                   }

    }
}

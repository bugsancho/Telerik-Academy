using System;
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a possitive number:");
            uint number = uint.Parse(Console.ReadLine());
            uint maskOne = 56u;        
            uint maskTwo = 117440512u; 
            Console.WriteLine("The binary represantation of the number is: \n" + Convert.ToString(number, 2).PadLeft(32, '0'));
            uint bitsOne = number & maskOne;
            uint bitsTwo = number & maskTwo;

            bitsOne = bitsTwo << 21;
            bitsTwo = bitsTwo >> 21;

            number = number & (~maskOne);
            number = number & (~maskTwo);

            number = number | bitsOne;
            number = number | bitsTwo;
            Console.WriteLine("The new number is:");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }


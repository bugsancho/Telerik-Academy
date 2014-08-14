using System;

namespace _6.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int sequence = 2; sequence <= 11; sequence++)
            {

                if (sequence % 2 == 0)
                {

                    Console.Write(" " + sequence);
                }
                else
                {
                 Console.Write(" " + -sequence);

                }

            }
        }
    }
}

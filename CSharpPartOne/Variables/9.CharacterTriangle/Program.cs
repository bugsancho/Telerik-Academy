using System;

    class CharacterTriangle
    {
        static void Main(string[] args)
        {
            char copyright = '\u00A9';

            Console.WriteLine("  {0}", copyright);
            Console.WriteLine(" {0}{0}{0}", copyright);
            Console.WriteLine("{0}{0}{0}{0}{0}", copyright);
        }
    }


using System;
    class FirTree
    {
        static void Main()
        {
            int height = int.Parse(Console.ReadLine());
            int dotCount = height -2;
            int asteriskCount = 1;
            for (int i = 0; i < height -1; i++)
            {
                Console.Write(new string('.',dotCount));
                Console.Write(new string ('*',asteriskCount));
                Console.Write(new string('.', dotCount));
                dotCount--;
                asteriskCount += 2;
                Console.WriteLine();
            }
            dotCount = height - 2;
            asteriskCount = 1;
            Console.Write(new string('.', dotCount));
            Console.Write(new string('*', asteriskCount));
            Console.Write(new string('.', dotCount));

        }
    }


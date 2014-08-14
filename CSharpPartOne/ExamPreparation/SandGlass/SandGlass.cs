using System;
    class SandGlass
    {
        static void Main()
        {
            int height = int.Parse(Console.ReadLine());
            int dotCount = 0;
            int asteriskCount = height - (dotCount*2);
            for (int i = 0; i <= height /2; i++)
            {
                Console.Write(new string('.', dotCount));
                Console.Write(new string('*', asteriskCount));
                Console.Write(new string('.', dotCount));
                Console.WriteLine();
                dotCount++;
                asteriskCount = height - (dotCount * 2);
            }
           dotCount -= 2;
           asteriskCount += 4;
           for (int i = 1; i <= height / 2; i++)
           {
               Console.Write(new string('.', dotCount));
               Console.Write(new string('*', asteriskCount));
               Console.Write(new string('.', dotCount));
               Console.WriteLine();
               dotCount--;
               asteriskCount = height - (dotCount * 2);
           }
        }
    }


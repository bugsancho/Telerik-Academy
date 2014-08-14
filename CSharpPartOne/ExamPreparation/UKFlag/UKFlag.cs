using System;
    class UKFlag
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int dotsBefore = 0;
            int dotsAfter = ((inputNumber / 2) - dotsBefore) -1;
            for (int i = 0; i < inputNumber/2; i++)
            {
                Console.Write(new string('.',dotsBefore));
                Console.Write("\\");
                Console.Write(new string('.', dotsAfter));
                Console.Write("|");
                Console.Write(new string('.', dotsAfter));
                Console.Write("/");
                Console.Write(new string('.', dotsBefore));
                Console.WriteLine();
                dotsBefore++;
                dotsAfter = ((inputNumber / 2) - dotsBefore) - 1;
            }
            Console.Write(new string('-',inputNumber/2 ));
            Console.Write("*");
            Console.Write(new string('-', inputNumber / 2));
            Console.WriteLine();
            dotsBefore -= 1;
            dotsAfter += 1;

            for (int i = 0; i < inputNumber / 2; i++)
            {
                Console.Write(new string('.', dotsBefore));
                Console.Write("/");
                Console.Write(new string('.', dotsAfter));
                Console.Write("|");
                Console.Write(new string('.', dotsAfter));
                Console.Write("\\");
                Console.Write(new string('.', dotsBefore));
                Console.WriteLine();
                dotsBefore--;
                dotsAfter = ((inputNumber / 2) - dotsBefore) - 1;
            }
        }
    }


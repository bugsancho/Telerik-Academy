using System;
    class CatalanNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter a positive number");
            int number = int.Parse(Console.ReadLine());
            int nFactorial = 1;
            int nTimesTwoFactorial = 1;
            int result = 0;
            
            if (number == 0)
            {
                result = 0;
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    nFactorial *= i;
                }
                for (int i = number + 2; i <= 2 * number; i++)
                {
                    nTimesTwoFactorial *= i;
                }
                result = nTimesTwoFactorial / nFactorial;
            }

            Console.WriteLine("The {0}. Catalan number is {1}!",number,result);
        }

    }


using System;
    class PrintNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many numbers you want to print:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers from 1 to {0} are:", n);
            for (int number = 1; number <= n; number++)               
            {                
                Console.Write(number);
            }
            Console.WriteLine(); 
        }
        
    }


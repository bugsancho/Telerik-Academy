using System;
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers you want to sum:");            
            int n = int.Parse(Console.ReadLine());           
            int sum = 0;
            for (int number = 0; number < n; number++)
            {
               Console.WriteLine("Enter the number you want to add");                
               int placeholder =int.Parse(Console.ReadLine());                
               sum += placeholder;
            }
            Console.WriteLine("The sum of the numbers entered is: {0} ",sum);
        }
    }


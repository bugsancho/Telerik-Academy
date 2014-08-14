using System;
    class ValueExchange
    {
        static void Main(string[] args)
        {
            int five = 5;
            int ten = 10;

            ten = five + ten;
            five = ten - five;
            ten = ten - five;
            Console.WriteLine("Now the value for ten is {0} and the value for five is {1}", ten,five);
            
        }
    }


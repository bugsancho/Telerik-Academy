using System;
    class SumOfFractions
    {
        static void Main(string[] args)
        {
            double counter = 2;
            double sum = 1;
            int signChanger = 1;
            while (1 / counter > 0.001)
            {
                sum = sum + (1 / counter) * signChanger;
                signChanger *= -1;
                counter++;
            }
            Console.WriteLine("The sum of the first {0} members is {1:0.000}",counter,sum);
        }
    }


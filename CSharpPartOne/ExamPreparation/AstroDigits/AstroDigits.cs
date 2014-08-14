using System;
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();           
            int sum = 0;

            while (true)
            {
                for (int i = 0; i < inputNumber.Length; i++)
                {
                    if (!(inputNumber[i] == '.' || inputNumber[i] == '-'))
                    {
                        sum += int.Parse(inputNumber[i].ToString());
                    }                    
                }
                if (sum <= 9)
                {
                    break;
                }
                inputNumber = sum.ToString();
                sum = 0;
            }
            Console.WriteLine(sum);
           
        }
    }

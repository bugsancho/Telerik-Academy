using System;
    class Sheets
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            int number = int.Parse(inputNumber);
            int sheetNumber = 10;
            string binaryNumber = Convert.ToString(number, 2);
            for (int i = 0; i < 11; i++)
            {
                if ((binaryNumber[i]) != 1)
                {
                    Console.WriteLine("A{0}",sheetNumber);
                    
                }
                sheetNumber--;
            }



        }
    }


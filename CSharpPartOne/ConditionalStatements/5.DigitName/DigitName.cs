using System;
class DigitName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a single digit");
            byte digit = byte.Parse(Console.ReadLine());
            string digitName = "";
           
            switch (digit)
            {
                case 0: digitName = "zero"; break;
                case 1: digitName = "one"; break;
                case 2: digitName = "two"; break;
                case 3: digitName = "three"; break;
                case 4: digitName = "four"; break;
                case 5: digitName = "five"; break;
                case 6: digitName = "six"; break;
                case 7: digitName = "seven"; break;
                case 8: digitName = "eight"; break;
                case 9: digitName = "nine"; break;              
            }
            Console.WriteLine("The english wording for your digit is: {0}",digitName);
        }

    }


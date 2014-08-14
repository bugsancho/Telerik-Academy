using System;


    class QuotationMarks
    {
        static void Main(string[] args)
        {
            string oneWay = "The \"use\" of quotations causes difficulties.";
            string orAnother = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(oneWay);
            Console.WriteLine(orAnother);
        }
    }


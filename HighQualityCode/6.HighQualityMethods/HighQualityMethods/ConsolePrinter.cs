namespace HighQualityMethods
{
    using System;

    public static class ConsolePrinter
    {
        public static void PrintNumberAsFloat(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        public static void PrintNumberAsPercent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void PrintRightAlignedNumber(object number)
        {
            Console.WriteLine("{0,8}", number);
        }
    }
}

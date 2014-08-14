using System;
using System.Text;

    class ASCIITable
    {
        static void Main(string[] args)
        {
             Console.OutputEncoding = Encoding.ASCII;
             for (byte number = 0; number < 127; number++)
             {
                 Console.Write((char)number);
             }
        }


    }


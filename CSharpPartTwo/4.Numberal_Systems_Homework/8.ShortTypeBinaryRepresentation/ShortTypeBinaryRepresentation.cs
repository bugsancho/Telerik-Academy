using System;
using System.Collections.Generic;
    class ShortTypeBinaryRepresentation
    {
        //Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

        static void Main()
        {
            Console.WriteLine("Please enter a number that fits a 16 bit signed integer type: ");
            int numberInDecimal = int.Parse(Console.ReadLine());
            int[] numberInBinary = ConvertToBinary(numberInDecimal);
            PrintNumber(numberInBinary);
        }

        private static void PrintNumber(int[] numberInBinary)
        {
            Console.WriteLine("The binary representation of the number looks like this: ");
            for (int i = 0; i < numberInBinary.Length; i++)
            {
                Console.Write(numberInBinary[i]);
            }
            Console.WriteLine();
        }

        private static int[] ConvertToBinary(int numberInDecimal)
        {

            int[] numberInBinary = new int[16];
            if (numberInDecimal < 0)
            {
                numberInDecimal = -numberInDecimal;
                numberInDecimal = GetBits(numberInDecimal - 1, numberInBinary);
                for (int i = 0; i < 16; i++)
                {
                    if (numberInBinary[i] == 1)
                    {
                        numberInBinary[i] = 0;
                    }
                    else if (numberInBinary[i] == 0)
                    {
                        numberInBinary[i] = 1;
                    }
                }
            }
            else
            {
                numberInDecimal = GetBits(numberInDecimal, numberInBinary);
            }
            Array.Reverse(numberInBinary);
            return numberInBinary;
        }

        private static int GetBits(int numberInDecimal, int[] numberInBinary)
        {
            for (int i = 0; i < 15; i++)
            {
                numberInBinary[i] = numberInDecimal % 2;
                numberInDecimal /= 2;
            }
            return numberInDecimal;
        }
    }

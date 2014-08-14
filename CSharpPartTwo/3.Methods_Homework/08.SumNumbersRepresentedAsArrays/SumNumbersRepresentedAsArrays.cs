using System;
using System.Numerics;
    class SumNumbersRepresentedAsArrays
    {
        //Write a method that adds two positive integer numbers represented as arrays of digits 
        //(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
        //Each of the numbers that will be added could have up to 10 000 digits.

        static void Main()
        {
            char[] firstArray = new char[] { };
            char[] secondArray = new char[] { };
            Console.WriteLine("Please enter a number:");
            firstArray = Console.ReadLine().ToCharArray();
            Console.WriteLine("Now enter another number:");
            secondArray = Console.ReadLine().ToCharArray();
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            Console.Write("The sum of the two numbers is: ");
            Console.Write(Sum(firstArray, secondArray));
            Console.WriteLine("! Keep in mind that the digits are taken in reversed order!");
        }

        static BigInteger Sum(char[] firstArray, char[] secondArray)
        {
            BigInteger result = BigInteger.Parse(String.Join("", firstArray)) + BigInteger.Parse(String.Join("", secondArray));
            return result; 
        }
    }

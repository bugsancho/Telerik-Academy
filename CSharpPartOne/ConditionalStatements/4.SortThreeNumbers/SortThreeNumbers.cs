﻿using System;
    class SortThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter yet another number");
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber)
            {
                if (secondNumber >= thirdNumber)
                {
                    Console.WriteLine("The numbers {0}, {1} and {2} in descending order are: {0}, {1}, {2}!",
                        firstNumber, secondNumber, thirdNumber);
                }
                else if (firstNumber >= thirdNumber)
                {
                    Console.WriteLine("The numbers {0}, {1} and {2} in descending order are: {0}, {2}, {1}!",firstNumber,secondNumber,thirdNumber);
                        
                }
                else
                {
                    Console.WriteLine("The numbers {0}, {1} and {2} in descending order are: {2}, {0}, {1}!",
                        firstNumber, secondNumber, thirdNumber);
                }                
            }
            else if (secondNumber >= thirdNumber)
            {
                if (firstNumber >= thirdNumber)
                {
                    Console.WriteLine("The numbers {0}, {1} and {2} in descending order are: {1}, {0}, {2}!",
                        firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("The numbers {0}, {1} and {2} in descending order are: {1}, {2}, {0}!",
                        firstNumber, secondNumber, thirdNumber);
                }
            }
            else
            {
                Console.WriteLine("The numbers {0}, {1} and {2} in descending order are: {2}, {1}, {0}!",
                        firstNumber, secondNumber, thirdNumber);
            }
        }
    }


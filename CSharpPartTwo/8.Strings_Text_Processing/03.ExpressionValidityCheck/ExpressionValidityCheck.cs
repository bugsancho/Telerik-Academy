using System;
using System.Collections.Generic;
class ExpressionValidityCheck
{
    //Write a program to check if in a given expression the brackets are put correctly.
    //Example of correct expression: ((a+b)/5-d).
    //Example of incorrect expression: )(a+b)).

    static void Main()
    {
        Console.WriteLine("This program checks whether the bracketing in an expression is valid.");
        Console.WriteLine("Please use only operators: \"+,-,*,/\", parentesis and coefficients!");
        Console.WriteLine("Now enter your equation:");
        string input = Console.ReadLine();
        input = input.Replace(" ", "");
        input = input.ToLower();
        bool isValid = CheckParentesis(input);
        PrintResult(isValid);
        

    }

    private static bool CheckParentesis(string input)
    {
        int openedParentesis = 0;
        bool isValid = true;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                openedParentesis++;
            }
            else if (input[i] == ')')
            {
                if (openedParentesis != 0)
                {
                    openedParentesis--;
                }
                else
                {
                    isValid = false;
                }
            }
        }
        if (openedParentesis != 0)
        {
            isValid = false;
        }
        return isValid;
    }

    private static void PrintResult(bool isValid)
    {
        if (isValid)
        {
            Console.WriteLine("The bracketing in the expression is valid!");
        }
        else
        {
            Console.WriteLine("The bracketing in the expression is NOT valid!");
        }
    }
}
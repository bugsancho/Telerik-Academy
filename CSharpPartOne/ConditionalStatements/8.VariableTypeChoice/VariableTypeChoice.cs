using System;
    class VariableTypeChoice
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter text that fits any of the variable types: int, double, or string: ");
        string input = Console.ReadLine();

        double number;

        bool isNumber = double.TryParse(input, out number);

        switch (isNumber)
        {
            case true:
                number += 1;
                Console.WriteLine(number);
                break;
            case false:
                input += "*";
                Console.WriteLine(input);
                break;
        }
        }
    }


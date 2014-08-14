using System;
class BonusScores
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number that ranges from 1 to 9: ");
        int number;
        bool isNumber = int.TryParse(Console.ReadLine(), out number);

        switch (number)
        {
            case 1:
            case 2:
            case 3:
                number *= 10;
                break;

            case 4:
            case 5:
            case 6:
                number *= 100;
                break;

            case 7:
            case 8:
            case 9:
               number *= 1000;
                break;

            default:
                Console.WriteLine("Your number is not between 1 and 9!");
                break;
        }
        Console.WriteLine("Your score is : {0}", number);
    }

}
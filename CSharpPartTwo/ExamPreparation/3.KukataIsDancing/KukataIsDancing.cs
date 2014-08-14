using System;
class KukataIsDancing
{
    //http://bgcoder.com/Contest/Practice/95

    static string direction = "up";
    static int col = 1;
    static int row = 1;
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        string[] inputCommands = new string[numberOfLines];

        for (int i = 0; i < numberOfLines; i++)
        {
            inputCommands[i] = Console.ReadLine();
        }

        int[][] danceField = new int[3][];
        danceField[0] = new int[] { 1, 0, 1 };
        danceField[1] = new int[] { 0, 2, 0 };
        danceField[2] = new int[] { 1, 0, 1 };
        for (int i = 0; i < numberOfLines; i++)
        {
            for (int j = 0; j < inputCommands[i].Length; j++)
            {
                switch (inputCommands[i][j])
                {
                    case 'R': TurnRight(); break;
                    case 'L': TurnLeft(); break;
                    case 'W': MoveForward(); break;
                }
            }
            switch (danceField[row][col])
            {
                case 0: Console.WriteLine("BLUE"); break;
                case 1: Console.WriteLine("RED"); break;
                case 2: Console.WriteLine("GREEN"); break;
            }
            col = 1;
            row = 1;
        }

    }

    private static void MoveForward()
    {
        switch (direction)
        {
            case "up":
                {
                    row--;
                    if (row < 0)
                    {
                        row = 2;
                    }
                    break;
                }
            case "right":
                {
                    col++;
                    if (col > 2)
                    {
                        col = 0;
                    }
                    break;
                }
            case "down":
                {
                    row++;
                    if (row > 2)
                    {
                        row = 0;
                    } break;
                }
            case "left":
                {
                    col--;
                    if (col < 0)
                    {
                        col = 2;
                    }
                    break;
                }
        }
    }

    private static void TurnLeft()
    {
        switch (direction)
        {
            case "up": direction = "left"; break;
            case "right": direction = "up"; break;
            case "down": direction = "right"; break;
            case "left": direction = "down"; break;
        }
    }

    private static void TurnRight()
    {
        switch (direction)
        {
            case "up": direction = "right"; break;
            case "right": direction = "down"; break;
            case "down": direction = "left"; break;
            case "left": direction = "up"; break;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Ball
{
    //http://bgcoder.com/Contest/Practice/92

    private int width;
    private int height;
    private int depth;
    public int Width
    {
        get { return this.width; }
        set { this.width = value; }
    }
    public int Height
    {
        get { return this.height; }
        set { this.height = value; }
    }
    public int Depth
    {
        get { return this.depth; }
        set { this.depth = value; }
    }
}
class Slides
{
    static int width = 0;
    static int height = 0;
    static int depth = 0;
    static string pattern = @"\((.*?)\)";
    static Ball ball = new Ball();

    static void PrintResult(bool canEscape)
    {
        if (canEscape)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        Console.WriteLine("{0} {1} {2}", ball.Width, ball.Height, ball.Depth);
    }


    static void Main()
    {
        string input = Console.ReadLine();
        string[] dimensions = input.Split();
        width = int.Parse(dimensions[0]);
        height = int.Parse(dimensions[1]);
        depth = int.Parse(dimensions[2]);
        string[, ,] cube = new string[width, height, depth];
        for (int i = 0; i < height; i++)
        {
            input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            Queue<string> tokens = new Queue<string>();
            foreach (Match token in matches)
            {
                tokens.Enqueue(token.Groups[1].ToString());
            }
            for (int j = 0; j < depth; j++)
            {
                for (int k = 0; k < width; k++)
                {
                    cube[k, i, j] = tokens.Dequeue();
                }
            }
        }

        input = Console.ReadLine();
        string[] position = input.Split();
        ball.Width = int.Parse(position[0]);
        ball.Depth = int.Parse(position[1]);


        while (true)
        {
            switch (cube[ball.Width, ball.Height, ball.Depth])
            {
                case "S L":
                    {
                        if (ball.Height == height - 1)
                        {
                            PrintResult(true); return;
                        }
                        else if (ball.Width == 0)
                        {
                            PrintResult(false); return;
                        }
                        else
                        {
                            ball.Height++; ball.Width--;
                        } break;
                    }
                case "S R":
                    {
                        if (ball.Height == height - 1)
                        {
                            PrintResult(true); return;
                        }
                        else if (ball.Width == width - 1)
                        {
                            PrintResult(false); return;
                        }
                        else
                        {
                            ball.Height++; ball.Width++;
                        } break;
                    }
                case "S B":
                    {
                        if (ball.Height == height - 1)
                        {
                            PrintResult(true); return;
                        }
                        else if (ball.Depth == depth - 1)
                        {
                            PrintResult(false); return;
                        }
                        else
                        {
                            ball.Height++; ball.Depth++; break;
                        }
                    }
                case "S F":
                    {
                        if (ball.Height == height - 1)
                        {
                            PrintResult(true); return;
                        }
                        else if (ball.Depth == 0)
                        {
                            PrintResult(false); return;
                        }
                        else
                        {
                            ball.Height++; ball.Depth--; break;
                        }
                    }
                case "S FL":
                    {
                        if (ball.Height == height - 1)
                        {
                            PrintResult(true); return;
                        }
                        else if (ball.Depth == 0 || ball.Width == 0)
                        {
                            PrintResult(false); return;
                        }
                        else
                        {
                            ball.Height++; ball.Width--; ball.Depth--; break;
                        }
                    }
                case "S BL":
                    {
                        if (ball.Height == height - 1)
                        {
                            PrintResult(true); return;
                        }
                        else if (ball.Depth == depth - 1 || ball.Width == 0)
                        {
                            PrintResult(false); return;
                        }
                        else
                        {
                            ball.Height++; ball.Width--; ball.Depth++; break;
                        }
                    }
                case "S FR":
                    {
                        if (ball.Height == height - 1)
                        {
                            PrintResult(true); return;
                        }
                        else if (ball.Depth == 0 || ball.Width == width - 1)
                        {
                            PrintResult(false); return;
                        }
                        else
                        {
                            ball.Height++; ball.Width++; ball.Depth--; break;
                        }
                    }
                case "S BR":
                    {
                        if (ball.Height == height - 1)
                        {
                            PrintResult(true); return;
                        }
                        else if (ball.Depth == depth - 1 || ball.Width == width - 1)
                        {
                            PrintResult(false); return;
                        }
                        else
                        {
                            ball.Height++; ball.Width++; ball.Depth++; break;
                        }
                    }
                case "E":
                    {
                        if (ball.Height == height - 1)
                        {
                            PrintResult(true); return;
                        }
                        else
                        {
                            ball.Height++; break;
                        }
                    }
                case "B": PrintResult(false); return;
                default:
                    string[] token = cube[ball.Width, ball.Height, ball.Depth].Split();
                    ball.Width = int.Parse(token[1]);
                    ball.Depth = int.Parse(token[2]);
                    break;
            }
        }
    }
}
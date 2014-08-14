namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Minesweeper
    {
        public static void Main()
        {
            char[,] field = CreateGameField();
            char[,] bombs = PlaceBombs();
            string command = string.Empty;
            List<Score> highScores = new List<Score>(6);
            const int MaxCellsCount = 35;
            int revealedCellsCount = 0;
            bool isBombFound = false;
            bool isNewGame = true;
            bool isGameOver = false;
            int row = 0;
            int col = 0;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play “Mines”. Try to uncover all the fields without mines.");
                    Console.WriteLine("The 'top' command show high scores, 'restart' starts a new game and 'exit' leaves the game!");
                    PrintGameField(field);
                    isNewGame = false;
                }

                Console.Write("Enter row and col: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintHighScores(highScores);
                        break;
                    case "restart":
                        field = CreateGameField();
                        bombs = PlaceBombs();
                        PrintGameField(field);
                        isBombFound = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                UpdateGameField(field, bombs, row, col);
                                revealedCellsCount++;
                            }

                            if (MaxCellsCount == revealedCellsCount)
                            {
                                isGameOver = true;
                            }
                            else
                            {
                                PrintGameField(field);
                            }
                        }
                        else
                        {
                            isBombFound = true;
                        }

                        break;
                    default:

                        Console.WriteLine("\nInvalid command!\n");
                        break;
                }

                if (isBombFound)
                {
                    PrintGameField(bombs);
                    Console.Write("\nGame over! Score: {0} ", revealedCellsCount);
                    Console.Write("Enter your nickname: ");
                    string nickname = Console.ReadLine();
                    Score currentPlayerScore = new Score(nickname, revealedCellsCount);
                    if (highScores.Count < 5)
                    {
                        highScores.Add(currentPlayerScore);
                    }
                    else
                    {
                        for (int i = 0; i < highScores.Count; i++)
                        {
                            if (highScores[i].Points < currentPlayerScore.Points)
                            {
                                highScores.Insert(i, currentPlayerScore);
                                highScores.RemoveAt(highScores.Count - 1);
                                break;
                            }
                        }
                    }

                    highScores.Sort((Score r1, Score r2) => r2.HolderName.CompareTo(r1.HolderName));
                    highScores.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));

                    PrintHighScores(highScores);
                    field = CreateGameField();
                    bombs = PlaceBombs();
                    revealedCellsCount = 0;
                    isBombFound = false;
                    isNewGame = true;
                }

                if (isGameOver)
                {
                    Console.WriteLine("\nCongratulations! You revealed all {0} cells successfully", MaxCellsCount);
                    PrintGameField(bombs);
                    Console.WriteLine("Enter your nickname: ");
                    string name = Console.ReadLine();
                    Score currentPlayerScore = new Score(name, revealedCellsCount);
                    highScores.Add(currentPlayerScore);
                    PrintHighScores(highScores);
                    field = CreateGameField();
                    bombs = PlaceBombs();
                    revealedCellsCount = 0;
                    isGameOver = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria!");
            Console.Read();
        }

        private static void PrintHighScores(List<Score> scores)
        {
            Console.WriteLine("\nHigh Scores:");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, scores[i].HolderName, scores[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No high scores!\n");
            }
        }

        private static void UpdateGameField(char[,] gameField, char[,] bombs, int selectedRow, int selectedCol)
        {
            char numberOfAdjacentBombs = FindNumberOfAdjacentBombs(bombs, selectedRow, selectedCol);
            bombs[selectedRow, selectedCol] = numberOfAdjacentBombs;
            gameField[selectedRow, selectedCol] = numberOfAdjacentBombs;
        }

        private static void PrintGameField(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardCols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardCols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.WriteLine("|");
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceBombs()
        {
            const int BoardRows = 5;
            const int BoardCols = 10;
            char[,] gameField = new char[BoardRows, BoardCols];

            for (int row = 0; row < BoardRows; row++)
            {
                for (int col = 0; col < BoardCols; col++)
                {
                    gameField[row, col] = '-';
                }
            }

            List<int> bombsIndexes = new List<int>();
            Random random = new Random();
            while (bombsIndexes.Count < 15)
            {
                int currentBombIndex = random.Next(BoardRows * BoardCols);
                if (!bombsIndexes.Contains(currentBombIndex))
                {
                    bombsIndexes.Add(currentBombIndex);
                }
            }

            foreach (int bombIndex in bombsIndexes)
            {
                int currentBombRow = bombIndex / BoardCols;
                int currentBombCol = bombIndex % BoardCols;
                if (currentBombCol == 0 && bombIndex != 0)
                {
                    currentBombRow--;
                    currentBombCol = BoardCols;
                }
                else
                {
                    currentBombCol++;
                }

                gameField[currentBombRow, currentBombCol - 1] = '*';
            }

            return gameField;
        }

        private static char FindNumberOfAdjacentBombs(char[,] field, int selectedRow, int selectedCol)
        {
            int numberOfAdjacentBombs = 0;
            int fieldRows = field.GetLength(0);
            int fieldCols = field.GetLength(1);

            if (selectedRow - 1 >= 0)
            {
                if (field[selectedRow - 1, selectedCol] == '*')
                {
                    numberOfAdjacentBombs++;
                }
            }

            if (selectedRow + 1 < fieldRows)
            {
                if (field[selectedRow + 1, selectedCol] == '*')
                {
                    numberOfAdjacentBombs++;
                }
            }

            if (selectedCol - 1 >= 0)
            {
                if (field[selectedRow, selectedCol - 1] == '*')
                {
                    numberOfAdjacentBombs++;
                }
            }

            if (selectedCol + 1 < fieldCols)
            {
                if (field[selectedRow, selectedCol + 1] == '*')
                {
                    numberOfAdjacentBombs++;
                }
            }

            if ((selectedRow - 1 >= 0) && (selectedCol - 1 >= 0))
            {
                if (field[selectedRow - 1, selectedCol - 1] == '*')
                {
                    numberOfAdjacentBombs++;
                }
            }

            if ((selectedRow - 1 >= 0) && (selectedCol + 1 < fieldCols))
            {
                if (field[selectedRow - 1, selectedCol + 1] == '*')
                {
                    numberOfAdjacentBombs++;
                }
            }

            if ((selectedRow + 1 < fieldRows) && (selectedCol - 1 >= 0))
            {
                if (field[selectedRow + 1, selectedCol - 1] == '*')
                {
                    numberOfAdjacentBombs++;
                }
            }

            if ((selectedRow + 1 < fieldRows) && (selectedCol + 1 < fieldCols))
            {
                if (field[selectedRow + 1, selectedCol + 1] == '*')
                {
                    numberOfAdjacentBombs++;
                }
            }

            return char.Parse(numberOfAdjacentBombs.ToString());
        }
    }
}

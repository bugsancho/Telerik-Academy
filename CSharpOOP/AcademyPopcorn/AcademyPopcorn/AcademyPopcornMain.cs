using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    //Here is my version of the AcademyPopcorn game feature implementation. You can check what I've done by searching for 'task {0}', number of the task as in the presentation.
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;
            InitializeWalls(engine);
            for (int i = startCol; i < endCol; i++)
            {
                //task 10
                //task 11 & task 12
                Block currBlock = new GiftBlock(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }
            //task 6 & task 7
            //task 8 & task 9
            Ball theBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 5),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);

            //task 3
            Racket anotherRacket = new ShootingRacket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength * 2);
            engine.AddObject(anotherRacket);
            //task 5
            TrailObject trail = new TrailObject(new MatrixCoords(10, 10), new char[,] { { 'g' } }, 5);
            engine.AddObject(trail);
        }
        //task 1
        //task 8 & task 9        
        static void InitializeWalls(Engine engine)
        {
            for (int i = 0; i < WorldCols; i++)
            {
                UnpassableBlock ceilingBlock = new UnpassableBlock(new MatrixCoords(0, i));
                engine.AddObject(ceilingBlock);
            }
            for (int i = 1; i < WorldRows; i++)
            {
                UnpassableBlock leftWallBlock = new UnpassableBlock(new MatrixCoords(i, 0));
                UnpassableBlock rightWallBlock = new UnpassableBlock(new MatrixCoords(i, WorldCols - 1));
                engine.AddObject(leftWallBlock);
                engine.AddObject(rightWallBlock);
            }
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new ShootingRacketEngine(renderer, keyboard, 100);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };
            //task 13
            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                if (gameEngine is ShootingRacketEngine)
                {
                    (gameEngine as ShootingRacketEngine).ShootRacket();
                }
            };

            Initialize(gameEngine);



            gameEngine.Run();
        }
    }
}

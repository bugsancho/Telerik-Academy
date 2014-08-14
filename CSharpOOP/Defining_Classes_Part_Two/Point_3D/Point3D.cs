using System;
using System.Collections.Generic;

class Point3D
{
        static void Main()
        {
            Point point = new Point(2, 3, 5);
            Console.WriteLine(point);
            Console.WriteLine(Point.PointZero);
            Point secondPoint = new Point(2, 2, 2);
            Console.WriteLine(EucledianDistance.CalculateDistance(point, secondPoint));
            
            Path path = new Path();
            Console.WriteLine(path.Count);
            path.Add(point);
            path.Add(point);
            Console.WriteLine(path.Count);
            Console.WriteLine(path.points.Count);
           // PathStorage.SavePath(path);
            List<Path> paths = PathStorage.LoadPaths();
            Console.WriteLine();
        }
}

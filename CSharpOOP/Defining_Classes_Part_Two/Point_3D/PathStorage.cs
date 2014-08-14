using System;
using System.IO;
using System.Collections.Generic;
static class PathStorage
{
    //methods for saving and loading paths
    public static void SavePath(Path path)
    {
        StreamWriter writter = new StreamWriter("../../paths.txt", true);
        using (writter)
        {
            for (int i = 0; i < path.Count; i++)
            {
                Point currentPoint = path.points[i];
                writter.Write("{0} {1} {2}|", currentPoint.XCoord, currentPoint.YCoord, currentPoint.ZCoord);
            }
            writter.WriteLine();
        }
    }
    public static List<Path> LoadPaths()
    {
        List<Path> paths = new List<Path>();
        
        if (File.Exists("../../paths.txt"))
        {
            StreamReader reader = new StreamReader("../../paths.txt");
            using (reader)
            {
                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    Path currentPath = new Path();
                    string[] points = currentLine.Split(new char[] {'|'},StringSplitOptions.RemoveEmptyEntries);
                    foreach (var point in points)
                    {
                        string[] coords = point.Split();
                        currentPath.Add(new Point(int.Parse(coords[0]), int.Parse(coords[1]), int.Parse(coords[2])));
                    }
                    paths.Add(currentPath);
                    currentLine = reader.ReadLine();
                }
            }
        }
        else
        {
            throw new FileNotFoundException("The file was not found!");
        }

        return paths;
    }
}
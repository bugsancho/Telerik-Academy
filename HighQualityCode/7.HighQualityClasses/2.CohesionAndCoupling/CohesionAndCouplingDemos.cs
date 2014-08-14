using System;

public static class CohesionAndCouplingDemos
{
    public static void Main()
    {
        // Console.WriteLine(FileNameManager.GetFileExtension("example"));
        Console.WriteLine(FileNameManager.GetFileExtension("example.pdf"));
        Console.WriteLine(FileNameManager.GetFileExtension("example.new.pdf"));

        Console.WriteLine(FileNameManager.GetFileNameWithoutExtension("example"));
        Console.WriteLine(FileNameManager.GetFileNameWithoutExtension("example.pdf"));
        Console.WriteLine(FileNameManager.GetFileNameWithoutExtension("example.new.pdf"));

        Console.WriteLine(
            "Distance in the 2D space = {0:f2}",
            GeometryCalculator.CalcDistance2D(1, -2, 3, 4));
        Console.WriteLine(
            "Distance in the 3D space = {0:f2}",
            GeometryCalculator.CalcDistance3D(5, 2, -1, 3, -6, 4));

        int width = 3;
        int height = 4;
        int depth = 5;
        Console.WriteLine("Volume = {0:f2}", GeometryCalculator.CalcVolume(width, height, depth));
        Console.WriteLine("Diagonal XYZ = {0:f2}", GeometryCalculator.CalcDiagonalXYZ(width, height, depth));
        Console.WriteLine("Diagonal XY = {0:f2}", GeometryCalculator.CalcDiagonalXY(width, height));
        Console.WriteLine("Diagonal XZ = {0:f2}", GeometryCalculator.CalcDiagonalXZ(width, depth));
        Console.WriteLine("Diagonal YZ = {0:f2}", GeometryCalculator.CalcDiagonalYZ(height, depth));
    }
}
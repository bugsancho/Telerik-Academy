using System;
static class EucledianDistance
{
    //method for calculating distance in 3D space
    public static double CalculateDistance(Point firstPoint,Point secondPoint)
    {
        double distance = 0;
        distance = Math.Sqrt(Math.Pow((firstPoint.XCoord - secondPoint.XCoord),2) + Math.Pow((firstPoint.YCoord - secondPoint.YCoord),2) + Math.Pow((firstPoint.ZCoord - secondPoint.ZCoord),2));

        return distance;
    }
}

namespace HighQualityMethods
{
    using System;

    public static class Geometry
    {
        public static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("The length of the side of a triangle must be a positive number!");
            }

            if (!CanFormATriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("The entered side lenghts cannot form a triangle!");
            }

            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return area;
        }

        public static double CalcDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static bool IsLineHorizontal(double x1, double y1, double x2, double y2)
        {
            return y1 == y2;
        }

        public static bool IsLineVertical(double x1, double y1, double x2, double y2)
        {
            return x1 == x2;
        }

        public static bool CanFormATriangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB < sideC || sideB + sideC < sideA || sideC + sideA < sideB)
            {
                return false;
            }

            return true;
        }
    }
}

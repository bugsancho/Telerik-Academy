using System;

public class Size
{
    private double width;
    private double height;

    public Size(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public static Size GetRotatedSize(Size initialSize, double rotationAngle)
    {
        double sinus = Math.Abs(Math.Sin(rotationAngle));
        double cosinus = Math.Abs(Math.Cos(rotationAngle));

        double rotatedFigureWidth = (cosinus * initialSize.Width) + (sinus * initialSize.Height);
        double rotatedFigureHeight = (sinus * initialSize.Width) + (cosinus * initialSize.Height);

        Size rotatedSize = new Size(rotatedFigureWidth, rotatedFigureHeight);

        return rotatedSize;
    }
}
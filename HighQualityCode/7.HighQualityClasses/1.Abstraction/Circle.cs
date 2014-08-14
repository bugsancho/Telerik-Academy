﻿using System;

public class Circle : IFigure
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double Radius
    {
        get
        {
            return this.radius;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("The radius of a circle must be a positive number!");
            }

            this.radius = value;
        }
    }

    public double CalcPerimeter()
    {
        double perimeter = 2 * Math.PI * this.Radius;
        return perimeter;
    }

    public double CalcSurface()
    {
        double surface = Math.PI * this.Radius * this.Radius;
        return surface;
    }
}
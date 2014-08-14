using System;
class Circle : Shape
{
    /// <summary>
    /// Calculate the surface of the circle.
    /// </summary>
    /// <returns>The surface of the circle</returns>
    public override double CalculateSurface()
    {
        double surface = this.Width * this.Height * Math.PI;
        return surface;
    }
    /// <summary>
    /// Create an instance of the Circle class.
    /// </summary>
    /// <param name="radius">The radius of the circle</param>
    public Circle(double radius)
        : base(radius, radius)
    {
    }
}

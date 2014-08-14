class Rectangle : Shape
{
    /// <summary>
    /// Calculate the surface of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle</returns>
    public override double CalculateSurface()
    {
        double surface = this.Width * this.Height;
        return surface;
    }
    /// <summary>
    /// Create an instance of the rectangle class.
    /// </summary>
    /// <param name="width">Width of the rectangle</param>
    /// <param name="height">Height of the rectangle</param>
    public Rectangle(double width, double height)
        : base(width, height)
    {
    }
}

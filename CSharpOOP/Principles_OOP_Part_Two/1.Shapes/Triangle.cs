class Triangle : Shape
{
    ///<summary>Calculate the surface of the triangle!
    ///</summary>
    public override double CalculateSurface()
    {
        double surface = this.Width * this.Height / 2;
        return surface;
    }
    /// <summary>
    /// Create an instance of the Triangle class.
    /// </summary>
    /// <param name="width">Width of the side</param>
    /// <param name="height">Height to the side</param>
    public Triangle(double width, double height)
        : base(width, height)
    {
    }
}

public abstract class Shape
{
    //an abstract class that introduces a shape that has width and height and an abstract method for calculating its surface.

    //fields
    private double height;
    private double width;
    //properties
    public double Height
    {
        get { return this.height; }
        protected set { this.height = value; }
    }
    public double Width
    {
        get { return this.width; }
        protected set { this.width = value; }
    }
    //method
    public abstract double CalculateSurface();
    //constructor
    protected Shape(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }
}


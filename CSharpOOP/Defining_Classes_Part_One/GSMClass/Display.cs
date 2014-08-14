using System;
using System.Text;
class Display
{
    //The size of the display is mandatory so can't be null or non-positive.
    private double size;
    public double Size
    {
        get
        {
            return this.size;
        }
        set
        {
            if (value > 0)
            {
                this.size = value;
            }
            else
            {
                throw new ArgumentException("Number of colors cannot be less or equal to zero!");
            }
        }
    }
    //The number of colors of the display cannot be less than 2(black and white)
    private int? numberOfColors;
    public int? NumberOfColors
    {
        get
        {
            return this.numberOfColors;
        }
        set
        {
            if (value > 1 || value == null)
            {
                this.numberOfColors = value;
            }
            else
            {
                throw new ArgumentException("Number of colors cannot be less or equal to zero!");
            }
        }
    }

    //constructors taking two sets of parameters
    public Display(double size, int? numberOfColors)
    {
        this.Size = size;
        this.NumberOfColors = numberOfColors;
    }
    public Display(double size)
        : this(size, null)
    {
    }
    //Override method for displaying information about the display
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendFormat("Size: {0} ", size);
        if (numberOfColors != null)
        {
            info.AppendFormat("Number of colors: {0}", numberOfColors);
        }
        return info.ToString();
    }
}
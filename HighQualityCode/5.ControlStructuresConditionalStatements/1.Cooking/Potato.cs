using _1.Cooking;

class Potato : IVegetable
{
    public Potato()
    {
        this.IsPeeled = false;
    }

    public bool IsPeeled { get; set; }
}
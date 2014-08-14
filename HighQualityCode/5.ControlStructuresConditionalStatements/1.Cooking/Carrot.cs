using _1.Cooking;

class Carrot : IVegetable
{
    public Carrot()
    {
        this.IsPeeled = false;
    }

    public bool IsPeeled { get; set; }
}
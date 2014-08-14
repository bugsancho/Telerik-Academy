using System.Collections.Generic;
using _1.Cooking;

class Bowl
{
    public Bowl()
    {
        this.Vegetables = new List<IVegetable>();
    }

    public ICollection<IVegetable> Vegetables { get; set; }

    public void AddVegetable(IVegetable vegetable)
    {
        this.Vegetables.Add(vegetable);
    }
}
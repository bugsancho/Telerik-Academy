using System;
using System.Collections.Generic;
using _1.Cooking;

public class Chef
{

    private Bowl GetBowl()
    {
        // Code, code, code...
        return new Bowl();
    }
    private Carrot GetCarrot()
    {
        // Code, code, code...
        return new Carrot();
    }
    private Potato GetPotatoe()
    {
        // Code, code, code...
        return new Potato();
    }
    private void Peel(IVegetable vegetable)
    {
        vegetable.IsPeeled = true;
    }
    public void Cook()
    {
        Bowl currentBowl = GetBowl();

        currentBowl.AddVegetable(this.GetCarrot());
        currentBowl.AddVegetable(this.GetPotatoe());

        foreach (var veg in currentBowl.Vegetables)
        {
            this.Peel(veg);
        }

    }
}


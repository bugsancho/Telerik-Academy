using System;

class Cat : Animal
{
    public Cat(string name, int age, char sex) : base(name,age,sex)
    {

    }
    public override void Talk()
    {
        Console.WriteLine("Meow!");
    }
}
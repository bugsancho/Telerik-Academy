using System;

class Dog : Animal
{
    public Dog(string name, int age, char sex) : base(name,age,sex)
    {

    }
    public override void Talk()
    {
        Console.WriteLine("Woof!");
    }
}
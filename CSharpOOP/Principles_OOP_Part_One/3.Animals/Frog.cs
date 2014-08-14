class Frog : Animal
{
    public Frog(string name, int age, char sex) : base(name,age,sex)
    {

    }
    public override void Talk()
    {
        System.Console.WriteLine("Quack!");
    }
}
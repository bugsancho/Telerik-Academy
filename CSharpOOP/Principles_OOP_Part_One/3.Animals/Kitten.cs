class Kitten: Cat
{
    public Kitten(string name, int age) : base(name,age,'f')
    {
    }

    public override void Talk()
    {
        System.Console.WriteLine("Kitten says meow!");
    }
}

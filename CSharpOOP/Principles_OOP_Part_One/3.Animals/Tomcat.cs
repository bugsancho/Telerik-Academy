class Tomcat : Cat
{
    public Tomcat(string name, int age) : base(name,age,'m')
    {
    }

    public override void Talk()
    {
        System.Console.WriteLine("Tomcat says meow!");
    }
}

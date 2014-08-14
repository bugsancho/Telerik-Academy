using System;

abstract class Animal : ISound
{
    public Animal(string name, int age, char sex)
    {
        this.Sex = sex;
        this.Name = name;
        this.Age = age;
    }

    public abstract void Talk();

    private int age;
    private string name;
    private char sex;

    public char Sex
    {
        get { return this.sex; }
        set { this.sex = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
    
}
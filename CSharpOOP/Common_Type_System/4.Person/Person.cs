using System.Text;
//very simple class representing a person with two characteristics: name and age
class Person
{
    //fields
    private string name;
    private int? age;

    //properties
    public Person(string name, int? age)
    {
        this.Age = age;
        this.Name = name;
    }

    public int? Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    //overriden ToString()
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendFormat("Name: {0}, ", this.Name);
        if (this.Age != null)
        {
            info.AppendFormat("age: {0}!", this.Age);
        }
        else
        {
            info.AppendFormat("age is not specified!");
        }
        return info.ToString();
    }
    //constructor
    public Person(string name)
        : this(name, null)
    {
    }
}
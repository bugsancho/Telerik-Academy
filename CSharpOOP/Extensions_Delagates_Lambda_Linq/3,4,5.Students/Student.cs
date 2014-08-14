using System;
using System.Text;
//simple class that holds information about a student(two names and age).
public class Student
{
    //fields
    private string firstName;
    private string lastName;
    private int age;
    //properties
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
  
    public string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }
  
    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }
    //constructor
    public Student(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }
    //override method
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendFormat("Name: {0}, ", this.firstName);
        info.AppendFormat("last name: {0}, ", this.lastName);
        info.AppendFormat("age: {0}.", this.age);
        return info.ToString();
    }
 
}
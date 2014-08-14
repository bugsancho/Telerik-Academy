using System;
class PersonTest
{
    static void Main()
    {
        Person person = new Person("Goshko", 10);
        Person anotherPerson = new Person("Ivancho");
        Person[] people = { person, anotherPerson };
        foreach (var pers in people)
        {
            Console.WriteLine(pers);
        }
    }
}

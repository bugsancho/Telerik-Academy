using System;
using System.Collections.Generic;
class SchoolTest
{
    static void Main()
    {
        List<Discipline> disc = new List<Discipline>();
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        teachers.Add(new Teacher("penny",disc));
        students.Add(new Student("Pesho"));
        students.Add(new Student("Pesho"));
        disc.Add(new Discipline("Physics",5,5));
        Teacher penny = new Teacher("Penny",disc);
        StudentClass firstGrade = new StudentClass("1a",teachers,students);
        Console.WriteLine(firstGrade);
        Student bla = new Student("gsfgdg");
        Console.WriteLine(bla);
        penny.Comment("bad penny!");
        penny.PrintComments();
    }
}

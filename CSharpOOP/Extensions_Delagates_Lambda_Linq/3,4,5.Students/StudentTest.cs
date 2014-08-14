using System;
using System.Linq;

class StudentTest
{
    static void Main()
    {
        Student[] students = new Student[4];
        students[0] = new Student("Gosho", "Avanov", 22);
        students[1] = new Student("Pesho", "Gumov", 10);
        students[2] = new Student("Tosho", "Petkov", 55);
        students[3] = new Student("Gosho", "Dimitrov", 50);
        
        //task 3
        var names = from student in students
                    where student.Age <= 24 && student.Age >= 18
                    select new { student.FirstName, student.LastName };
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();

        //task 4
        var someStudents = from student in students
                           where student.FirstName.CompareTo(student.LastName) < 0
                           select student;
        foreach (var student in someStudents)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();

        //task 5
        var orderedStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
        foreach (var student in orderedStudents)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();

        //task 5 with LINQ
        var anotherOrderedStudents =
            from student in students
            orderby student.FirstName descending, student.LastName descending
            select student;
        foreach (var student in anotherOrderedStudents)
        {
            Console.WriteLine(student);
        }
    }
}
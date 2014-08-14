using System;

class StudentTest
{
    static void Main()
    {
        Student firstStudent = new Student(0555334525, "bachelor", "bla@bla.bg", Faculty.FacultyOfMathematics, University.SofiaUniversity, Specialty.Mathematics, "sofia", 1010104433, "penkin", "ivankin", "ivan");
        Console.WriteLine(firstStudent);
    }
}

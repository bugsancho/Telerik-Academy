using System;
using System.Collections.Generic;
using System.Linq;
class HumanTest
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        List<Worker> workers = new List<Worker>();
        students.Add(new Student("Gosho","Ivanov",5));
        students.Add(new Student("Pesho","Georgiev",2));
        students.Add(new Student("Tosho","Nedev",7));
        students.Add(new Student("Ceko","Lomski",10));
        students.Add(new Student("Ivan","Trendafilov",1));
        students.Add(new Student("Mariika","Petrova",5));
        students.Add(new Student("Ivanka","Todorova",12));
        students.Add(new Student("Antonia","Vancheva",8));
        students.Add(new Student("Abu","Nazir",3));
        students.Add(new Student("Plamen","Cekov",1));

        workers.Add(new Worker("Toncho", "Tonev", 44, 300));
        workers.Add(new Worker("Concho", "Conev", 50, 215));
        workers.Add(new Worker("Gancho", "Ganchev", 45, 200));
        workers.Add(new Worker("Gancho", "Tonev", 22, 89.3));
        workers.Add(new Worker("Traicho", "Traikov", 40, 132.2));
        workers.Add(new Worker("Spas", "Spasov", 5, 35));
        workers.Add(new Worker("Spas", "Ivanov", 15, 111));
        workers.Add(new Worker("Vanio", "Vanev", 23, 231));
        workers.Add(new Worker("Trencho", "Trenchev", 42, 420));
        workers.Add(new Worker("Toncho", "Tonev", 33, 280));

        var sortedStudents =
            from student in students
            orderby student.Grade
            select student;

        var sortedWorkers =
            from worker in workers
            orderby worker.CalculateMoneyPerHour() descending
            select worker;
        List<Human> humans = new List<Human>(workers.Concat(new List<Human>(students)));
        var sortedHumans =
            from human in humans
            orderby human.FirstName, human.LastName
            select human;
        Console.WriteLine("Students: \n");
        foreach (var student in students)
        {
            Console.Write(student);
        }
        Console.WriteLine("\nWorkers: \n");
        foreach (var worker in workers)
        {
            Console.WriteLine(worker);
        }
        Console.WriteLine("\nStudents, sorted by grade(ascending): \n");
        foreach (var student in sortedStudents)
        {
            Console.Write(student);
        }
        Console.WriteLine("\nWorkers, sorted by money per hour(descending): \n");
        foreach (var worker in sortedWorkers)
        {
            Console.WriteLine(worker);
        }
        Console.WriteLine("\nList of humans: \n");
        foreach (var human in sortedHumans)
        {
            Console.Write(human);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
class StudentClass : ICommentable
{
    private List<Student> students;
    private List<Teacher> teachers;
    private string identifier;
    private int currentClassNumber = 1;
    private List<string> comments = new List<string>();
    public StudentClass(string identifier, List<Teacher> teachers, List<Student> students)
    {
        this.Identifier = identifier;
        this.Teachers = teachers;
        this.Students = students;
    }

    public List<string> Comments
    {
        get { return this.comments; }
        set { this.comments = value; }
    }

    

    public string Identifier
    {
        get { return this.identifier; }
        set { this.identifier = value; }
    }

    public List<Teacher> Teachers
    {
        get { return this.teachers; }
        set { this.teachers = value; }
    }

    public List<Student> Students
    {
        get { return this.students; }
        set
        {
            AddClassNumber(value);
            this.students = value;
        }
    }

    private void AddClassNumber(List<Student> students)
    {
        foreach (var student in students)
        {
            student.ClassNumber = this.currentClassNumber;
            this.currentClassNumber++;
        }
    }

    public void Comment(string comment)
    {
        comments.Add(comment);
    }

    public void PrintComments()
    {
        foreach (var comment in comments)
        {
            Console.WriteLine(comment);
        }
    }
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendFormat("Identifier: {0}\n\n", this.identifier);
        info.Append("Teachers: \n");
        foreach (var teacher in this.teachers)
        {
            info.AppendFormat("{0}", teacher);
        }
        info.Append("Students: \n");
        foreach (var student in this.students)
        {
            info.AppendFormat("{0} \n", student);
        }
        return info.ToString();
    }


}

using System;
using System.Collections.Generic;
using System.Text;

public class LocalCourse : Course
{
    public LocalCourse(string courseName)
        : base(courseName)
    {
    }

    public LocalCourse(string courseName, string teacherName)
        : base(courseName, teacherName, new List<string>())
    {
    }

    public LocalCourse(string courseName, string teacherName, IList<string> students) :
        base(courseName, teacherName, students)
    {
    }

    public LocalCourse(string courseName, string teacherName, IList<string> students, string lab) :
        base(courseName, teacherName, students)
    {
        this.Lab = lab;
    }

    public string Lab { get; set; }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder(base.ToString());
        result.Length -= 2;
        if (this.Lab != null)
        {
            result.Append("; Lab = ");
            result.Append(this.Lab);
        }

        result.Append(" }");
        return result.ToString();
    }
}

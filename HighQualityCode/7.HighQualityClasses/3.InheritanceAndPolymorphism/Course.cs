using System;
using System.Collections.Generic;
using System.Text;

public abstract class Course : ICourse
{
    private string name;

    protected Course(string courseName, string teacherName, IList<string> students)
    {
        this.Name = courseName;
        this.TeacherName = teacherName;
        this.Students = students;
    }

    protected Course(string courseName, string teacherName)
        : this(courseName, teacherName, new List<string>())
    {
    }

    protected Course(string courseName)
        : this(courseName, null, new List<string>())
    {
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("A course cannot have a null or empty string for a name!");
            }

            this.name = value;
        }
    }

    public string TeacherName { get; set; }

    public IList<string> Students { get; set; }

    public string GetStudentsAsString()
    {
        if (this.Students == null || this.Students.Count == 0)
        {
            return "{ }";
        }
        else
        {
            return "{ " + string.Join(", ", this.Students) + " }";
        }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append(this.GetType().Name + " { Name = ");
        result.Append(this.Name);
        if (this.TeacherName != null)
        {
            result.Append("; Teacher = ");
            result.Append(this.TeacherName);
        }

        result.Append("; Students = ");
        result.Append(this.GetStudentsAsString());
        result.Append(" }");
        return result.ToString();
    }
}
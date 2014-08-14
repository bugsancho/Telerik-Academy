using System;
using System.Collections.Generic;
using System.Text;
class OffsiteCourse : Course
{
    public string Town { get; set; }

    public OffsiteCourse(string courseName)
        : base(courseName)
    {
    }
    public OffsiteCourse(string courseName, string teacherName)
        : base(courseName, teacherName, new List<string>())
    {

    }
    public OffsiteCourse(string courseName, string teacherName, IList<string> students) :
        base(courseName, teacherName, students)
    {

    }
    public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town) :
        base(courseName, teacherName, students)
    {
        this.Town = town;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder(base.ToString());
        result.Length -= 2;
        if (this.Town != null)
        {
            result.Append("; Town = ");
            result.Append(this.Town);
        }
        result.Append(" }");
        return result.ToString();
    }
}

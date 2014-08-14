using System;
using System.Collections.Generic;
using System.Text;

class Student : Person, ICommentable
{
    private int classNumber;
    private List<string> comments = new List<string>();
    public Student(string name)
    {
        this.Name = name;
    }

    public List<string> Comments
    {
        get
        {
            return this.comments;
        }
        set
        {
            this.comments = value;
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

    public int ClassNumber
    {
        get { return this.classNumber; }
        set { this.classNumber = value; }
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendFormat("Name: {0}\n", this.Name);
        if (this.ClassNumber != 0)
        {
            info.AppendFormat("Class number: {0} \n", this.ClassNumber);
        }
        return info.ToString();
    }
   
}

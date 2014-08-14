using System;
using System.Collections.Generic;
using System.Text;

class Teacher : Person,ICommentable
{
    private List<Discipline> disciplines;
    private List<string> comments = new List<string>();
    public Teacher(string name,List<Discipline> disciplines)
    {
        this.Name = name;
        this.Disciplines = disciplines;
    }

    public List<Discipline> Disciplines
    {
        get { return this.disciplines; }
        set { this.disciplines = value; }
    }
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendFormat("Name: {0} \n\n", this.Name);
        info.AppendFormat("Disciplines:\n");
        foreach (var discipline in this.Disciplines)
        {
            info.AppendFormat("{0}\n",discipline);
        }
        return info.ToString();
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
}

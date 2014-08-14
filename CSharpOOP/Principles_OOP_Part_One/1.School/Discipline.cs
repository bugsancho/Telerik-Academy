using System;
using System.Collections.Generic;
using System.Text;

class Discipline : ICommentable
{
    private string name;
    private int numberOfLectures;
    private int numberOfExcercises;
    private List<string> comments = new List<string>();
    public Discipline(string name, int numberOfExcercises, int numberOfLectures)
    {
        this.NumberOfExcercises = numberOfExcercises;
        this.NumberOfLectures = numberOfLectures;
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

    //TODO validation
    public int NumberOfExcercises
    {
        get { return this.numberOfExcercises; }
        set { this.numberOfExcercises = value; }
    }

    public int NumberOfLectures
    {
        get { return this.numberOfLectures; }
        set { this.numberOfLectures = value; }
    }
    
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendFormat("Name: {0} \n", this.Name);
        info.AppendFormat("Number of lectures: {0} \n", this.NumberOfLectures);
        info.AppendFormat("Number of excercises: {0} \n", this.NumberOfExcercises);
        return info.ToString();
    }
}

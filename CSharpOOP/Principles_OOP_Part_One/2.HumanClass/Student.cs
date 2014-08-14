using System.Text;
class Student : Human
{
    private int grade;

    public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
    {
        this.Grade = grade;
    }

    public int Grade
    {
        get { return this.grade; }
        private set { this.grade = value; }
    }
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendFormat("First name: {0}, last name: {1}, grade: {2} \n", this.FirstName, this.LastName, this.Grade);
        return info.ToString();
    }
}

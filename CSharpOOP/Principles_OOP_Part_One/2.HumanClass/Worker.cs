using System.Text;
class Worker : Human
{
    private double weekSalary;
    private double workHoursPerDay;

    public Worker(string firstName, string lastName, double workHoursPerDay, double weekSalary)
        : base(firstName,lastName)
    {
        this.WorkHoursPerDay = workHoursPerDay;
        this.WeekSalary = weekSalary;
    }

    public double WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set { this.workHoursPerDay = value; }
    }
    
    public double WeekSalary
    {
        get { return this.weekSalary; }
        set { this.weekSalary = value; }
    }
    public double CalculateMoneyPerHour()
    {
        double wage = this.WeekSalary / this.WorkHoursPerDay;
        return wage;
    }
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendFormat("First name: {0}, last name: {1}\n", this.FirstName, this.LastName);
        info.AppendFormat("Work hours per day: {0}, weekly salary: {1}\n", this.WorkHoursPerDay, this.WeekSalary);
        return info.ToString();
    }
}
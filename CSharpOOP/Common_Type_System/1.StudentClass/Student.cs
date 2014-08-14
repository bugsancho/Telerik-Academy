using System;
using System.Linq;
//public enumerations used for the student class
public enum Specialty
{
    Economics,
    Physics,
    Medicine,
    Law,
    Jurnalistics,
    Mathematics
}

public enum University
{
    TechnicalUniversity, SofiaUniversity, UniversityOfNationalAndWorldEconomy
}
public enum Faculty
{
    FacultyOfMathematics, FacultyOfPhysics, JuridicalFaculty, MedicalFaculty
}
//a class representing a student, stuffed with all sorts of bull****. I haven't bothered to make any data validation because i found it to be too much hussle for something that is obviously not a challenge.
class Student : ICloneable, IComparable<Student>
{

    //fields
    private string firstName;
    private string middleName;
    private string lastName;
    private int socialSecurityNumber;
    private string address;
    private Specialty studentSpecialty;
    private University studentUniversity;
    private Faculty studentFaculty;
    private string eMail;
    private string course;
    private int phoneNumber;


    //properties
    public int PhoneNumber
    {
        get { return this.phoneNumber; }
        set { this.phoneNumber = value; }
    }

    public string Course
    {
        get { return this.course; }
        set { this.course = value; }
    }

    public string EMail
    {
        get { return this.eMail; }
        set { this.eMail = value; }
    }

    public Faculty StudentFaculty
    {
        get { return this.studentFaculty; }
        set { this.studentFaculty = value; }
    }

    public University StudentUniversity
    {
        get { return this.studentUniversity; }
        set { this.studentUniversity = value; }
    }

    public Specialty StudentSpecialty
    {
        get { return this.studentSpecialty; }
        set { this.studentSpecialty = value; }
    }

    public string Address
    {
        get { return this.address; }
        set { this.address = value; }
    }

    public int SocialSecurityNumber
    {
        get { return this.socialSecurityNumber; }
        set { this.socialSecurityNumber = value; }
    }

    public string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }

    public string MiddleName
    {
        get { return this.middleName; }
        set { this.middleName = value; }
    }

    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }
    //override methods
    public override int GetHashCode()
    {
        return this.SocialSecurityNumber.GetHashCode() ^ this.PhoneNumber.GetHashCode();
    }
    public override bool Equals(object obj)
    {
        return obj is Student && this == (Student)obj;
    }
    public static bool operator ==(Student firstStudent, Student secondStudent)
    {
        return firstStudent.SocialSecurityNumber == secondStudent.SocialSecurityNumber;
    }
    public static bool operator !=(Student firstStudent, Student secondStudent)
    {
        return !(firstStudent == secondStudent);
    }


    public override string ToString()
    {
        return string.Format("PhoneNumber: {0}, Course: {1}, EMail: {2}, StudentFaculty: {3}, StudentUniversity: {4}, StudentSpecialty: {5}, Address: {6}, SocialSecurityNumber: {7}, LastName: {8}, MiddleName: {9}, FirstName: {10}", PhoneNumber, Course, EMail, StudentFaculty, StudentUniversity, StudentSpecialty, Address, SocialSecurityNumber, LastName, MiddleName, FirstName);
    }


    public int CompareTo(Student student)
    {
        if (this.FirstName != student.FirstName)
        {
            return String.Compare(this.FirstName, student.FirstName);
        }
        if (this.LastName != student.LastName)
        {
            return String.Compare(this.LastName, student.LastName);
        }
        if (this.SocialSecurityNumber != student.SocialSecurityNumber)
        {
            return this.SocialSecurityNumber - student.SocialSecurityNumber;
        }
        return 0;
    }
    public object Clone()
    {
        return new Student(this.PhoneNumber, this.Course, this.EMail, this.StudentFaculty, this.StudentUniversity, this.StudentSpecialty, this.Address, this.SocialSecurityNumber, this.LastName, this.MiddleName, this.FirstName);
    }
    //constructor
    public Student(int phoneNumber, string course, string eMail, Faculty studentFaculty, University studentUniversity, Specialty studentSpecialty, string address, int socialSecurityNumber, string lastName, string middleName, string firstName)
    {
        this.PhoneNumber = phoneNumber;
        this.Course = course;
        this.EMail = eMail;
        this.StudentFaculty = studentFaculty;
        this.StudentUniversity = studentUniversity;
        this.StudentSpecialty = studentSpecialty;
        this.Address = address;
        this.SocialSecurityNumber = socialSecurityNumber;
        this.LastName = lastName;
        this.MiddleName = middleName;
        this.FirstName = firstName;
    }
}
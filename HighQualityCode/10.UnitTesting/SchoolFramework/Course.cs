using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFramework
{
    public class Course
    {
        private readonly ICollection<Student> students;
        private string name;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }
        public void AddStudent(Student st)
        {
            if (this.students.Count >= 30)
            {
                throw new InvalidOperationException("Cannot add any more students to the course. The limit of 30 is reached.");
            }
            students.Add(st);
        }
        public void RemoveStudent(Student st)
        {
            if (!this.students.Contains(st))
            {
                throw new InvalidOperationException("The student could not be found in the course.");
            }
            this.students.Remove(st);
        }
        public ICollection<Student> ListStudents()
        {
            return new List<Student>(this.students);
        }
    }
}

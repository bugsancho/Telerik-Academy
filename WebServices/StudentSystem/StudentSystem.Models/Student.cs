namespace StudentSystem.Models
{
    using System.Collections.Generic;
    
    public class Student
    {
        private ICollection<Homework> homeworks;
        private ICollection<Course> courses;

        public int Id { get; set; }

        public string Name { get; set; }

        public string FacultyNumber { get; set; }

        public Student()
        {
            this.homeworks = new HashSet<Homework>();
            this.courses = new HashSet<Course>();
        }

        public virtual ICollection<Homework> Homeworks
        {
            get
            {
                return this.homeworks;
            }
            set
            {
                this.homeworks = value;
            }
        }

        public virtual ICollection<Course> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }
    }
}
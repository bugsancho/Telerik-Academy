using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFramework
{
    public class School
    {
        private readonly ICollection<Course> courses;
        private readonly ICollection<Student> students;

        public School()
        {
            this.courses = new List<Course>();
            this.students = new List<Student>();
        }
        public void CreateCourse(string name)
        {
            if (this.courses.Any(x => x.Name == name))
            {
                throw new InvalidOperationException("A course with that name already exists!");
            }
            var course = new Course(name);
            this.courses.Add(course);
        }
        public void CreateStudent(string name, int id)
        {
            if (this.students.Any(x => x.Id == id))
            {
                throw new InvalidOperationException("A student with such ID already exists!");
            }
            var student = new Student(name,id);
            this.students.Add(student);
        }
        public void EnrollStudentForCourse(string courseName, int studentId)
        {
            if (!this.courses.Any(x => x.Name == courseName))
            {
                throw new InvalidOperationException("No such course!");
            }
            if (!this.students.Any(x => x.Id == studentId))
            {
                throw new InvalidOperationException("No such student!");
            }
            var course = this.courses.First(x => x.Name == courseName);
            var student = this.students.First(x => x.Id == studentId);
            course.AddStudent(student);
        }
        public ICollection<Student> ListStudents()
        {
            return new List<Student>(this.students);
        }
         public ICollection<Course> ListCourses()
        {
            return new List<Course>(this.courses);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolFramework;

namespace SchoolFrameworkTests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void TestStudentAddition()
        {
            var course = new Course("Maths");
            var student = new Student("Gogo", 11001);
            course.AddStudent(student);
            Assert.IsTrue(course.ListStudents().Count == 1);
        }
        [TestMethod]
        public void TestStudentRemoval()
        {
            var course = new Course("Maths");
            var student = new Student("Gogo", 11001);
            course.AddStudent(student);
            course.RemoveStudent(student);
            Assert.IsTrue(course.ListStudents().Count == 0);
        }
         [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestNonExistingStudentRemoval()
        {
            var course = new Course("Maths");
            var student = new Student("Gogo", 11001);
            course.RemoveStudent(student);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourseCreationInvalidName()
        {
            var course = new Course("");
        }
    }
}

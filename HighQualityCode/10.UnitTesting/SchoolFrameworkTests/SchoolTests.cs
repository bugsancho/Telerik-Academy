using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolFramework;

namespace SchoolFrameworkTests
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void TestCourseCreation()
        {
            var school = new School();
            school.CreateCourse("Maths");
            Assert.IsTrue(school.ListCourses().Count == 1, "Invalid number of courses");
        }
        [TestMethod]
        public void TestStudentCreation()
        {
            var school = new School();
            school.CreateStudent("Penko", 10101);
            Assert.IsTrue(school.ListStudents().Count == 1, "Invalid number of students");
        }
        [TestMethod]
        public void TestEnrollStudentForCourse()
        {
            var school = new School();
            school.CreateCourse("Maths");
            school.CreateStudent("Penko", 10101);
            school.EnrollStudentForCourse("Maths", 10101);
            Assert.IsTrue(school.ListCourses().FirstOrDefault().ListStudents().Count == 1);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestDuplicateStudentCreation()
        {
            var school = new School();
            school.CreateStudent("Penko", 10101);
            school.CreateStudent("Goshko", 10101);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestDuplicateCourseCreation()
        {
            var school = new School();
            school.CreateCourse("Maths");
            school.CreateCourse("Maths");
        }
        
    }
}

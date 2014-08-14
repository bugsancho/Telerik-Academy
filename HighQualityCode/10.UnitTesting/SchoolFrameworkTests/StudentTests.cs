using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolFramework;

namespace SchoolFrameworkTests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentCreationInvalidId()
        {
            var student = new Student("Gogo", 1100111);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentCreationInvalidName()
        {
            var student = new Student("", 11111);
        }
       
    }
}

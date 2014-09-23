using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace StudentSystem.Web.Models
{
    public class StudentViewModel
    {
        public static Expression<Func<Student, StudentViewModel>> FromStudent
        {
            get
            {
                return student => new StudentViewModel
                {
                    Id = student.Id,
                    Name = student.Name,
                    FacultyNumber = student.FacultyNumber
                };
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string FacultyNumber { get; set; }
    }
}
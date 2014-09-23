namespace StudentSystem.Web.Controllers
{
    using StudentSystem.Data;
    using StudentSystem.Models;
    using StudentSystem.Web.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class StudentsController : BaseApiController
    {
        public StudentsController(IStudentSystemData data) : base(data)
        {
        }

        [HttpGet]
        public IQueryable<StudentViewModel> All()
        {
            return this.data.Students.All().Select(StudentViewModel.FromStudent);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var student = this.data.Students.Find(id);
            if (student == null)
            {
                return BadRequest("Invalid student id!");
            }

            return Ok(student);
        }

        // POST: api/Students
        [HttpPost]
        public IHttpActionResult Create(StudentViewModel studentModel)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var studentInDb = this.data.Students.Find(studentModel.Id);
            if (studentInDb != null)
            {
                return BadRequest("Student with that Id already exists in the database!");
            }
            var student = new Student() { Name = studentModel.Name, FacultyNumber = studentModel.FacultyNumber, Id = studentModel.Id };
            this.data.Students.Add(student);
            return Ok(student);
        }

        // PUT: api/Students/5
        public void Put(int id, [FromBody]
                        string value)
        {
        }

        // DELETE: api/Students/5
        public void Delete(int id)
        {
        }
    }
}
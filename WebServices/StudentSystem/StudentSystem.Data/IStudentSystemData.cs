namespace StudentSystem.Data
{
    using StudentSystem.Data.Repositories;
    using StudentSystem.Models;

    public interface IStudentSystemData
    {
        IRepository<Student> Students { get; }

        IRepository<Course> Courses { get; }

        IRepository<Homework> Homeworks { get; }

        int SaveChanges();
    }
}
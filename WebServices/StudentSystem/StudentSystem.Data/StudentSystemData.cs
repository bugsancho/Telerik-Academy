namespace StudentSystem.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using StudentSystem.Data.Repositories;
    using StudentSystem.Models;

    public class StudentSystemData 
    {
        private DbContext context;
        private IDictionary<Type, object> repositories;

        public StudentSystemData(DbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }
      
        public IRepository<Student> Students
        {
            get
            {
                return this.GetRepository<Student>();
            }
        }

        public IRepository<Course> Courses
        {
            get
            {
                return this.GetRepository<Course>();
            }
        }

        public IRepository<Homework> Homeworks
        {
            get
            {
                return this.GetRepository<Homework>();
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfRepository = typeof(T);
            if (!this.repositories.ContainsKey(typeOfRepository))
            {
                var newRepository = Activator.CreateInstance(typeof(EFRepository<T>), context);
                this.repositories.Add(typeOfRepository, newRepository);
            }

            return (IRepository<T>)this.repositories[typeOfRepository];
        }
    }
}
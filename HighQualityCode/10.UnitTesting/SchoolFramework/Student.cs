using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFramework
{
    public class Student
    {
        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("Unique student ID must be in the range 10000 to 99999");
                }
                this.id = value;
            }
        }

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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School();
            school.CreateStudent("Penko",10101);
            Console.WriteLine(school.ListStudents().Count);
        }
    }
}

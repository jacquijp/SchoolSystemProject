using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemProject.Models
{
    internal class Student : Person
    {
        public string GradeLevel { get; set; }

        public override void DisplayRole()
        {
            Console.WriteLine($"{FullName} is a student of:{GradeLevel}.");
        }
        public Student()
        {
            Subjects = new List<Subject>();
        }
    }
}

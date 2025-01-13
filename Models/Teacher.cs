using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemProject.Models
{
    internal class Teacher : Person
    {
        public string SubjectSpecialization { get; set; }

        public override void DisplayRole() // This demonstrates polymorphism with the DisplayRole method. It is an abstract method defined in the Person class, but it is implemented with specific behavior in both the Teacher and Student classes.

        {
            Console.WriteLine($"{FullName} is a teacher expert in: {SubjectSpecialization}.");
        }
        public Teacher() 
        {
            Subjects = new List<Subject>(); //Making Subjects list independent every time an object is created
        }
    }

}

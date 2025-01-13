using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemProject.Models
{
    class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int Age;
        public string Address;
        public List<Subject> Subjects;
        //public string[] Subjects; -- - This was used at first cause I didn't have class Subject set neither a way to call a list. Afther Subject class is created I must set the attribute like above.
        public bool HasMedicalCondition;

        public Person()
        {
            Id = 1;
            Subjects = new List<Subject>();
            HasMedicalCondition = false;
        }

        public void PrintSubjects()
        {
            foreach (var item in Subjects)
            {
                Console.WriteLine($"{FirstName} {LastName} is enrolled on: {item.SubjectName}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemProject.Models
{
    internal class Teacher : Person
    {
        public Teacher() 
        {
            Subjects = new List<Subject>(); //Making Subjects list independent every time an object is created
        }
    }
}

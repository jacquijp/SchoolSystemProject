using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemProject.Models
{
    abstract class Person
    {
        private string _FirstName;
        private string _LastName;
        public int Id { get; set; }
        public string FirstName
        {
            get { return _FirstName; }
            set {  _FirstName = value.Trim(); }        
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value.Trim(); }
        }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public int Age { get; set; }
        public string Address { get; set; }
        public bool HasMedicalCondition { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>(); //initializing List so every time that an object is created, the list will be empty from the begginig.

        //public string[] Subjects; -- - This was used at first cause I didn't have class Subject set neither a way to call a list. Afther Subject class is created I must set the attribute like above.
        
        public abstract void DisplayRole();
        public void PrintSubjects()
        {
            foreach (var item in Subjects)
            {

                Console.WriteLine($"{FullName} is enrolled on: {item.SubjectName}");
                
                //Console.WriteLine($"{FirstName} {LastName} is enrolled on: {item.SubjectName}"); -- excluded because FullName has been created and this is not needed now.
            }
        }
    }
}

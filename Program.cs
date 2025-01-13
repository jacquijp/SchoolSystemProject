using System.Text;
using SchoolSystemProject.Models;

//This is a shorter and easier way to create objects
var mathematics = new Subject
{
    SubjectName = "Mathematics",
    Code = "MATH01",
    Credits = 3,
    Modality = Modality.InPerson
};

//This is a more explicit way to create objects - The 1st I used in this project
/*var mathematics = new Subject();
mathematics.SubjectName = "Mathematics";
mathematics.Code = "MATH01";
mathematics.Credits = 3;
mathematics.Modality = Modality.InPerson; */

var english = new Subject
{
    SubjectName = "English",
    Code = "FL1-ENG",
    Credits = 3,
    Modality = Modality.Hybrid
};

/*var english = new Subject();
english.SubjectName = "English";
english.Code = "FL1-ENG";
english.Credits = 4;
english.Modality = Modality.Hybrid;*/

var chemistry = new Subject
{
    SubjectName = "Chemistry",
    Code = "CHEM01",
    Credits = 5,
    Modality = Modality.InPerson
};

/*var chemistry = new Subject();
chemistry.SubjectName = "Chemistry";
chemistry.Code = "CHEM01";
chemistry.Credits = 5;
chemistry.Modality = Modality.InPerson;*/


//Creating a student in the new way
var student1 = new Student
{
    Id = 1,
    FirstName = "Jacqueline",
    LastName = "Jimenez",
    Age = 30,
    Address = "Ostervägen 9A",
    HasMedicalCondition = false,
    Subjects = new List<Subject> { mathematics, english }
};

student1.PrintSubjects();
student1.DisplayRole();

//This is the old way to declare a new object. The on that I used 1st. More explicit.
/*person1.Id = 1;
person1.FirstName = "Jacqueline";
person1.LastName = "Jimenez";
person1.Age = 30;
person1.Address = "Ostervägen 9A";
//person1.Subjects = new[] { "Mathematics", "Physics", "Chemistry" }; //Creating new array values while creating an object - This is not useful after class Subject is created.
person1.HasMedicalCondition = false;*/


var teacher1 = new Teacher
{
    Id = 2,
    FirstName = "Alejandro",
    LastName = "Ordoyo",
    Age = 40,
    Address = "Solnavägen 10",
    HasMedicalCondition = true,
    SubjectSpecialization = "Chemistry",
    Subjects = new List<Subject> { chemistry }
};

/*teacher1.Id = 2;
teacher1.FirstName = "Marcela";
teacher1.LastName = "Lara";
teacher1.Age = 40;
teacher1.Address = "El tapatio 6";
teacher1.HasMedicalCondition = true; */

teacher1.PrintSubjects();
teacher1.DisplayRole();

enum Modality
{
    InPerson,
    Online,
    Hybrid
}
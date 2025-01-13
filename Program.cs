using System.Text;
using SchoolSystemProject.Models;


var mathematics = new Subject();
mathematics.SubjectName = "Mathematics";
mathematics.Code = "MATH01";
mathematics.Credits = 3;
mathematics.Modality = Modality.InPerson;

var english = new Subject();
english.SubjectName = "English";
english.Code = "FL1-ENG";
english.Credits = 4;
english.Modality = Modality.Hybrid;

var chemistry = new Subject();
chemistry.SubjectName = "Chemistry";
chemistry.Code = "CHEM01";
chemistry.Credits = 5;
chemistry.Modality = Modality.InPerson;


var person1 = new Person();

person1.Id = 1;
person1.FirstName = "Jacqueline";
person1.LastName = "Jimenez";
person1.Age = 30;
person1.Address = "Ostervägen 9A";
//person1.Subjects = new[] { "Mathematics", "Physics", "Chemistry" }; //Creating new array values while creating an object - This is not useful after class Subject is created.
person1.HasMedicalCondition = false;
                                                    
List<Subject> subjectsPerson = new List<Subject>();
subjectsPerson.Add(new Subject { SubjectName = "Mathematics", Credits = 3 });
subjectsPerson.Add(new Subject { SubjectName = "English", Credits = 3 });
person1.Subjects = subjectsPerson;
person1.PrintSubjects();

var teacher1 = new Teacher();

teacher1.Id = 2;
teacher1.FirstName = "Marcela";
teacher1.LastName = "Lara";
teacher1.Age = 40;
teacher1.Address = "El tapatio 6";
teacher1.HasMedicalCondition = true;

List<Subject> subjectsTeacher = new List<Subject>();
subjectsTeacher.Add(new Subject { SubjectName = "Chemistry", Credits = 5 });
teacher1.Subjects = subjectsTeacher;
teacher1.PrintSubjects();

enum Modality
{
    InPerson,
    Online,
    Hybrid
}
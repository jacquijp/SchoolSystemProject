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


var person1 = new Person();

person1.Id = 1;
person1.FirstName = "Jacqueline";
person1.LastName = "Jimenez";
person1.Age = 30;
person1.Address = "Ostervägen 9A";
//person1.Subjects = new[] { "Mathematics", "Physics", "Chemistry" }; //Creating new array values while creating an object - This is not useful after class Subject is created.
person1.HasMedicalCondition = false;
                                                        
List<Subject> subjects = new List<Subject>();
subjects.Add(new Subject { SubjectName = "Mathematics", Credits = 3 });
subjects.Add(new Subject { SubjectName = "English", Credits = 3 });
person1.Subjects = subjects;
person1.PrintSubjects();

enum Modality
{
    InPerson,
    Online,
    Hybrid
}
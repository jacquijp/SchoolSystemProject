
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

class Subject  //This is an object list type
{
    public string SubjectName;
    public string Code;
    public int Credits;
    public Modality Modality;
}

enum Modality
{
    InPerson,
    Online,
    Hybrid
}

using LINQDataContext;

DataContext dc = new DataContext();
Course c = new Course();
Grade gr = new Grade();
Professor p = new Professor();
Section sec = new Section();
Student st = new Student();

Student? jdepp = (from student in dc.Students
                  where student.Login == "jdepp"
                  select student).SingleOrDefault();
if (jdepp != null)
{
    Console.WriteLine(jdepp.Last_Name + jdepp.First_Name);
}

var listStudent = from s in dc.Students
                 select new {Nom = s.First_Name, Prenom = s.Last_Name, id = s.Student_ID, anniversaire= s.BirthDate};

foreach(var s in listStudent)
{
    Console.WriteLine("{0} {1} {2} {3}", s.Nom, s.Prenom, s.id, s.anniversaire);
}

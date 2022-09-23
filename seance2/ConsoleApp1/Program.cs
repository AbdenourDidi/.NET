
using LINQDataContext;

DataContext dc = new DataContext();
Course c = new Course();
Grade gr = new Grade();
Professor p = new Professor();
Section sec = new Section();
Student st = new Student();

//test
/*Student? jdepp = (from student in dc.Students
                  where student.Login == "jdepp"
                  select student).SingleOrDefault();
if (jdepp != null)
{
    Console.WriteLine(jdepp.Last_Name + jdepp.First_Name);
}*/


//exo 2.2
/*
var listStudent = from s in dc.Students
                 select new {Nom = s.First_Name, Prenom = s.Last_Name, id = s.Student_ID, anniversaire= s.BirthDate};

foreach(var s in listStudent)
{
    Console.WriteLine("{0} {1} {2} {3}", s.Nom, s.Prenom, s.id, s.anniversaire);
}*/



//exo 3.1
/*
var listStudent = from s in dc.Students
                  where s.BirthDate.Year < 1955
                  select new { Last_name = s.Last_Name, Year_result = s.Year_Result };

foreach(var s in listStudent)
{
    if (s.Year_result >=12)
    {
        Console.WriteLine("{0} {1} OK", s.Last_name, s.Year_result);
    }
    else
    {
        Console.WriteLine("{0} {1} KO", s.Last_name, s.Year_result);
    }
}*/

//exo 3.4
/*
var listStudent = from s in dc.Students
                  where s.Year_Result <= 3
                  orderby s.Year_Result descending
                  select new { nom = s.Last_Name, resultat = s.Year_Result };

foreach(var s in listStudent)
{
    Console.WriteLine("{0} {1} ", s.nom, s.resultat);
}*/


//exo 3.5
/*
var listStudent = from s in dc.Students
                 where s.Section_ID == 1110
                 orderby s.Year_Result 
                 select new { nom = s.Last_Name, prenom = s.First_Name, resultat = s.Year_Result };

foreach (var s in listStudent)
{
    Console.WriteLine("{0} {1} {2} ", s.nom, s.prenom, s.resultat);
}*/

//exo 4.1
/*
IEnumerable<Student> listStudent = from s in dc.Students
                                   select s;

Console.WriteLine(listStudent.Average(c => c.Year_Result));
*/


//exo 4.5
/*
IEnumerable<Student> listStudent = from s in dc.Students
                                   select s;

Console.WriteLine(listStudent.Count());
*/


//exo 5.1
//TODO


//exo 5.3
var listStudent = from s in dc.Students
                 //  join  in Student on s.BirthDate.Month equals month.
                  where s.BirthDate.Year < 1985 && s.BirthDate.Year>1970
                  select new { resultat = s.Year_Result };


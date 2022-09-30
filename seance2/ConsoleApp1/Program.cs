
using LINQDataContext;
using static System.Collections.Specialized.BitVector32;

DataContext dc = new DataContext();

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
                 orderby s.Last_Name
                 select new { nom = s.Last_Name, prenom = s.First_Name, resultat = s.Year_Result };

foreach (var s in listStudent)
{
    Console.WriteLine("{0} {1} {2} ", s.nom, s.prenom, s.resultat);
}*/

//exo 4.1
/*
double moyenne = dc.Students.Average(s => s.Year_Result);
Console.WriteLine("Moyenne = " + moyenne);
*/


//exo 4.5
/*
int nbLignes = dc.Students.Count();
Console.WriteLine("count = " + nbLignes);
*/


//exo 5.1
/*
var sectionResult = from s in dc.Students
                    group s by s.Section_ID;

foreach(IGrouping<Int32, Student> section in sectionResult)
{
    Console.WriteLine("Le max de la section {0} est {1}", section.Key, section.Max(s => s.Year_Result));

}*/


//exo 5.3
/*
var listStudent = from s in dc.Students
                  where (s.BirthDate.Year <= 1985 && s.BirthDate.Year>=1970)
                  group s by s.BirthDate.Month;

foreach(IGrouping<Int32, Student> s in listStudent)
{
    Console.WriteLine("Mois : " + s.Key);
    Console.WriteLine("result moyen : " + s.Average(s => s.Year_Result));
}*/

//exo 5.5
/*
var query = from Cours in dc.Courses
            join prof in dc.Professors on Cours.Professor_ID equals prof.Professor_ID
            join sect in dc.Sections on prof.Section_ID equals sect.Section_ID
            select new { Cours.Course_Name, prof.Professor_Name, sect.Section_Name };


foreach(var s in query)
{
    Console.WriteLine(s.Course_Name + " " + s.Section_Name + " " + s.Professor_Name);


}*/

//exo 5.7
/*
var query = from s in dc.Sections
               join prof in dc.Professors on s.Section_ID equals prof.Section_ID into sectProfs
               select new { nomsection = s.Section_Name, nomsprofs = sectProfs };


foreach (var s in query)
{
    Console.WriteLine("Section : " + s.nomsection);
    foreach (Professor p in s.nomsprofs)
    {
        Console.WriteLine("Prof : " + p.Professor_Name);
    }
}*/

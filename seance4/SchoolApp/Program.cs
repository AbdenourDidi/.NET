// See https://aka.ms/new-console-template for more information
using School.Repository;
using SchoolApp.Models;
using SchoolApp.Repository;
using SchoolApp.UnitsOfWork;

//B exo 2ab 
SchoolContext schoolContext = new SchoolContext();

IUnitOfWorkSchool unitOfWorkSchool = new UnitOfWorkSchoolMemory();
IRepository<Section> repoSect = unitOfWorkSchool.SectionsRepository;
IStudentRepository repoStud = unitOfWorkSchool.StudentsRepository;

//BaseRepositorySQL<Section> baseRepositorySQLSection = new BaseRepositorySQL<Section>(schoolContext);
//StudentRepositorySQLServer baseRepositorySQLStudent = new StudentRepositorySQLServer(schoolContext);

Section sectInfo = new Section { Name = "sectInfo" };
Section sectDiet = new Section { Name = "sectDiet" };

repoSect.Save(sectInfo, (s => s.Name == "sectInfo"));
repoSect.Save(sectDiet, (s => s.Name == "sectDiet"));


//question
IList<Section> listSection = baseRepositorySQLSection.GetAll();



if (listSection.Count > 0)
{
    Console.WriteLine("ajout fais");
}

//B exo 2cd

Student studinfo1 = new Student { Name = "studinfo1",  Firstname = "studinfo1", YearResult = 100, Section=sectInfo};
Student studdiet = new Student { Name = "studdiet", Firstname = "studdiet", YearResult = 120, Section=sectDiet};
Student studinfo2 = new Student { Name = "studinfo2", Firstname = "studinfo2", YearResult = 110, Section = sectInfo };

repoStud.Save(studinfo1, (s => s.Name == "studinfo1"));
repoStud.Save(studdiet, (s => s.Name == "studdiet"));
repoStud.Save(studinfo2, (s => s.Name == "studinfo2"));

IList<Student> students = repoStud.GetStudentBySectionOrderByYearResult();

foreach(Student s in students)
{
    Console.WriteLine("Section {0}, Etudiant {1}, Year resultat {2}", s.Section.Name, s.Name, s.YearResult);
}















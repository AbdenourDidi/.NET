// See https://aka.ms/new-console-template for more information
using SchoolApp.Models;
using SchoolApp.Repository;

Console.WriteLine("Hello, World!");

SchoolContext schoolContext = new SchoolContext();
BaseRepositorySQL<Section> baseRepositorySQL = new BaseRepositorySQL<Section>(schoolContext);

Section sectInfo = new Section { Name = "sectInfo" };
Section sectDiet = new Section { Name = "sectDiet" };

baseRepositorySQL.Save(sectInfo, (s => s.Name == "sectInfo"));
baseRepositorySQL.Save(sectDiet, (s => s.Name == "sectDiet"));








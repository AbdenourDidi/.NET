

using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

NorthwindContext context = new NorthwindContext();

//BExo 1
/*Console.WriteLine("recheche clients par ville \nEntrez le nom d'une ville : ");
IQueryable<Customer> customers = from c in context.Customers
                                 
                                 where c.City == Console.ReadLine()
                                 select c;

foreach (Customer c in customers)
{
    Console.WriteLine("{0} : {1}",c.CustomerId, c.ContactName);
}*/

//BExo 2
/*IQueryable<Category> list = from c in context.Categories
                            where c.CategoryName == "Beverages" || c.CategoryName == "Condiments"
                            orderby c.CategoryName 
                            select c;

foreach (Category item in list)
{
        if(item.CategoryName == "Condiments")
    {
        Console.WriteLine("\nCatégorie : Condiments");
    } else {
        Console.WriteLine("Catégorie : Beverages");
    }
    foreach (Product product in item.Products)
        {
            Console.WriteLine("{0}", product.ProductName);
        }
}*/

//BExo 3
/*IQueryable<Category> list = from c in context.Categories
                            .Include("Products")
                            where c.CategoryName == "Beverages" || c.CategoryName == "Condiments"
                            orderby c.CategoryName
                            select c;


foreach (Category item in list)
{
    if (item.CategoryName == "Condiments")
    {
        Console.WriteLine("\nCatégorie : Condiments");
    }
    else { 
        Console.WriteLine("Catégorie : Beverages"); 
    }
    foreach (Product product in item.Products)
    {
        Console.WriteLine("{0}", product.ProductName);
    }
}*/

//BExo 4
/*Console.WriteLine("Entrez l'ID d'un client");
IQueryable<Order> orders = from o in context.Orders
                           where o.CustomerId == Console.ReadLine() && o.ShippedDate != null
                           orderby o.ShippedDate descending
                           select o;

foreach (Order o in orders)
{
    Console.WriteLine("CustomerID : {0} OrderDate : {1} ShippedDate :{2}", o.CustomerId, o.OrderDate, o.ShippedDate);

}*/

//BExo5 TODO
/*IQueryable<IGrouping<int, OrderDetail>> orderDetails = from od in context.OrderDetails
                   orderby od.ProductId
                   group od by od.ProductId;

foreach (IGrouping<int, OrderDetail> od in orderDetails)
{
    foreach (OrderDetail o in od)
    {
        Console.WriteLine("{0} ----> {1}", o.ProductId, od.Sum(o => o.Quantity * o.UnitPrice));
    }
}*/


//BExo6 question any??
/*Console.WriteLine("Liste des employés de la région Western");
 IQueryable<Employee> employees = from e in context.Employees
                                  where e.Territories.Any(t =>t.Region.RegionDescription == "Western")
                                  select e;

foreach(Employee e in employees)
{
    Console.WriteLine("{0} {1}", e.LastName, e.FirstName);
}*/

//BExo7 erreur ??
/*Console.WriteLine("les territoires gérés par le supérieur de Suyama");
IQueryable<Employee> employees = from e in context.Employees
                                 .Include("Territories")
                                 where e.LastName == "Suyama"
                                 select e;

foreach (Employee employee in employees)
{
    foreach (Territory t in employee.Territories)
    {
        Console.WriteLine(t.TerritoryDescription);
    }
}*/

//CExo1
/*IQueryable<Customer> query = from c in context.Customers
                             select c;

foreach (Customer customer in query)
{
    customer.ContactName = customer.ContactName.ToUpper();
}
context.SaveChanges();

//CExo2
IQueryable<Customer> list = from c in context.Customers
                             select c;

foreach (Customer customer in list)
{
    Console.WriteLine(customer.ContactName);
}*/

//DExo1
/*Console.WriteLine("Entrez une catégorie à ajouter");
string cate = Console.ReadLine();

Category categories = (from c in context.Categories
                                  where c.CategoryName == cate
                                  select c).SingleOrDefault<Category>();
if (categories == null)
{
    categories = new Category { CategoryName = cate };
    context.Categories.Add(categories);
    context.SaveChanges();
}
else
{
    Console.WriteLine("Une catégorie existe déjà avec ce nom");
}*/

//EExo1
/*string cate = Console.ReadLine();

  Category categories = (from c in context.Categories
                       where c.CategoryName == cate
                       select c).SingleOrDefault<Category>();

context.Categories.Remove(categories);
context.SaveChanges();*/

//EExo2
/*Category categories = (from c in context.Categories
                       where c.CategoryName == "informatique"
                       select c).SingleOrDefault<Category>();
if(categories == null)
{
    Console.WriteLine("la categorie Informatique supprimer");
}*/

//EExo3 & 4
/*Console.WriteLine("Entrez l'ID de l'employé à supprimer");
string emp1 = Console.ReadLine();


Console.WriteLine("Entrez l'ID de l'employé qui reprend les Orders de celui à supprimer");
string emp2 = Console.ReadLine();

if (!int.TryParse(emp1, out int e1))
{
    Console.WriteLine("Employé 1 inconnu");
}
if (!int.TryParse(emp2, out int e2))
{
    Console.WriteLine("Employé 2 inconnu");
}

Employee employee1 = (from e in context.Employees.Include("Territories").Include("InverseReportsToNavigation")
                      where e.EmployeeId == e1
                      select e).Single<Employee>();


Employee employee2 = (from e in context.Employees
                      where e.EmployeeId == e2
                      select e).Single<Employee>();

IQueryable<Order> employee1Orders = (from o in context.Orders
                                     where o.EmployeeId == e1
                                     select o);

foreach (Order o in employee1Orders)
{
    employee2.Orders.Add(o);
    employee1.Orders.Remove(o);

}

employee1.Territories.Clear();
employee1.InverseReportsToNavigation.Clear();



context.Employees.Remove(employee1);
context.SaveChanges();*/











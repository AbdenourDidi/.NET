using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    internal class EmployeesVM
    {
        private List<EmployeeModel> _employeesList;
        private NorthwindContext context = new NorthwindContext();


        public List<EmployeeModel> EmployeesList
        {
            get { return _employeesList = _employeesList?? LoadEmployees(); } 
        }

        private List<EmployeeModel> LoadEmployees()
        {
            List<EmployeeModel> localCollection = new List<EmployeeModel>(); 
            foreach(var item in context.Employees)
            {
                localCollection.Add(new EmployeeModel(item));
            }

            return localCollection;

        }
    }
}

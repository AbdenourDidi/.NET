using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEmployee.Models
{
    class EmployeeModel
    {
        private readonly Employee _employee;

        public EmployeeModel (Employee employee)
        {
            _employee = employee;
        }

        public int EmployeeId { get { return _employee.EmployeeId; } }

        public string LastName { get { return _employee.LastName; } }

        public string Firstname { get { return _employee.FirstName; } }

        public string? Title { get { return _employee.Title;  } }

        public DateTime? BirthDate { get { return _employee.BirthDate;  } }

        public string FullName { get { return _employee.FirstName + " " + _employee.LastName; } }
        
        public string DisplayBirthDate { get { return _employee.BirthDate.ToString(); } }


    }
}

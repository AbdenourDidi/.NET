using Nortwind_API.Models;
using Nortwind_API.Repository;

namespace Nortwind_API.UnitsOfWork
{
    internal class UnitOfWorkNorthwindSQLServer : IUnitOfWorkNorthwind
    {
        
        private readonly NorthwindContext _context;

        private BaseRepositorySQL<Employee> _employeesRepository;
        private BaseRepositorySQL<Order> _ordersRepository;


        public UnitOfWorkNorthwindSQLServer(NorthwindContext context)
        {
            _context = context;
            this._employeesRepository = new BaseRepositorySQL<Employee>(context);
            this._ordersRepository = new BaseRepositorySQL<Order>(context);
        }

        public IRepository<Order> OrderRepository
        {
            get { return this._ordersRepository; }
        }

        public IRepository<Employee> EmployeeRepository
        {
            get { return this._employeesRepository; }
        }
    }
}

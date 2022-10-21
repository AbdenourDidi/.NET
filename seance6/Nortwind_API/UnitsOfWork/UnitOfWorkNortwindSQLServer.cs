using Nortwind_API.Models;
using Nortwind_API.Repository;

namespace Nortwind_API.UnitsOfWork
{
    internal class UnitOfWorkNortwindSQLServer
    {
        private readonly NorthwindContext _context;

        private BaseRepositorySQL<Employee> _employeesRepository;
        private BaseRepositorySQL<Order> _ordersRepository;


        public UnitOfWorkNortwindSQLServer(NorthwindContext context)
        {
            _context = context;
            this._employeesRepository = new BaseRepositorySQL<Employee>(context);
            this._ordersRepository = new BaseRepositorySQL<Order>(context);
        }

        public IRepository<Order> OrdersRepository
        {
            get { return this._ordersRepository; }
        }

        public IRepository<Employee> EmployeesRepository
        {
            get { return this._employeesRepository; }
        }
    }
}

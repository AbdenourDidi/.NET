using Nortwind_API.Models;
using Nortwind_API.Repository;

namespace Nortwind_API.UnitsOfWork
{
    
     class UnitOfWorkNortwindMemory : IUnitOfWorkNorthwind
    {
        private EmployeeRepositoryMemory _employeeRepository;

        private OrderRepositoryMemory _orderRepository;

        public UnitOfWorkNortwindMemory()
        {
            this._employeeRepository = new EmployeeRepositoryMemory();
            this._orderRepository = new OrderRepositoryMemory();
        }

        public IRepository<Employee> EmployeeRepository
        {
            get { return this._employeeRepository; }
        }
        public IRepository<Order> OrderRepository
        {
            get { return this._orderRepository; }

        }
    }
}

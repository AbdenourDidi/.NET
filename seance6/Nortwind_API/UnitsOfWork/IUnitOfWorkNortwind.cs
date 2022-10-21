using Nortwind_API.Models;
using Nortwind_API.Repository;

namespace Nortwind_API.UnitsOfWork
{
    public interface IUnitOfWorkNortwind
    {
        IRepository<Employee> EmployeeRepository { get; }

        IRepository<Order> OrderRepository { get; }

    }
}

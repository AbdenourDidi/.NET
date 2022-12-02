using Nortwind_API.Models;
using System.Linq.Expressions;

namespace Nortwind_API.Repository
{
    
    internal class EmployeeRepositoryMemory : IRepository<Employee>
    {
        private List<Employee> _employees;

        public EmployeeRepositoryMemory()
        {
            _employees = new List<Employee>();
        }

        public Task DeleteAsync(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Employee>> GetAllAsync()
        {
            throw new NotImplementedException();
        }


        public Task<Employee?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }


        public Task InsertAsync(Employee entity)
        {
            throw new NotImplementedException();
        }


        public Task<bool?> SaveAsync(Employee entity, Expression<Func<Employee, bool>> predicate)
        {
            throw new NotImplementedException();
        }


        public Task<IList<Employee>> SearchForAsync(Expression<Func<Employee, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}

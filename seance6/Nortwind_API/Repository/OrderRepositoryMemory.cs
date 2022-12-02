using Nortwind_API.Models;
using static System.Collections.Specialized.BitVector32;
using System.Linq.Expressions;

namespace Nortwind_API.Repository
{
    internal class OrderRepositoryMemory : IRepository<Order>
    {
        private List<Order> _orders;

        public OrderRepositoryMemory()
        {
            _orders = new List<Order>();
        }

        public Task DeleteAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool?> SaveAsync(Order entity, Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Order>> SearchForAsync(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    } 
}

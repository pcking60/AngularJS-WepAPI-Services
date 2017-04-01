using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface IOrderRepository:IRepository<Order> { }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(DBFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
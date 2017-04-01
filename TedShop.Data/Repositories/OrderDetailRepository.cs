using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface IOrderDetailRepository { }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderRepository
    {
        public OrderDetailRepository(DBFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface ISupportOnlineRepository:IRepository<SupportOnline> { }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(DBFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
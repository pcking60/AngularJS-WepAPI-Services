using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface ISystemConfigRepositor:IRepository<SystemConfig> { }

    internal class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepositor
    {
        public SystemConfigRepository(DBFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
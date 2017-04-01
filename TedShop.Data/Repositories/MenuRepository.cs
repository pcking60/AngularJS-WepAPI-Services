using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface IMenuRepository:IRepository<Menu> { }

    internal class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(DBFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
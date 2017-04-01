using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface IMenuRepository { }

    internal class MenuRepository : RepositoryBase<Menu>, IMenuGroupRepository
    {
        public MenuRepository(DBFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
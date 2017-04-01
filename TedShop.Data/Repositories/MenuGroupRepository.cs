using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface IMenuGroupRepository:IRepository<MenuGroup> { }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(DBFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface IPageRepository:IRepository<Page> { }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(DBFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPostCategoryRepository:IRepository<PostCategory> { }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(DBFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
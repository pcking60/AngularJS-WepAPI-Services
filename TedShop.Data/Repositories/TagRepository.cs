using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface ITagRepository { }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(DBFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
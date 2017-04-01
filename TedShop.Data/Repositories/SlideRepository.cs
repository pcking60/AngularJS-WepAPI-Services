using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface ISlideRepository:IRepository<Slide> { }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(DBFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
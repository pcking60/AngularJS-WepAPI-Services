using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public class ProductCaterogyRepository: RepositoryBase<ProductCategory>
    {
        public ProductCaterogyRepository(IDBFactory dbFactory): base(dbFactory)
        {

        }

    }
}

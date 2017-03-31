using TedShop.Data;
using TeudShop.Data.Infrastructure;

namespace TeduShop.Data.Infrastructure
{
    public class DBFactory : Dispoable, IDBFactory
    {
        private TeduShopDBContext dbContext;

        public TeduShopDBContext Init()
        {
            return dbContext ?? (dbContext = new TeduShopDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
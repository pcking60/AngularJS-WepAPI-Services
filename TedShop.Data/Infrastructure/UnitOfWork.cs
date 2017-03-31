using TedShop.Data;

namespace TeduShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDBFactory dbFactory;
        private TeduShopDBContext dbContext;

        public UnitOfWork(IDBFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public TeduShopDBContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
using System;
using TedShop.Data;

namespace TeduShop.Data.Infrastructure
{
    public interface IDBFactory : IDisposable
    {
        TeduShopDBContext Init();
    }
}
﻿using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface IOrderDetailRepository:IRepository<OrderDetail> { }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(DBFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
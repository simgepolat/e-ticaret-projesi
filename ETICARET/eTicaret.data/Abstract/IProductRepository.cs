using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicaret.entity;

namespace eTicaret.data.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        List<Product> GetPopularProducts();
    }
}
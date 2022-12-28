using System.Collections.Generic;
using eTicaret.entity;

namespace eTicaret.data.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
       List<Product> GetPopularProducts();
       List<Product> GetTop5Products();
    }
}
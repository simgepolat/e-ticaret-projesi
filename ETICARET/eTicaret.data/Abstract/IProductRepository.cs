using System.Collections.Generic;
using eTicaret.entity;

namespace eTicaret.data.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string name);
       List<Product> GetPopularProducts();
       List<Product> GetTop5Products();
    }
}
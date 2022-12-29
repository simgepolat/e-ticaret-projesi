using System.Collections.Generic;
using eTicaret.entity;

namespace eTicaret.business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        Product GetByIdWithCategories(int id);
        Product GetProductDetails(string url);
        List<Product> GetProductByCategory(string name, int page, int pageSize);

        List<Product> GetAll();
        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);

        void Create(Product entity);

        void Update(Product entity);
        void Delete(Product entity);
        int GetCountByCategory(string category);
        void Update(Product entity, int[] categoryIds);
    }
}
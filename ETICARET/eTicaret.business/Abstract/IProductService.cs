using System.Collections.Generic;
using eTicaret.entity;

namespace eTicaret.business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);

        List<Product> GetAll();

        void Create(Product entity);

        void Update(Product entity);
        void Delete(Product entity);
    }
}
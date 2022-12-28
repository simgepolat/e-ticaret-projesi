using System.Collections.Generic;
using eTicaret.business.Abstract;
using eTicaret.data.Abstract;
using eTicaret.data.Concrete.EfCore;
using eTicaret.entity;

namespace eTicaret.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            // iş kuralları uygula
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            // iş kuralları
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {            
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public List<Product> GetProductByCategory(string name)
        {
            return _productRepository.GetProductsByCategory(name);
        }

        public Product GetProductDetails(string url)
        {
            return _productRepository.GetProductDetails(url);
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
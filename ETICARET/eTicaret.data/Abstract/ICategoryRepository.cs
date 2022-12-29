using System.Collections.Generic;
using eTicaret.entity;

namespace eTicaret.data.Abstract
{
    public interface ICategoryRepository: IRepository<Category>
    {
        
        Category GetByIdWithProducts(int categoryId);
        void DeleteFromCategory( int productId, int categoryId);
    }
}
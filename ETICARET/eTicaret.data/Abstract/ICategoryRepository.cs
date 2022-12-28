using System.Collections.Generic;
using eTicaret.entity;

namespace eTicaret.data.Abstract
{
    public interface ICategoryRepository: IRepository<Category>
    {
        List<Category> GetPopularCategories();
    }
}
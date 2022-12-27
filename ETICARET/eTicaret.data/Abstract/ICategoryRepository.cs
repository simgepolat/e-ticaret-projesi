using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicaret.entity;

namespace eTicaret.data.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
        List<Category> GetPopularCategories();
    }
}
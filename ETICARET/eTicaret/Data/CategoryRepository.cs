using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicaret.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories=null;

        static CategoryRepository()
        {
            _categories= new List<Category>
            {
                new Category {CategoryId=1, Name="Defter",Descirption="Defter kategorisi"},
                new Category {CategoryId=2, Name="Kalem",Descirption="Kalem kategorisi"},
                new Category {CategoryId=3, Name="Canta",Descirption="Canta kategorisi"},
                new Category {CategoryId=4, Name="Silgi",Descirption="Silgi kategorisi"}
            };

        }

        public static List<Category> Categories
        {
            get{
                return _categories;
            }
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategorybyId(int id)
        {
            return _categories.FirstOrDefault(c=>c.CategoryId==id);
        }
    }
}
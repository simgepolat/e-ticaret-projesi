using System.Collections.Generic;

namespace eTicaret.entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicaret.entity;

namespace eTicaret.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
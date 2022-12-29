using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using eTicaret.entity;

namespace eTicaret.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage="Kategori adı giriniz.")]
        [StringLength(50,MinimumLength=5,ErrorMessage="Kategori için 5-50 arasında değer giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage="Url giriniz.")]
        [StringLength(100,MinimumLength=5,ErrorMessage="Url için 5-100 arasında değer giriniz.")]
        public string Url { get; set; }
        public List<Product> Products { get; set; }
    }
}
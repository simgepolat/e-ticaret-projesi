using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using eTicaret.entity;

namespace eTicaret.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }  
        [Display(Name="Name",Prompt="Ürün adı giriniz.")]
        public string Name { get; set; }       
        public string Url { get; set; }  
        [Display(Name="Fiyat")]     
        public double? Price { get; set; } 
        [Display(Name="Açıklama")] 
        public string Description { get; set; }  
        [Display(Name="resim")]        
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
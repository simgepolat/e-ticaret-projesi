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
        [Required(ErrorMessage="Url giriniz.")]    
        public string Url { get; set; }  
        [Display(Name="Fiyat")]     
        public double? Price { get; set; } 
        [Display(Name="Açıklama")] 
        [Required(ErrorMessage="Açıklama giriniz.")]
        [StringLength(150,MinimumLength=5,ErrorMessage="Açıklama 5-150 karakter aralığında olmalıdır.")]
        public string Description { get; set; }  
        [Display(Name="resim")]    
        [Required(ErrorMessage="Resim giriniz.")]      
        public string ImageUrl { get; set; }
        [Display(Name="Onaylı")] 
        public bool IsApproved { get; set; }
        [Display(Name="Anasayfa")] 
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
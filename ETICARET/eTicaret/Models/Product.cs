using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicaret.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(250,MinimumLength =5,ErrorMessage ="Ürün ismi ayrıntılı ve kapsamlı olmalı!")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Fiyat girilmeli!")]
        public double? Price { get; set; }
        public string Description { get; set; }

        [Required]
         public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public int CategoryId { get; set; }
    }
}
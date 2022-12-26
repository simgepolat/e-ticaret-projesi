using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTicaret.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
            {
                var product= new Product{Name="Iphone X",Price=6000,Description="hoş bir telefon"};
                ViewData["Category"]="Telefonlar";
                ViewData["Product"]=product;
            

                return View();
            }
        
        public IActionResult list()
        {
            var products=new List<Product>()
            {
                new Product {Name="Dörtlü Defter",Price=40,Description="plastik kapak, A4 boyut, 70 yaprak, 2 kareli 2 çizgili" },
                new Product{Name="Çiçek desenli Defterler",Price=120,Description="Sert kapak, 100 yaprak, A5 boyut, çizgisiz", IsApproved=true},
                new Product {Name="Tweety desenli defter",Price=37,Description="Sarı sert kapak, A5 boyut, 60 yaprak, çizgili" },
                new Product{Name="Mor Not Defteri",Price=45 ,Description="Sert deri kapak, Notebook, çizgili, 50 yaprak"},
                new Product {Name="Kiraz desenli Defter",Price=30,Description="Spiralli, sert kapak, A5 boyut, 100 yaprak, kareli ", IsApproved=true },
                new Product{Name="Kaktüs desenli defter",Price=30,Description="Spiralli, sert kapak, A5 boyut, 100 yaprak, çizgili ", IsApproved=true}
            };

          
            
            var ProductViewModel=new ProductViewModel()
            {
                Products=products
            };


            return View(ProductViewModel);   
        }
        public IActionResult Details(int id)
            {
                var p= new Product();
                p.Name="dörtlü defter";
                p.Price=40;
                p.Description="plastik kapak, A4 boyut, 70 yaprak, 2 kareli 2 çizgili";

                return View(p);
            }
    }
}
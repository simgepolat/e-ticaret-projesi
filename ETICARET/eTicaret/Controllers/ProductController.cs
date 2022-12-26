using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicaret.Data;
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
        
        public IActionResult list(int? id)
        {
            // Console.WriteLine(RouteData.Values["contoller"]);
            // Console.WriteLine(RouteData.Values["action"]);
            // Console.WriteLine(RouteData.Values["id"]);

            var products=ProductRepository.Products;
            if(id!=null)
            {
                products=products.Where(p=>p.CategoryId==id).ToList();
            }

            var ProductViewModel=new ProductViewModel()
            {
                Products=products
            };


            return View(ProductViewModel);   
        }
        public IActionResult Details(int id)
            {
                return View(ProductRepository.GetProductById(id));
            }
    }
}
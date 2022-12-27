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
        
        public IActionResult list(int? id, string q)
        {
            // Console.WriteLine(RouteData.Values["contoller"]);
            // Console.WriteLine(RouteData.Values["action"]);
            // Console.WriteLine(RouteData.Values["id"]);

            // QueryString
            // Console.WriteLine(HttpContext.Request.Query["q"].ToString());

            var products=ProductRepository.Products;

            if(id!=null)
            {
                products=products.Where(p=>p.CategoryId==id).ToList();
            }

            if(!string.IsNullOrEmpty(q))
            {
                products= products.Where(i=>i.Name.ToLower().Contains(q.ToLower()) || i.Description.ToLower().Contains(q.ToLower())).ToList();
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
        
        public IActionResult Create(string name, double price)
        {
            return View();
        }
    }
}
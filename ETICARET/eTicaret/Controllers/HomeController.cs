using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicaret.Data;
using eTicaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTicaret.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            var ProductViewModel=new ProductViewModel()
            {
            
                Products=ProductRepository.Products
            };


            return View(ProductViewModel);
        }
        public IActionResult About()
            {
                return View();
            }
        public IActionResult Contact()
        {
            return View("MyView");
        }
        
    }
}
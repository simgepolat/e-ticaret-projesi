using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicaret.data.Abstract;
using eTicaret.data;
using Microsoft.AspNetCore.Mvc;
using eTicaret.business.Abstract;
using eTicaret.Models;

namespace eTicaret.Controllers
{
    public class HomeController:Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            this._productService=productService;
        }



        public IActionResult Index()
        {
            var ProductViewModel=new ProductListViewModel()
            {
            
                Products= _productService.GetHomePageProducts()
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
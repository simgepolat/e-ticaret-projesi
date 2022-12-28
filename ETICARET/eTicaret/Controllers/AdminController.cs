using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicaret.business.Abstract;
using eTicaret.entity;
using eTicaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTicaret.Controllers
{
    public class AdminController:Controller
    {
        private IProductService _productService;

        public AdminController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult ProductList()
        {
            return View(new ProductListViewModel()
            {
                Products = _productService.GetAll()
            });
        }


        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateProduct(ProductModel model)
        {
            var entity = new Product()
            {
                Name = model.Name,
                Url = model.Url,
                Price = model.Price,
                Description = model.Description,
                ImageUrl = model.ImageUrl
            };
            
            _productService.Create(entity);

            return RedirectToAction("ProductList");
        }
    }
}
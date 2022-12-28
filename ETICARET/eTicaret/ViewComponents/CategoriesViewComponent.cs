using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicaret.business.Abstract;
using eTicaret.data;
using Microsoft.AspNetCore.Mvc;

namespace eTicaret.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        private ICategoryService _categoryService;

        public CategoriesViewComponent(ICategoryService categoryService)
        {
            this._categoryService=categoryService;
        }

        public IViewComponentResult Invoke()
        {
             if(RouteData.Values["action"].ToString()=="list")
                 ViewBag.SelectedCategory=RouteData?.Values["id"];
             return View(_categoryService.GetAll());
            
        }
    }
}
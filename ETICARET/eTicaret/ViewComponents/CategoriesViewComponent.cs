using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicaret.data;
using Microsoft.AspNetCore.Mvc;

namespace eTicaret.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // if(RouteData.Values["action"].ToString()=="list")
            //     ViewBag.SelectedCategory=RouteData?.Values["id"];
            // return View(CategoryRepository.Categories);
            return View();
        }
    }
}
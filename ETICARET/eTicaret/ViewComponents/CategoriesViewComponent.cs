using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eTicaret.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
             var categories= new List<Category>()
            {
                new Category {Name="Defter",Descirption="Defter kategorisi"},
                new Category {Name="Kalem",Descirption="Kalem kategorisi"},
                new Category {Name="Canta",Descirption="Canta kategorisi"},
                new Category {Name="Silgi",Descirption="Silgi kategorisi"}

            };
            return View(categories);
        }
    }
}
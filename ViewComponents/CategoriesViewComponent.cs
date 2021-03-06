using ETicaret.WebUI.Data;
using ETicaret.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.WebUI.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString() == "list")
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
        }
    }
}

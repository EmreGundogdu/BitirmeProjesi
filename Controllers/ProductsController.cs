using ETicaret.WebUI.Data;
using ETicaret.WebUI.Models;
using ETicaret.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.WebUI.Controllers
{
    public class ProductsController : Controller
    {        
        public IActionResult Index()
        {
            var product = new Product { Name = "Iphone X", Price = 6000, Description = "güzel telefon" };


            ViewBag.Category = "Telefonlar";
            
            return View(product);
        }
        public IActionResult list()
        {

            var productViewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products
            };

            return View(productViewModel);
        }

        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }
    }
}

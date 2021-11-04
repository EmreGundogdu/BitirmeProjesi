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
            return View();
        }
        public IActionResult list(int? id,string q)
        {
            var products = ProductRepository.Products;
            if (id!=null)
            {
                products = products.Where(x => x.CategoryId == id).ToList();
            }
            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(x => x.Name.Contains(q) || x.Description.Contains(q)).ToList();
            }

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }

        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }
    }
}

using ETicaret.WebUI.Data;
using ETicaret.WebUI.Models;
using ETicaret.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");
            return View(new Product());
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            ProductRepository.AddProduct(product);
            return RedirectToAction("list");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(ProductRepository.GetProductById(id));
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ProductRepository.EditProduct(product);
            return RedirectToAction("list");
        }
    }
}

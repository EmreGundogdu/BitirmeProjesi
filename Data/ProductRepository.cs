using ETicaret.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.WebUI.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;
        static ProductRepository()
        {
            _products = new List<Product>
            {

                new Product {ProductId=1, Name="IPhone 11",Price=8000,Description="çok iyi telefon",IsApproved=true,ImageUrl="iphone11.jpg",CategoryId=1},
                new Product {ProductId=2,Name="IPhone 12",Price=10000,Description="çok iyi telefon",IsApproved=true,ImageUrl="iphone12.jpg",CategoryId=1},
                new Product {ProductId=3,Name="IPhone 7",Price=4000,Description="iyi telefon",IsApproved=true,ImageUrl="iphone7.jpg",CategoryId=1},
                new Product {ProductId=4,Name="IPhone X",Price=6000,Description="iyi telefon",IsApproved=true,ImageUrl="iphoneX.jpg",CategoryId=1},
                new Product {ProductId=5,Name="Asus Laptop",Price=9000,Description="İyi Bir Laptop",IsApproved=true,ImageUrl="asus.jpg",CategoryId=2},
                new Product {ProductId=5,Name="MSI Laptop",Price=14000,Description="Pahalı Bir Laptop",IsApproved=true,ImageUrl="msi.jpg",CategoryId=2},
                new Product {ProductId=5,Name="Dell Laptop",Price=6000,Description="Ucuz Bir Laptop",IsApproved=true,ImageUrl="dell.jpg",CategoryId=2},
            };
        }
        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(x => x.ProductId == id);
        }
        public static void EditProduct(Product product)
        {
            foreach (var item in _products)
            {
                if (item.ProductId == product.ProductId)
                {
                    item.Name = product.Name;
                    item.Price = product.Price;
                    item.ImageUrl = product.ImageUrl;
                    item.Description = product.Description;
                    item.IsApproved = product.IsApproved;
                    item.CategoryId = product.CategoryId;
                }
            }
        }
        public static void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}

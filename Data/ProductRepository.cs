﻿using ETicaret.WebUI.Models;
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

                new Product {ProductId=1, Name="IPhone 11",Price=8000,Description="çok iyi telefon",IsApproved=true,ImageUrl="iphone11.jpg"},
                new Product {ProductId=2,Name="IPhone 12",Price=10000,Description="çok iyi telefon",IsApproved=true,ImageUrl="iphone12.jpg"},
                new Product {ProductId=3,Name="IPhone 7",Price=4000,Description="iyi telefon",IsApproved=true,ImageUrl="iphone7.jpg"},
                new Product {ProductId=4,Name="IPhone X",Price=6000,Description="iyi telefon",IsApproved=true,ImageUrl="iphoneX.jpg"}
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
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using prjBS.Models;

namespace prjBS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = "AEL019800", Name= "跟著實務學習ASP.NET MVC 5", Price=540 });
            products.Add(new Product { Id = "AEL021400", Name = "跟著實務學習網頁設計", Price = 500 });
            products.Add(new Product { Id = "AEL022231", Name = "跟著實務學習 Bootstrap與JS", Price = 540 });
            products.Add(new Product { Id = "AEL022131", Name = "Python基礎必修課-第二版", Price = 450 });
            products.Add(new Product { Id = "AEL022500", Name = "Java SE 12基礎必修課", Price = 540 });
            products.Add(new Product { Id = "AEL022600", Name = "Visual C# 2019基礎必修課", Price = 530 });
            return View(products);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjController.Models;

namespace prjController.Controllers
{
    public class Sample01Controller : Controller
    {
        // GET: Sample01
        public ActionResult Index()
        {
            ViewData["Company"] = "大天才美食公司";
            List<Product> listProduct = new List<Product>();
            listProduct.Add
                (new Product { Id = "001", Name = "香草蛋糕", Price = 300 });
            listProduct.Add
                (new Product { Id = "002", Name = "草莓蛋糕", Price = 350 });
            listProduct.Add
                (new Product { Id = "003", Name = "香蕉蛋糕", Price = 400 });
            ViewBag.Product = listProduct;
            return View();
        }
    }
}
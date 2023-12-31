﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjController.Models;

namespace prjController.Controllers
{
    public class ComplexBindController : Controller
    {
        // GET: ComplexBind
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            ViewBag.Id = product.Id;
            ViewBag.Name = product.Name;
            ViewBag.Price = product.Price;
            return View();
        }
    }
}
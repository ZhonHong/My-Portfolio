using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.Models;
using System.Web.Security; //Web應用程式的表單驗證服務需引用此類別

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        //建立可存取dbShoppingCar,mdf 資料庫的dbShoppingCarEntities 類別物件db
        dbShoppingCarEntities db = new dbShoppingCarEntities();
        // GET: Home
        public ActionResult Index()
        {
            //取得所有產品放入products
            var products = db.tProduct.OrderByDescending(m => m.fId).ToList();
            return View(products);
        }
    }
}
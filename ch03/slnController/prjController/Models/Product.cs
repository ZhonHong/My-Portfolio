using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjController.Models
{
    public class Product
    {
        public string Id { get; set; }//產品編號
        public string Name { get; set; }//品名
        public int Price { get; set; }//單價
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practise_CreateTable.Controllers
{
    public class TeableProductController : Controller
    {
        public ActionResult Index(string name,int price,short colorCode, int count, bool exists)
        {
            ViewBag.Name = name;
            ViewBag.Price = price;
            ViewBag.ColorCode = colorCode;
            ViewBag.Count = count;
            ViewBag.Exists = exists;
            return View();
        }
    }
}
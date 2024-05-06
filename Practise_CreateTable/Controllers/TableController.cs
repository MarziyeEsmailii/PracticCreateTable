using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practise_CreateTable.Controllers
{
    public class TableController : Controller
    {
        public ActionResult Index(string name ,string family, string password,int age)
        {
            ViewBag.Name = name;
            ViewBag.Family = family;
            ViewBag.Password = password;
            ViewBag.Age = age;
            return View();
        }
    }
}
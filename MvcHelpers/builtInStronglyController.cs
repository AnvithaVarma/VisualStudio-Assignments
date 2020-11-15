using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcHelpers.Models;

namespace mvcHelpers.Controllers
{
    public class builtInStronglyController : Controller
    {
        // GET: builtInStrongly
        public ActionResult Index()
        {
            Class1 emp = new Class1() //instance for the model class-Class1
            {
                Name = "Anvitha",
                Address = "This is my address",
                IsEmployee = true
            };
            return View(emp);
        }
        [HttpPost]
        public ActionResult Index(Class1 emp)
        {
            return View();
        }
    }
}
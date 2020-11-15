using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practisingMVC.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        [OutputCache(Duration =15)]
        public ActionResult Index()
        {
            return View();
        }
        public string name()
        {
            return "My name is Anvitha";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace mvcHelpers.Controllers
{
    public class builtInStandardController : Controller
    {
        // GET: builtInStandard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
    }
}
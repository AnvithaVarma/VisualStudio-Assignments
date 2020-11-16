using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBFirstApproach.Models;

namespace DBFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Registration obj)
        {
            if (ModelState.IsValid)
            {
                DbApproachEntities db = new DbApproachEntities();
                db.Registrations.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using LoginForProject.Models;

namespace LoginForProject.Controllers
{
    public class LoginController : Controller
    {
        LoginEntities project = new LoginEntities();


        public ActionResult HomePage()
        {
            return View();
        }

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginTbl obj)
        {
            if(ModelState.IsValid)
            {
                if(project.LoginTbls.Where(x=>x.Username==obj.Username&&x.Password==obj.Password).FirstOrDefault()==null)
                {
                    ViewBag.data = "You are not Registered!";
                }
                else
                {
                    ViewBag.data = "Login is Successfull.";
                    return RedirectToAction("TransferFunds", "Login");
                }
            }


            return View();

        }

        public ActionResult TransferFunds()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TransferFunds(LoginTbl obj,string btn)
        {
            if(btn=="Transfer")
            {
                var data = project.LoginTbls.Where(x => x.AccountNo == obj.AccountNo).FirstOrDefault();
                if(obj.Amount!=null)
                {
                    data.Amount -= obj.Amount;
                    int mess = project.SaveChanges();
                    if(mess==1)
                    {
                        ViewBag.data = "Transfer is Done!";
                    }
                    else
                    {
                        ViewBag.data = "Transfer is not Successfull.";
                    }
                }
                else
                {
                    ViewBag.data = "Insufficient Balance.";
                }
            }


            if(btn== "View Balance")
            {
                var data = project.LoginTbls.Where(x => x.AccountNo == obj.AccountNo).FirstOrDefault();
                ViewBag.show = "The Available balance in your account is :  " + data.Amount;
            }
            //else
            //{
            //    ViewBag.show = "Wrong Details.";
            //}

            return View();
        }
    }
}
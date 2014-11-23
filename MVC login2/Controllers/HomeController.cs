using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_login2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            //return View();
            return RedirectToAction("login");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult login(Table u)
        {
            if (ModelState.IsValid)
            {
                using (loginEntities dc = new loginEntities())
                {
                    var v = dc.Tables.Where(a => a.username.Equals(u.username) && a.password.Equals(u.password)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["LoggedUserID"] = v.username.ToString();
                        return RedirectToAction("AfterLogin");
                    }
                }
            }
            return View(u);
        }

        public ActionResult AfterLogin()
        {
            if (Session["LoggedUserID"] != null)
            {

                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}

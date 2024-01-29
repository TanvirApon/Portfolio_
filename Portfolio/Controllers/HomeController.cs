using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message = "Education Page.";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Project page.";

            return View();
        }

        public ActionResult Refference()
        {
            ViewBag.Message = "Refference  page.";

            return View();
        }

        public ActionResult Personalinfo()
        {
            ViewBag.Message = "Personal Information page.";

            return View();
        }
    }
}
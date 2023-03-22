using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Userregistration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();

            
        }
        public ActionResult Form1()
        {
            return View();
        }

        public ActionResult Form2()
        {
            return View();
        }

        public ActionResult HtmlsuveyForm()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult  Signupform()
        {
            return View();
        }
        public ActionResult Table()
        {
            return View();
        }
    }
}
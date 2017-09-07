using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAASExamples.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.data = "test";

            Testing<string>(Add);
            return View();
        }
        void Testing<T>(Func<T> Val)
        {
            ViewBag.data = Val();
        }
        string Add()
        {
            return "add Method Test";
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
    }
}
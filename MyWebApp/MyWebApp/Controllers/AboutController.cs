using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult About()
        {
            ViewData["Message"] = "О нашем приложении";

            return View();
        }

    }
}
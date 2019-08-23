using MyWebApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public UserRepository UserRepository;

        public HomeController(UserRepository userRepository)
        {
            this.UserRepository = UserRepository;
        }

        // GET: Home
        public ActionResult Index()
        {
            var model = new HomeModel
            {
                Title = "Крутое приложение!",
                Time = DateTime.Now
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(HomeModel model)
        {
            model.Time = DateTime.Now;
            return View(model);
        }
    }
}
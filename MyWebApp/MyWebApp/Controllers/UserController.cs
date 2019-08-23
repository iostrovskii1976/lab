using MyWebApp.DAL.Repositories;
using MyWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebApp.DAL;

namespace MyWebApp.Controllers
{
    public class UserController : Controller
    {
        private UserRepository userRepository;

        public UserController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public ActionResult Create()
        {
            var model = new UserModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(UserModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new Person
            {
                Login = model.Login,
                Pass = model.Pass
            };
            userRepository.Save(user);

            return RedirectToAction("Index", "Home");
        }
        //// GET: User
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}
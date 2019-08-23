using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebApp.DAL;
using MyWebApp.DAL.Repositories;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class UserGroupController : Controller
    {
        private UserGroupRepositories userGroupRepositories;

        public UserGroupController(UserGroupRepositories userGroupRepositories)
        {
            this.userGroupRepositories = userGroupRepositories;
        }

        public ActionResult Create()
        {
            var model = new GroupModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(GroupModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var group = new UserGroup
            {
                Name = model.Name,
            };
            userGroupRepositories.Save(group);

            return RedirectToAction("Index", "Home");
        }
    }
}
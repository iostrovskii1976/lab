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
        private UserGroupRepository userGroupRepositories;

        public UserGroupController(UserGroupRepository userGroupRepositories)
        {
            this.userGroupRepositories = userGroupRepositories;
        }

        public ActionResult Create()
        {
            var model = new UserGroupModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(UserGroupModel model)
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
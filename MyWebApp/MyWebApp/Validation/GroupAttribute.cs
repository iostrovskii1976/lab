using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebApp.DAL.Repositories;

namespace MyWebApp.Validation
{
    public class GroupAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var group = value.ToString();
            var userGroupeRepositories = DependencyResolver.Current.GetService<UserGroupRepositories>();
            return !userGroupeRepositories.Exists(group);
        }
    }
}
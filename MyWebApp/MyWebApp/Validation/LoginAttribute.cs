﻿//Проверка на наличие такого пользователя в БД

using MyWebApp.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Validation 
{
    public class LoginAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var login = value.ToString();
            var userRepository = DependencyResolver.Current.GetService<UserRepository>();
            return !userRepository.Exists(login);
        }
    }
}
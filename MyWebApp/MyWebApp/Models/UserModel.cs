using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyWebApp.DAL;
using MyWebApp.Validation;

namespace MyWebApp.Models
{
    public class UserModel : EmtityModel<Person>
    {
        [Required]
        [Login]
        [DisplayName("Введите логин")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Введите пароль")]
        public string Pass { get; set; }

        [Compare("Pass")]
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Подтвердите пароль")]
        public string ConfirmPass { get; set; }

        [Required]
        [DisplayName("Введите группу")]
        public UserGroup Group { get; set; }
    }
}
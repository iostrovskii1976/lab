using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyWebApp.DAL;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MyWebApp.Validation;

namespace MyWebApp.Models
{
    public class GroupModel : EmtityModel<UserGroup>
    {
        [Required]
        //[Login]
        [DisplayName("Введите название группы")]
        public string Name { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyWebApp.DAL;

namespace MyWebApp.Models
{
    public class UserGroupListModel: EntityListModel<UserGroup>
    {
        [Required]
        [DisplayName("Введите группу")]
        public UserGroup Group { get; set; }
    }
}
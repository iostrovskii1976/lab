using MyWebApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class UserListModel: EntityListModel<Person>
    {
        public IList<UserGroup> Group { get; set; }
    }
}